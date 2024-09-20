using CsvHelper;
using EPiServer.PlugIn;
using EPiServer.Scheduler;
using EPiServer.Web.Routing;
using EPiServer.Web;
using Microsoft.AspNetCore.Hosting;
using System.Globalization;
using EPiServer.DataAccess;
using EPiServer.Security;
using Hexashop.Models.Pages;
using EPiServer.Data.Dynamic;
using EPiServer.Data;
using Hexashop.Business.DataStore;

namespace Hexashop.Business.Jobs.ProductImport
{
    [ScheduledPlugIn(
        DisplayName = "Products Import",
        GUID = "643181cb-edf7-4f87-b9ea-9187201bc835")]
    public class ProductImportScheuleJob : ScheduledJobBase
    {
        private bool _stopSignaled;

        ContentReference parentLink = new ContentReference(73);
        private string csvFilePath = @"app_data\\products.csv";

        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IContentTypeRepository<PageType> _pageTypeRepository;
        private readonly IContentRepository _contentRepository;
        private readonly IUrlSegmentCreator _urlSegmentCreator;
        private readonly IUrlResolver _urlResolver;
        private readonly DynamicDataStore _dataStore;

        private readonly ILogger<ProductImportScheuleJob> _logger;

        public ProductImportScheuleJob(
             IWebHostEnvironment webHostEnvironment,
             IContentTypeRepository<PageType> pageTypeRepository,
             IContentRepository contentRepository,
             IUrlSegmentCreator urlSegmentCreator,
             IUrlResolver urlResolver,
             ILogger<ProductImportScheuleJob> logger)
        {
            IsStoppable = true;
            _webHostEnvironment = webHostEnvironment;
            _pageTypeRepository = pageTypeRepository;
            _contentRepository = contentRepository;
            _urlSegmentCreator = urlSegmentCreator;
            _urlResolver = urlResolver;

            _dataStore = DynamicDataStoreFactory.Instance
                .CreateStore(typeof(ProductRating));

            _logger = logger;
        }

        /// <summary>
        /// Called when a user clicks on Stop for a manually started job, or when ASP.NET shuts down.
        /// </summary>
        public override void Stop()
        {
            _stopSignaled = true;
        }

        /// <summary>
        /// Called when a scheduled job executes
        /// </summary>
        /// <returns>A status message to be stored in the database log and visible from admin mode</returns>
        public override string Execute()
        {
            //Call OnStatusChanged to periodically notify progress of job for manually started jobs
            OnStatusChanged(String.Format("Starting execution of {0}", this.GetType()));

            //Add implementation
            ImportProducts();

            //For long running jobs periodically check if stop is signaled and if so stop execution
            if (_stopSignaled)
            {
                return "Stop of job was called";
            }

            return "Products imported successfully.";
        }

        private void ImportProducts()
        {
            string contentRootPath = _webHostEnvironment.ContentRootPath;
            using (var reader = new StreamReader(Path.Combine(contentRootPath, csvFilePath)))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var products = csv.GetRecords<ProductDto>();
                foreach (var product in products)
                {
                    CreateOrUpdateProductPage(product);
                    
                }
            }
        }

        private void DeleteExistingProducts()
        {
            _contentRepository.DeleteChildren(parentLink, true, AccessLevel.NoAccess);
        }

        private void CreateOrUpdateProductPage(ProductDto dto)
        {
            PageType productPageType = _pageTypeRepository.Load(typeof(ProductPage).Name);
            ProductPage productPage = _contentRepository.GetDefault<ProductPage>(parentLink, productPageType.ID) as ProductPage;

            ProductPage? existingProductPage = _contentRepository.GetChildren<ProductPage>(parentLink)
                .Where(a => a.Name == dto.Name).FirstOrDefault();

            if (existingProductPage != null)
                productPage = (ProductPage)existingProductPage.CreateWritableClone();

            productPage.Name = dto.Name;
            productPage.ProductName = dto.Name;
            productPage.Image = new Url(_urlResolver.GetUrl(new ContentReference(44)));

            productPage.URLSegment = _urlSegmentCreator.Create(productPage);
            productPage.Price = dto.Price;

            SaveAction propertySaveAction = SaveAction.Publish;
            if (productPage != null)
            {
                propertySaveAction = SaveAction.Publish | SaveAction.ForceCurrentVersion;
            }

            var productReference = _contentRepository.Save(productPage, propertySaveAction, AccessLevel.NoAccess);
            _logger.LogWarning($"{dto.Name} imported with id {productPage.ContentLink.ID}");

            //store rating in dds
            var rating = new ProductRating
            {
                ProductId = productReference.ID,
                Comments = "I love this product!",
                Stars = 5
            };

            Identity id = _dataStore.Save(rating);
            var savedRating = _dataStore.Load<ProductRating>(id);
        }
    }
}
