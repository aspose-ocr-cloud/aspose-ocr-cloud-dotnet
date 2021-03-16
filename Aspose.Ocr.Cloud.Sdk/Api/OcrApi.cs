// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="OcrApi.cs">
//   Copyright (c) 2019 Aspose.Ocr for Cloud
// </copyright>
// <summary>
//   Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.IO;
using Aspose.Ocr.Cloud.Sdk.Internal.Invoker;
using Aspose.Ocr.Cloud.Sdk.Internal.Invoker.RequestHandlers;

namespace Aspose.Ocr.Cloud.Sdk
{
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Aspose.Ocr.Cloud.Sdk.Model;
    using Aspose.Ocr.Cloud.Sdk.Model.Requests;

    /// <summary>
    /// Aspose.Ocr for Cloud API.
    /// </summary>
    public class OcrApi: OcrApiBase
    {        
        private readonly ApiInvoker apiInvoker;

        /// <summary>
        /// Initializes a new instance of the <see cref="OcrApi"/> class.
        /// </summary>
        /// <param name="apiKey">
        /// The api Key.
        /// </param>
        /// <param name="appSid">
        /// The app Sid.
        /// </param>
        public OcrApi(string apiKey, string appSid)
            : this(new Configuration { AppKey = apiKey, AppSid = appSid })
        {
        }

        public OcrApi(string jwtToken)
            : this(new Configuration { JwtToken = jwtToken, ApiVersion = ApiVersion.V3, AuthType = AuthType.JWT })
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="OcrApi"/> class.
        /// </summary>    
        /// <param name="configuration">Configuration settings</param>
        public OcrApi(Configuration configuration) : base(configuration)
        {
            var requestHandlers = new List<IRequestHandler>();
            switch (mConfiguration.AuthType)
            {
                case AuthType.JWT: requestHandlers.Add(new JwtRequestHandler(mConfiguration));
                    break;
            }

            requestHandlers.Add(new DebugLogRequestHandler(mConfiguration));
            requestHandlers.Add(new ApiExceptionRequestHandler());
            this.apiInvoker = new ApiInvoker(requestHandlers);
        }                            

        /// <summary>
        /// Recognize image text, language and text region can be selected 
        /// </summary>
        /// <param name="request">Request. <see cref="GetRecognizeDocumentRequest" /></param> 
        /// <returns><see cref="OCRResponse"/></returns>            
        public OCRResponse GetRecognizeDocument(GetRecognizeDocumentRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetRecognizeDocument");
            }

            // create path and map variables
            var resourcePath = this.mConfiguration.GetApiRootUrl() + "/ocr/{name}/recognize";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "language", request.language);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "resultType", request.resultType);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "dsrMode", request.dsrMode);

            try 
            {                               
                return this.apiInvoker.InvokeApi<OCRResponse>(
                    resourcePath, 
                    "GET", 
                    null, 
                    null, 
                    null);
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Recognize image text from some url if provided or from the request body content 
        /// </summary>
        /// <param name="request">Request. <see cref="PostOcrFromUrlOrContentRequest" /></param> 
        /// <returns><see cref="OCRResponse"/></returns>            
        public OCRResponse PostOcrFromUrlOrContent(PostOcrFromUrlOrContentRequest request)
        {
            // create path and map variables
            var resourcePath = this.mConfiguration.GetApiRootUrl() + "/ocr/recognize";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "url", request.url);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "language", request.language);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "resultType", request.resultType);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "dsrMode", request.dsrMode);

            if (request.File != null) 
            {
                formParams.Add("file", this.apiInvoker.ToFileInfo(request.File, "File"));
            }
            
            try 
            {                               
                return this.apiInvoker.InvokeApi<OCRResponse>(
                    resourcePath, 
                    "POST", 
                    null, 
                    null, 
                    formParams);
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Recognize specific regions of image from some url
        /// </summary>
        /// <param name="requestData">Regions, language and some options. <see cref="OCRRequestData"></see>/></param>
        /// <param name="urlToFile">Web url of image file to recognize</param>
        /// <returns><see cref="OCRResponse"/></returns>
        public OCRResponse OcrRegionsFromUrl(OCRRequestData requestData, string urlToFile)
        {
            var requestUrl = BuildUrl("recognize-regions-url");
            var formParams = new Dictionary<string, object> { {"url", urlToFile}, {"requestData", requestData} };
            return this.apiInvoker.InvokeApi<OCRResponse>(requestUrl, "POST", null, null, formParams);
        }

        /// <summary>
        /// Recognize specific regions of image from File Stream
        /// </summary>
        /// <param name="requestData">Regions, language and some options. <see cref="OCRRequestData"/></param>
        /// <param name="file">Local file stream</param>
        /// <returns><see cref="OCRResponse"/></returns>
        public OCRResponse OcrRegionsFromContent(OCRRequestData requestData, Stream file)
        {
            var requestUrl = BuildUrl("recognize-regions-content");
            var fileInfo = this.apiInvoker.ToFileInfo(file, "File");
            var formParams = new Dictionary<string, object> { { "file", fileInfo }, { "requestData", requestData } };
            return this.apiInvoker.InvokeApi<OCRResponse>(requestUrl, "POST", null, null, formParams);
        }

        /// <summary>
        /// Recognize specific regions of image located at Aspose Storage.
        /// Use StorageApi to upload your files. <see cref="StorageApi"/>
        /// </summary>
        /// <param name="requestData">Regions, language and file path in Aspose Storage. <see cref="OCRRequestData"/></param>
        /// <returns><see cref="OCRResponse"/></returns>
        public OCRResponse OcrRegionsFromStorage(OCRRequestDataStorage requestData)
        {
            var requestUrl = BuildUrl("recognize-regions-url");
            var formParams = new Dictionary<string, object> { { "requestData", requestData } };
            return this.apiInvoker.InvokeApi<OCRResponse>(requestUrl, "POST", null, null, formParams);
        }
    }
}