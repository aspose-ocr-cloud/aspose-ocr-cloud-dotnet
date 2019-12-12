// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="StorageApi.cs">
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
    public class StorageApi
    {        
        private readonly ApiInvoker apiInvoker;
        private readonly Configuration configuration;     

        /// <summary>
        /// Initializes a new instance of the <see cref="StorageApi"/> class.
        /// </summary>
        /// <param name="apiKey">
        /// The api Key.
        /// </param>
        /// <param name="appSid">
        /// The app Sid.
        /// </param>
        public StorageApi(string apiKey, string appSid)
            : this(new Configuration { AppKey = apiKey, AppSid = appSid })
        {
        }

        public StorageApi(string jwtToken)
            : this(new Configuration { JwtToken = jwtToken, ApiVersion = ApiVersion.V3, AuthType = AuthType.ExternalAuth })
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="StorageApi"/> class.
        /// </summary>    
        /// <param name="configuration">Configuration settings</param>
        public StorageApi(Configuration configuration)
        {
            this.configuration = configuration;
            
            var requestHandlers = new List<IRequestHandler>();
            switch (this.configuration.AuthType)
            {
                case AuthType.RequestSignature: requestHandlers.Add(new AuthWithSignatureRequestHandler(this.configuration));
                    break;
                case AuthType.OAuth2: requestHandlers.Add(new OAuthRequestHandler(this.configuration));
                    break;
                case AuthType.ExternalAuth: requestHandlers.Add(new ExternalAuthorizationRequestHandler(this.configuration));
                    break;
                case AuthType.JWT: requestHandlers.Add(new JwtRequestHandler(this.configuration));
                    break;
            }

            requestHandlers.Add(new DebugLogRequestHandler(this.configuration));
            requestHandlers.Add(new ApiExceptionRequestHandler());
            this.apiInvoker = new ApiInvoker(requestHandlers);
        }                            

        /// <summary>
        /// Get disc usage 
        /// </summary>
        /// <param name="request">Request. <see cref="GetDiscUsageRequest" /></param> 
        /// <returns><see cref="DiscUsage"/></returns>            
        public DiscUsage GetDiscUsage(GetDiscUsageRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/ocr/storage/disc";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.storageName);
            
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
                    return (DiscUsage)SerializationHelper.Deserialize(response, typeof(DiscUsage));
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
        /// Get file versions 
        /// </summary>
        /// <param name="request">Request. <see cref="GetFileVersionsRequest" /></param> 
        /// <returns><see cref="FileVersions"/></returns>            
        public FileVersions GetFileVersions(GetFileVersionsRequest request)
        {
            // verify the required parameter 'path' is set
            if (request.path == null) 
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling GetFileVersions");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/ocr/storage/version/{path}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.storageName);
            
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
                    return (FileVersions)SerializationHelper.Deserialize(response, typeof(FileVersions));
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
        /// Check if file or folder exists 
        /// </summary>
        /// <param name="request">Request. <see cref="ObjectExistsRequest" /></param> 
        /// <returns><see cref="ObjectExist"/></returns>            
        public ObjectExist ObjectExists(ObjectExistsRequest request)
        {
            // verify the required parameter 'path' is set
            if (request.path == null) 
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling ObjectExists");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/ocr/storage/exist/{path}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.storageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "versionId", request.versionId);
            
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
                    return (ObjectExist)SerializationHelper.Deserialize(response, typeof(ObjectExist));
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
        /// Check if storage exists 
        /// </summary>
        /// <param name="request">Request. <see cref="StorageExistsRequest" /></param> 
        /// <returns><see cref="StorageExist"/></returns>            
        public StorageExist StorageExists(StorageExistsRequest request)
        {
            // verify the required parameter 'storageName' is set
            if (request.storageName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'storageName' when calling StorageExists");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/ocr/storage/{storageName}/exist";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "storageName", request.storageName);
            
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
                    return (StorageExist)SerializationHelper.Deserialize(response, typeof(StorageExist));
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
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="GetDiscUsageRequest.cs">
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
namespace Aspose.Ocr.Cloud.Sdk.Model.Requests 
{
    /// <summary>
  /// Request model for <see cref="Aspose.Ocr.Cloud.Sdk.Api.OcrApi.GetDiscUsage" /> operation.
  /// </summary>  
  public class GetDiscUsageRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDiscUsageRequest"/> class.
        /// </summary>        
        public GetDiscUsageRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDiscUsageRequest"/> class.
        /// </summary>
        /// <param name="storageName">Storage name</param>
        public GetDiscUsageRequest(string storageName = null)             
        {
            this.storageName = storageName;
        }

        /// <summary>
        /// Storage name
        /// </summary>  
        public string storageName { get; set; }
  }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="GetFileVersionsRequest.cs">
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
namespace Aspose.Ocr.Cloud.Sdk.Model.Requests 
{
    /// <summary>
  /// Request model for <see cref="Aspose.Ocr.Cloud.Sdk.Api.OcrApi.GetFileVersions" /> operation.
  /// </summary>  
  public class GetFileVersionsRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetFileVersionsRequest"/> class.
        /// </summary>        
        public GetFileVersionsRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFileVersionsRequest"/> class.
        /// </summary>
        /// <param name="path">File path e.g. &#39;/file.ext&#39;</param>
        /// <param name="storageName">Storage name</param>
        public GetFileVersionsRequest(string path, string storageName = null)             
        {
            this.path = path;
            this.storageName = storageName;
        }

        /// <summary>
        /// File path e.g. '/file.ext'
        /// </summary>  
        public string path { get; set; }

        /// <summary>
        /// Storage name
        /// </summary>  
        public string storageName { get; set; }
  }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ObjectExistsRequest.cs">
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
namespace Aspose.Ocr.Cloud.Sdk.Model.Requests 
{
    /// <summary>
  /// Request model for <see cref="Aspose.Ocr.Cloud.Sdk.Api.OcrApi.ObjectExists" /> operation.
  /// </summary>  
  public class ObjectExistsRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectExistsRequest"/> class.
        /// </summary>        
        public ObjectExistsRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectExistsRequest"/> class.
        /// </summary>
        /// <param name="path">File or folder path e.g. &#39;/file.ext&#39; or &#39;/folder&#39;</param>
        /// <param name="storageName">Storage name</param>
        /// <param name="versionId">File version ID</param>
        public ObjectExistsRequest(string path, string storageName = null, string versionId = null)             
        {
            this.path = path;
            this.storageName = storageName;
            this.versionId = versionId;
        }

        /// <summary>
        /// File or folder path e.g. '/file.ext' or '/folder'
        /// </summary>  
        public string path { get; set; }

        /// <summary>
        /// Storage name
        /// </summary>  
        public string storageName { get; set; }

        /// <summary>
        /// File version ID
        /// </summary>  
        public string versionId { get; set; }
  }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="StorageExistsRequest.cs">
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
namespace Aspose.Ocr.Cloud.Sdk.Model.Requests 
{
    /// <summary>
  /// Request model for <see cref="Aspose.Ocr.Cloud.Sdk.Api.OcrApi.StorageExists" /> operation.
  /// </summary>  
  public class StorageExistsRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="StorageExistsRequest"/> class.
        /// </summary>        
        public StorageExistsRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StorageExistsRequest"/> class.
        /// </summary>
        /// <param name="storageName">Storage name</param>
        public StorageExistsRequest(string storageName)             
        {
            this.storageName = storageName;
        }

        /// <summary>
        /// Storage name
        /// </summary>  
        public string storageName { get; set; }
  }
}
