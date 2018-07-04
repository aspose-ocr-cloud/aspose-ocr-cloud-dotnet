using System;
using System.Collections.Generic;
using RestSharp;
using Com.Aspose.Ocr.Client;
using Com.Aspose.Ocr.Model;

namespace Com.Aspose.Ocr.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IOcrV2Api
    {
        /// <summary>
        /// Recognize image text, language and text region can be selected 
        /// </summary>
        /// <param name="name">Name of the file to recognize.</param>
        /// <param name="storage">Image&#39;s storage.</param>
        /// <param name="folder">Image&#39;s folder.</param>
        /// <returns>OCRResponse</returns>
        OCRResponse OcrV2GetRecognizeDocument (string name, string storage, string folder);
        /// <summary>
        /// Recognize image text from some url if provided or from the request body content, language can be selected 
        /// </summary>
        /// <param name="url">The image file url.</param>
        /// <param name="file">File to process</param>
        /// <returns>OCRResponse</returns>
        OCRResponse OcrV2PostOcrFromUrlOrContent (string url, System.IO.Stream file);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class OcrV2Api : IOcrV2Api
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OcrV2Api"/> class.
        /// </summary>
		/// <param name="apiKey">The api key.</param>
		/// <param name="apiSid">The api sid.</param>
        /// <param name="basePath">The base path.</param>
        public OcrV2Api(String apiKey, String apiSid, String basePath)
        {
            this.ApiClient = new ApiClient(apiKey, apiSid, basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        /// Recognize image text, language and text region can be selected 
        /// </summary>
        /// <param name="name">Name of the file to recognize.</param> 
        /// <param name="storage">Image&#39;s storage.</param> 
        /// <param name="folder">Image&#39;s folder.</param> 
        /// <returns>OCRResponse</returns>            
        public OCRResponse OcrV2GetRecognizeDocument (string name, string storage, string folder)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling OcrV2GetRecognizeDocument");
            
    
            var path = "/ocr/ocrV2/{name}/recognizeV2";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (storage != null) queryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
 if (folder != null) queryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling OcrV2GetRecognizeDocument: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OcrV2GetRecognizeDocument: " + response.ErrorMessage, response.ErrorMessage);
    
            return (OCRResponse) ApiClient.Deserialize(response.Content, typeof(OCRResponse), response.Headers);
        }
    
        /// <summary>
        /// Recognize image text from some url if provided or from the request body content, language can be selected 
        /// </summary>
        /// <param name="url">The image file url.</param> 
        /// <param name="file">File to process</param> 
        /// <returns>OCRResponse</returns>            
        public OCRResponse OcrV2PostOcrFromUrlOrContent (string url, System.IO.Stream file)
        {
            
    
            var path = "/ocr/ocrV2/recognizeV2";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (url != null) queryParams.Add("url", ApiClient.ParameterToString(url)); // query parameter
                        if (file != null) fileParams.Add("File", ApiClient.ParameterToFile("File", file));
                
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling OcrV2PostOcrFromUrlOrContent: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OcrV2PostOcrFromUrlOrContent: " + response.ErrorMessage, response.ErrorMessage);
    
            return (OCRResponse) ApiClient.Deserialize(response.Content, typeof(OCRResponse), response.Headers);
        }
    
    }
}
