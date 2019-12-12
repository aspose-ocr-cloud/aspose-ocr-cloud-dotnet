// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="FolderApi.cs">
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
    public class FolderApi
    {        
        private readonly ApiInvoker apiInvoker;
        private readonly Configuration configuration;     

        /// <summary>
        /// Initializes a new instance of the <see cref="FolderApi"/> class.
        /// </summary>
        /// <param name="apiKey">
        /// The api Key.
        /// </param>
        /// <param name="appSid">
        /// The app Sid.
        /// </param>
        public FolderApi(string apiKey, string appSid)
            : this(new Configuration { AppKey = apiKey, AppSid = appSid })
        {
        }

        public FolderApi(string jwtToken)
            : this(new Configuration { JwtToken = jwtToken, ApiVersion = ApiVersion.V3, AuthType = AuthType.ExternalAuth })
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="FolderApi"/> class.
        /// </summary>    
        /// <param name="configuration">Configuration settings</param>
        public FolderApi(Configuration configuration)
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
            }

            requestHandlers.Add(new DebugLogRequestHandler(this.configuration));
            requestHandlers.Add(new ApiExceptionRequestHandler());
            this.apiInvoker = new ApiInvoker(requestHandlers);
        }                            

        /// <summary>
        /// Copy folder 
        /// </summary>
        /// <param name="request">Request. <see cref="CopyFolderRequest" /></param> 
        /// <returns><see cref=""/></returns>            
        public void CopyFolder(CopyFolderRequest request)
        {
            // verify the required parameter 'srcPath' is set
            if (request.srcPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'srcPath' when calling CopyFolder");
            }

            // verify the required parameter 'destPath' is set
            if (request.destPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'destPath' when calling CopyFolder");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/ocr/storage/folder/copy/{srcPath}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "srcPath", request.srcPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destPath", request.destPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "srcStorageName", request.srcStorageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destStorageName", request.destStorageName);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "PUT", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return ;
                }
                    
                return ;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return ;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Create the folder 
        /// </summary>
        /// <param name="request">Request. <see cref="CreateFolderRequest" /></param> 
        /// <returns><see cref=""/></returns>            
        public void CreateFolder(CreateFolderRequest request)
        {
            // verify the required parameter 'path' is set
            if (request.path == null) 
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling CreateFolder");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/ocr/storage/folder/{path}";
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
                    "PUT", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return ;
                }
                    
                return ;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return ;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Delete folder 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFolderRequest" /></param> 
        /// <returns><see cref=""/></returns>            
        public void DeleteFolder(DeleteFolderRequest request)
        {
            // verify the required parameter 'path' is set
            if (request.path == null) 
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling DeleteFolder");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/ocr/storage/folder/{path}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.storageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "recursive", request.recursive);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "DELETE", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return ;
                }
                    
                return ;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return ;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Get all files and folders within a folder 
        /// </summary>
        /// <param name="request">Request. <see cref="GetFilesListRequest" /></param> 
        /// <returns><see cref="FilesList"/></returns>            
        public FilesList GetFilesList(GetFilesListRequest request)
        {
            // verify the required parameter 'path' is set
            if (request.path == null) 
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling GetFilesList");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/ocr/storage/folder/{path}";
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
                    return (FilesList)SerializationHelper.Deserialize(response, typeof(FilesList));
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
        /// Move folder 
        /// </summary>
        /// <param name="request">Request. <see cref="MoveFolderRequest" /></param> 
        /// <returns><see cref=""/></returns>            
        public void MoveFolder(MoveFolderRequest request)
        {
            // verify the required parameter 'srcPath' is set
            if (request.srcPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'srcPath' when calling MoveFolder");
            }

            // verify the required parameter 'destPath' is set
            if (request.destPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'destPath' when calling MoveFolder");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/ocr/storage/folder/move/{srcPath}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "srcPath", request.srcPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destPath", request.destPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "srcStorageName", request.srcStorageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destStorageName", request.destStorageName);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "PUT", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return ;
                }
                    
                return ;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return ;
                }
                
                throw;                
            }
        }
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="CopyFolderRequest.cs">
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
  /// Request model for <see cref="Aspose.Ocr.Cloud.Sdk.Api.OcrApi.CopyFolder" /> operation.
  /// </summary>  
  public class CopyFolderRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="CopyFolderRequest"/> class.
        /// </summary>        
        public CopyFolderRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CopyFolderRequest"/> class.
        /// </summary>
        /// <param name="srcPath">Source folder path e.g. &#39;/src&#39;</param>
        /// <param name="destPath">Destination folder path e.g. &#39;/dst&#39;</param>
        /// <param name="srcStorageName">Source storage name</param>
        /// <param name="destStorageName">Destination storage name</param>
        public CopyFolderRequest(string srcPath, string destPath, string srcStorageName = null, string destStorageName = null)             
        {
            this.srcPath = srcPath;
            this.destPath = destPath;
            this.srcStorageName = srcStorageName;
            this.destStorageName = destStorageName;
        }

        /// <summary>
        /// Source folder path e.g. '/src'
        /// </summary>  
        public string srcPath { get; set; }

        /// <summary>
        /// Destination folder path e.g. '/dst'
        /// </summary>  
        public string destPath { get; set; }

        /// <summary>
        /// Source storage name
        /// </summary>  
        public string srcStorageName { get; set; }

        /// <summary>
        /// Destination storage name
        /// </summary>  
        public string destStorageName { get; set; }
  }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="CreateFolderRequest.cs">
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
  /// Request model for <see cref="Aspose.Ocr.Cloud.Sdk.Api.OcrApi.CreateFolder" /> operation.
  /// </summary>  
  public class CreateFolderRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFolderRequest"/> class.
        /// </summary>        
        public CreateFolderRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFolderRequest"/> class.
        /// </summary>
        /// <param name="path">Folder path to create e.g. &#39;folder_1/folder_2/&#39;</param>
        /// <param name="storageName">Storage name</param>
        public CreateFolderRequest(string path, string storageName = null)             
        {
            this.path = path;
            this.storageName = storageName;
        }

        /// <summary>
        /// Folder path to create e.g. 'folder_1/folder_2/'
        /// </summary>  
        public string path { get; set; }

        /// <summary>
        /// Storage name
        /// </summary>  
        public string storageName { get; set; }
  }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="DeleteFolderRequest.cs">
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
  /// Request model for <see cref="Aspose.Ocr.Cloud.Sdk.Api.OcrApi.DeleteFolder" /> operation.
  /// </summary>  
  public class DeleteFolderRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteFolderRequest"/> class.
        /// </summary>        
        public DeleteFolderRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteFolderRequest"/> class.
        /// </summary>
        /// <param name="path">Folder path e.g. &#39;/folder&#39;</param>
        /// <param name="storageName">Storage name</param>
        /// <param name="recursive">Enable to delete folders, subfolders and files</param>
        public DeleteFolderRequest(string path, string storageName = null, bool? recursive = null)             
        {
            this.path = path;
            this.storageName = storageName;
            this.recursive = recursive;
        }

        /// <summary>
        /// Folder path e.g. '/folder'
        /// </summary>  
        public string path { get; set; }

        /// <summary>
        /// Storage name
        /// </summary>  
        public string storageName { get; set; }

        /// <summary>
        /// Enable to delete folders, subfolders and files
        /// </summary>  
        public bool? recursive { get; set; }
  }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="GetFilesListRequest.cs">
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
  /// Request model for <see cref="Aspose.Ocr.Cloud.Sdk.Api.OcrApi.GetFilesList" /> operation.
  /// </summary>  
  public class GetFilesListRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetFilesListRequest"/> class.
        /// </summary>        
        public GetFilesListRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFilesListRequest"/> class.
        /// </summary>
        /// <param name="path">Folder path e.g. &#39;/folder&#39;</param>
        /// <param name="storageName">Storage name</param>
        public GetFilesListRequest(string path, string storageName = null)             
        {
            this.path = path;
            this.storageName = storageName;
        }

        /// <summary>
        /// Folder path e.g. '/folder'
        /// </summary>  
        public string path { get; set; }

        /// <summary>
        /// Storage name
        /// </summary>  
        public string storageName { get; set; }
  }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="MoveFolderRequest.cs">
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
  /// Request model for <see cref="Aspose.Ocr.Cloud.Sdk.Api.OcrApi.MoveFolder" /> operation.
  /// </summary>  
  public class MoveFolderRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="MoveFolderRequest"/> class.
        /// </summary>        
        public MoveFolderRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MoveFolderRequest"/> class.
        /// </summary>
        /// <param name="srcPath">Folder path to move e.g. &#39;/folder&#39;</param>
        /// <param name="destPath">Destination folder path to move to e.g &#39;/dst&#39;</param>
        /// <param name="srcStorageName">Source storage name</param>
        /// <param name="destStorageName">Destination storage name</param>
        public MoveFolderRequest(string srcPath, string destPath, string srcStorageName = null, string destStorageName = null)             
        {
            this.srcPath = srcPath;
            this.destPath = destPath;
            this.srcStorageName = srcStorageName;
            this.destStorageName = destStorageName;
        }

        /// <summary>
        /// Folder path to move e.g. '/folder'
        /// </summary>  
        public string srcPath { get; set; }

        /// <summary>
        /// Destination folder path to move to e.g '/dst'
        /// </summary>  
        public string destPath { get; set; }

        /// <summary>
        /// Source storage name
        /// </summary>  
        public string srcStorageName { get; set; }

        /// <summary>
        /// Destination storage name
        /// </summary>  
        public string destStorageName { get; set; }
  }
}
