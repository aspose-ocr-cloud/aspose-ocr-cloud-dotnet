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
    public interface IOcrApi
    {
        /// <summary>
        /// Recognize image text, language and text region can be selected 
        /// </summary>
        /// <param name="name">Name of the file to recognize.</param>
        /// <param name="language">Language of the document.</param>
        /// <param name="rectX">Top left point X coordinate of  to recognize text inside.</param>
        /// <param name="rectY">Top left point Y coordinate of  to recognize text inside.</param>
        /// <param name="rectWidth">Width of  to recognize text inside.</param>
        /// <param name="rectHeight">Height of  to recognize text inside.</param>
        /// <param name="doSpellCorrection">value indicating whether spelling correction is used</param>
        /// <param name="skewCorrection">value indicating whether automatic skew correction is used</param>
        /// <param name="storage">Image&#39;s storage.</param>
        /// <param name="folder">Image&#39;s folder.</param>
        /// <returns>OCRResponse</returns>
        OCRResponse OcrGetRecognizeDocument (string name, string language, int? rectX, int? rectY, int? rectWidth, int? rectHeight, bool? doSpellCorrection, bool? skewCorrection, string storage, string folder);
        /// <summary>
        /// Recognize image text from some url if provided or from the request body content, language can be selected 
        /// </summary>
        /// <param name="url">The image file url.</param>
        /// <param name="language">Language of the document.</param>
        /// <param name="doSpellCorrection">value indicating whether spelling correction is used</param>
        /// <param name="skewCorrection">value indicating whether automatic skew correction is used</param>
        /// <param name="file">File to process</param>
        /// <returns>OCRResponse</returns>
        OCRResponse OcrPostOcrFromUrlOrContent (string url, string language, bool? doSpellCorrection, bool? skewCorrection, System.IO.Stream file);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class OcrApi : IOcrApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OcrApi"/> class.
        /// </summary>
		/// <param name="apiKey">The api key.</param>
		/// <param name="apiSid">The api sid.</param>
        /// <param name="basePath">The base path.</param>
        public OcrApi(String apiKey, String apiSid, String basePath)
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
        /// <param name="language">Language of the document.</param> 
        /// <param name="rectX">Top left point X coordinate of  to recognize text inside.</param> 
        /// <param name="rectY">Top left point Y coordinate of  to recognize text inside.</param> 
        /// <param name="rectWidth">Width of  to recognize text inside.</param> 
        /// <param name="rectHeight">Height of  to recognize text inside.</param> 
        /// <param name="doSpellCorrection">value indicating whether spelling correction is used</param> 
        /// <param name="skewCorrection">value indicating whether automatic skew correction is used</param> 
        /// <param name="storage">Image&#39;s storage.</param> 
        /// <param name="folder">Image&#39;s folder.</param> 
        /// <returns>OCRResponse</returns>            
        public OCRResponse OcrGetRecognizeDocument (string name, string language, int? rectX, int? rectY, int? rectWidth, int? rectHeight, bool? doSpellCorrection, bool? skewCorrection, string storage, string folder)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling OcrGetRecognizeDocument");
            
    
            var path = "/ocr/{name}/recognize";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (language != null) queryParams.Add("language", ApiClient.ParameterToString(language)); // query parameter
 if (rectX != null) queryParams.Add("rectX", ApiClient.ParameterToString(rectX)); // query parameter
 if (rectY != null) queryParams.Add("rectY", ApiClient.ParameterToString(rectY)); // query parameter
 if (rectWidth != null) queryParams.Add("rectWidth", ApiClient.ParameterToString(rectWidth)); // query parameter
 if (rectHeight != null) queryParams.Add("rectHeight", ApiClient.ParameterToString(rectHeight)); // query parameter
 if (doSpellCorrection != null) queryParams.Add("doSpellCorrection", ApiClient.ParameterToString(doSpellCorrection)); // query parameter
 if (skewCorrection != null) queryParams.Add("skewCorrection", ApiClient.ParameterToString(skewCorrection)); // query parameter
 if (storage != null) queryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
 if (folder != null) queryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling OcrGetRecognizeDocument: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OcrGetRecognizeDocument: " + response.ErrorMessage, response.ErrorMessage);
    
            return (OCRResponse) ApiClient.Deserialize(response.Content, typeof(OCRResponse), response.Headers);
        }
    
        /// <summary>
        /// Recognize image text from some url if provided or from the request body content, language can be selected 
        /// </summary>
        /// <param name="url">The image file url.</param> 
        /// <param name="language">Language of the document.</param> 
        /// <param name="doSpellCorrection">value indicating whether spelling correction is used</param> 
        /// <param name="skewCorrection">value indicating whether automatic skew correction is used</param> 
        /// <param name="file">File to process</param> 
        /// <returns>OCRResponse</returns>            
        public OCRResponse OcrPostOcrFromUrlOrContent (string url, string language, bool? doSpellCorrection, bool? skewCorrection, System.IO.Stream file)
        {
            
    
            var path = "/ocr/recognize";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (url != null) queryParams.Add("url", ApiClient.ParameterToString(url)); // query parameter
 if (language != null) queryParams.Add("language", ApiClient.ParameterToString(language)); // query parameter
 if (doSpellCorrection != null) queryParams.Add("doSpellCorrection", ApiClient.ParameterToString(doSpellCorrection)); // query parameter
 if (skewCorrection != null) queryParams.Add("skewCorrection", ApiClient.ParameterToString(skewCorrection)); // query parameter
                        if (file != null) fileParams.Add("File", ApiClient.ParameterToFile("File", file));
                
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling OcrPostOcrFromUrlOrContent: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OcrPostOcrFromUrlOrContent: " + response.ErrorMessage, response.ErrorMessage);
    
            return (OCRResponse) ApiClient.Deserialize(response.Content, typeof(OCRResponse), response.Headers);
        }
    
    }
}
