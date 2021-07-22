using Aspose.Ocr.Cloud.Sdk;
using Aspose.Ocr.Cloud.Sdk.Model;
using Aspose.Ocr.Cloud.Sdk.Model.Requests;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Aspose.OCR.Cloud.Live.Demos.Services
{
    public interface IAsposeOCRCloudApiService
    {
        string Convert(Stream file, string fileName, string language);
    }

    public class AsposeOCRCloudApiService : IAsposeOCRCloudApiService
    {
        public readonly OcrApi OCRCloudApi;
        public readonly FileApi OCRFileApi;

        public AsposeOCRCloudApiService(IConfiguration config)
        {
            string ClientId = config["AsposeOCRUserData:ClientId"];
            string ClientSecret = config["AsposeOCRUserData:ClientSecret"];

            OCRCloudApi = new OcrApi(apiKey: ClientSecret, appSid: ClientId);
            OCRFileApi = new FileApi(apiKey: ClientSecret, appSid: ClientId);
        }

        public string Convert(Stream file, string fileName, string language)
        {
            LanguageEnum lg = LanguageEnum.English;
            System.Enum.TryParse<LanguageEnum>(language, true, out lg);

            UploadFileRequest uploadFileRequest = new UploadFileRequest()
            {
                path = fileName,
                File = file
            };
            OCRFileApi.UploadFile(uploadFileRequest);

            GetRecognizeDocumentRequest request = new GetRecognizeDocumentRequest(name: fileName, language: lg);
            OCRResponse response = OCRCloudApi.GetRecognizeDocument(request);

            OCRFileApi.DeleteFile(new DeleteFileRequest(path: fileName));

            return response.Text;
        }
    }

}
