using System.Threading.Tasks;
using System.IO;
using System.Web.Http;
using Aspose.OCR.Cloud.Live.Demos.UI.Models;
using System.Diagnostics;
using Newtonsoft.Json.Linq;
using System;
using Aspose.Ocr.Cloud.Sdk.Model.Requests;
using Aspose.Ocr.Cloud.Sdk.Model;
using Aspose.Ocr.Cloud.Sdk;

namespace Aspose.OCR.Cloud.Live.Demos.UI.Models
{
    ///<Summary>
    /// Aspose.OCR Cloud API convert method to convert word document file to other format
    ///</Summary>

    public class AsposeOCRConversion : AsposeOCRCloudBase
    {
        ///<Summary>
        /// Convert method to convert file to other format
        ///</Summary>
        public Response Convert(string fileName, string folderName, string language)
        {
            LanguageGroup lg = LanguageGroup.English;

            language = language.ToLower();

            if (language == "english" || language=="spanish" || language == "portuguese")
            {
                lg = LanguageGroup.English;
            }
            else if (language == "french")
            {
                lg = LanguageGroup.French;
            }
            else if (language == "german")
            {
                lg = LanguageGroup.German;
            }

            Configuration conf = new Configuration();
            conf.AppKey = Config.Configuration.AppKey;
            conf.AppSid = Config.Configuration.AppSID;

            OcrApi api = new OcrApi(conf);
            GetRecognizeDocumentRequest request= new GetRecognizeDocumentRequest(name:fileName, language: lg);
            OCRResponse response = api.GetRecognizeDocument(request);

            string res = response.Text;

            byte[] byteArray = System.Text.Encoding.UTF8.GetBytes(res);
            MemoryStream stream = new MemoryStream(byteArray);

            string outputFileName = "Recognized.txt";
            FileApi fileApi = new FileApi(conf);
            fileApi.UploadFile(new UploadFileRequest(outputFileName, stream));

            bool foundSaveOption = true;

            if (foundSaveOption)
            {
                return new Response
                {
                    FileName = outputFileName,
                    Status = "OK",
                    StatusCode = 200,
                };
            }

            return new Response
            {
                FileName = null,
                Status = "Output type not found",
                StatusCode = 500
            };

        }

    }
}
