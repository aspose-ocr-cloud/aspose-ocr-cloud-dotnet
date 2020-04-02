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

namespace Aspose.Ocr.Cloud.Sdk
{
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Aspose.Ocr.Cloud.Sdk.Model;
    using Aspose.Ocr.Cloud.Sdk.Model.Requests;
    using Aspose.Ocr.Cloud.Sdk.RequestHandlers;
    
    /// <summary>
    /// Aspose.Ocr for Cloud API.
    /// </summary>
    public class OcrApi
    {        
        private readonly ApiInvoker apiInvoker;
        private readonly Configuration configuration;     

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
        public OcrApi(Configuration configuration)
        {
            this.configuration = configuration;
            
            var requestHandlers = new List<IRequestHandler>();
            switch (this.configuration.AuthType)
            {
                case AuthType.JWT: requestHandlers.Add(new JwtRequestHandler(this.configuration));
                    break;
            }

            requestHandlers.Add(new DebugLogRequestHandler(this.configuration));
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
            var resourcePath = this.configuration.GetApiRootUrl() + "/ocr/{name}/recognize";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "language", request.language);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "GET", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (OCRResponse)SerializationHelper.Deserialize(response, typeof(OCRResponse));
                }
                    
                return null;
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
            var resourcePath = this.configuration.GetApiRootUrl() + "/ocr/recognize";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "url", request.url);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "language", request.language);
            
            if (request.File != null) 
            {
                formParams.Add("file", this.apiInvoker.ToFileInfo(request.File, "File"));
            }
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "POST", 
                    null, 
                    null, 
                    formParams);
                if (response != null)
                {
                    return (OCRResponse)SerializationHelper.Deserialize(response, typeof(OCRResponse));
                }
                    
                return null;
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
    }
}