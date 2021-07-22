using Aspose.OCR.Cloud.Live.Demos.Models;
using Aspose.OCR.Cloud.Live.Demos.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.IO;
using System.Threading.Tasks;


namespace Aspose.OCR.Cloud.Live.Demos.Controllers
{
    public class ConversionController : BaseController
    {
        public ConversionController(IMemoryCache cache, IAsposeOCRCloudApiService ocrService) : base(cache)
        {
            OCRService = ocrService;
        }

        public override string Product => (string)RouteData.Values["product"];

        public IAsposeOCRCloudApiService OCRService { get; }

        public IActionResult Conversion()
        {
            var model = new ViewModel(this, nameof(Conversion))
            {
                SaveAsComponent = true,
                MaximumUploadFiles = 1,
                UseSorting = false
            };

            return View(model);
        }

        [HttpPost]
        public async Task<Response> Conversion(string outputType)
        {
            IFormFile postedFile = Request.Form.Files[0];
            string fileName = postedFile.FileName;
            string fileData = string.Empty;
            string outputFileName = "Recognized.txt";

            using (MemoryStream ms = new MemoryStream())
            {
                await postedFile.CopyToAsync(ms);
                ms.Position = 0;

                string language = outputType;
                var file = ms;

                string recognizedText = OCRService.Convert(file, fileName, language);
                byte[] byteArray = System.Text.Encoding.UTF8.GetBytes(recognizedText);
                fileData = Convert.ToHexString(byteArray);
            }

            return new Response
            {
                StatusCode = 200,
                FileName = outputFileName,
                FileData = fileData
            };
        }
    }
}
