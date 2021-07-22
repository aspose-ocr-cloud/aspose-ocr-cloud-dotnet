using Aspose.OCR.Cloud.Live.Demos.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace Aspose.OCR.Cloud.Live.Demos.Controllers
{
    public class HomeController : BaseController
    {
        public override string Product => string.Empty;

        public HomeController(IMemoryCache cache) : base(cache)
        {
        }

        public IActionResult Default()
        {
            ViewBag.PageTitle = Resources["ocrConversionPageTitle"];
            ViewBag.MetaDescription = Resources["ocrConversionMetaDescription"];

            var model = new LandingPageModel(this);
            return View(model);
        }
    }
}
