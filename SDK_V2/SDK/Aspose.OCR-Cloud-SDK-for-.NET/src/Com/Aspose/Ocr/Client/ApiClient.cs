using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.IO;
using System.Web;
using System.Linq;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Extensions;

namespace Com.Aspose.Ocr.Client
{
    /// <summary>
    /// API client is mainly responible for making the HTTP call to the API backend.
    /// </summary>
    public class ApiClient
    {
		public class OAuth2 : IAuthenticator
        {
            public class AuthData
            {

                public string AccessToken { get; private set; }
                public string TokenType { get; private set; }
                public int ExpiresInSeconds { get; private set; }
                public string RefreshToken { get; private set; }
                public string ClientId { get; private set; }
                public int ClientRefreshTokenLifeTimeInMinutes { get; private set; }
                public DateTime IssuedOn { get; private set; }
                public DateTime ExpiresOn => IssuedOn.AddSeconds(ExpiresInSeconds);
                public DateTime RefreshTokenExpiresOn => IssuedOn.AddMinutes(ClientRefreshTokenLifeTimeInMinutes);

                public string Error { get; private set; }
                public string ErrorDescription { get; private set; }

                public bool HasError => !string.IsNullOrEmpty(Error); 
                static public AuthData Parse(string content)
                {
                    AuthData result = new AuthData();
                    Dictionary<string, object> dict =
                        JsonConvert.DeserializeObject<Dictionary<string, object>>(content);
                    if (dict.ContainsKey("error"))
                    {
                        result.Error = dict["error"].ToString();
                        result.ErrorDescription = dict.ContainsKey("error_description") ? dict["error_description"].ToString() : "";
                    }
                    if (dict.ContainsKey("access_token"))
                    {
                        result.AccessToken = dict["access_token"].ToString();
                        result.TokenType = dict["token_type"].ToString();
                        result.ExpiresInSeconds = Convert.ToInt32(dict["expires_in"]);
                        result.RefreshToken = dict["refresh_token"].ToString();
                        result.ClientId = dict["client_id"].ToString();
                        result.ClientRefreshTokenLifeTimeInMinutes =
                            Convert.ToInt32(dict["clientRefreshTokenLifeTimeInMinutes"]);
                        result.IssuedOn = DateTime.Now;
                    }

                    return result;
                }
            }

            private string ClientId;
            private string ClientSecret;

            private string AuthorizationHeaderValue
            {
                get
                {
                    if (string.IsNullOrEmpty(authData?.TokenType))
                        return string.Empty;

                    char[] tokenType = authData?.TokenType.ToCharArray();
                    tokenType[0] = char.ToUpper(tokenType[0]);
                    return $"{new String(tokenType)} {authData?.AccessToken}";
                }
            }

            public OAuth2(string clientId, string clientSecret)
            {
                ClientId = clientId;
                ClientSecret = clientSecret;
                authData = null;
                authFlow = AuthFlow.ObtainAccessTokenPending;
            }
            private AuthData authData;

            enum AuthFlow
            {
                ObtainAccessTokenPending,
                RefreshAccessTokenPending,
                Obtained
            }

            private AuthFlow authFlow;
            public void Authenticate(IRestClient client, IRestRequest request)
            {

                if (authFlow != AuthFlow.Obtained)
                {
                    var restclient = new RestClient(GetHost(client.BaseUrl));
                    IRestRequest authRequest = null;
                    switch (authFlow)
                    {
                        case AuthFlow.ObtainAccessTokenPending:
                            authRequest = GetAuthRequest("client_credentials")
                                .AddParameter("client_id", ClientId)
                                .AddParameter("client_secret", ClientSecret);
                            break;
                        case AuthFlow.RefreshAccessTokenPending:
                            authRequest = GetAuthRequest("refresh_token")
                                .AddParameter("refresh_token", authData?.RefreshToken);
                            break;
                        default:
                            throw new Exception($"Wrong OAuth2 flow");
                    }
                    var authResponse = restclient.Execute(authRequest);

                    authData = AuthData.Parse(authResponse.Content);
                    authFlow = AuthFlow.Obtained;
                }

                if (authData.HasError)
                    throw new Exception($"Authentication error: {authData.Error}", new Exception(authData.ErrorDescription));
                request.AddHeader("Authorization", AuthorizationHeaderValue);
                
            }

            private string  GetHost(string url)
            {
                return new Uri(url).GetComponents(UriComponents.SchemeAndServer, UriFormat.SafeUnescaped);
            }

            IRestRequest GetAuthRequest(string grantType)
            {
                RestRequest authRequest = new RestRequest("oauth2/token") { Method = Method.POST };
                return authRequest.AddHeader("Accept", "application/json")
                    .AddHeader("Content-Type", "application/x-www-form-urlencoded")
                    .AddParameter("grant_type", grantType);
            }
            public void RefreshToken()
            {
                authFlow = AuthFlow.RefreshAccessTokenPending;
            }
        }
        private readonly Dictionary<String, String> _defaultHeaderMap = new Dictionary<String, String>();
		OAuth2 authenticator = null;
		
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiClient" /> class.
        /// </summary>
		/// <param name="apiKey">The api key.</param>
		/// <param name="apiSid">The api sid.</param>
        /// <param name="basePath">The base path.</param>
        public ApiClient(String apiKey, String apiSid, String basePath="https://saltov-gpu-3.dynabic.com/v1.1")
        {
            BasePath = basePath;
			authenticator = new OAuth2(apiSid, apiKey);
            RestClient = new RestClient(BasePath);
            RestClient.Authenticator = authenticator;            
        }
    
        /// <summary>
        /// Gets or sets the base path.
        /// </summary>
        /// <value>The base path</value>
        public string BasePath { get; set; }
    
        /// <summary>
        /// Gets or sets the RestClient.
        /// </summary>
        /// <value>An instance of the RestClient</value>
        public RestClient RestClient { get; set; }
    
        /// <summary>
        /// Gets the default header.
        /// </summary>
        public Dictionary<String, String> DefaultHeader
        {
            get { return _defaultHeaderMap; }
        }
    
        /// <summary>
        /// Makes the HTTP request (Sync).
        /// </summary>
        /// <param name="path">URL path.</param>
        /// <param name="method">HTTP method.</param>
        /// <param name="queryParams">Query parameters.</param>
        /// <param name="postBody">HTTP body (POST request).</param>
        /// <param name="headerParams">Header parameters.</param>
        /// <param name="formParams">Form parameters.</param>
        /// <param name="fileParams">File parameters.</param>
        /// <param name="authSettings">Authentication settings.</param>
        /// <returns>Object</returns>
        public Object CallApi(String path, RestSharp.Method method, Dictionary<String, String> queryParams, String postBody,
            Dictionary<String, String> headerParams, Dictionary<String, String> formParams, 
            Dictionary<String, FileParameter> fileParams, String[] authSettings)
        {

            int retries = 2;
            RestResponse result = null;

            while (retries-- > 0)
			{
				var request = new RestRequest(path, method);
	   
				UpdateParamsForAuth(queryParams, headerParams, authSettings);

				// add default header, if any
				foreach(var defaultHeader in _defaultHeaderMap)
					request.AddHeader(defaultHeader.Key, defaultHeader.Value);

				// add header parameter, if any
				foreach(var param in headerParams)
					request.AddHeader(param.Key, param.Value);

				// add query parameter, if any
				foreach(var param in queryParams)
					request.AddParameter(param.Key, param.Value, ParameterType.GetOrPost);

				// add form parameter, if any
				foreach(var param in formParams)
					request.AddParameter(param.Key, param.Value, ParameterType.GetOrPost);

				// add file parameter, if any
				foreach(var param in fileParams)
					request.AddFile(param.Value.Name, param.Value.Writer, param.Value.FileName, param.Value.ContentType);

				if (postBody != null) // http body (model) parameter
					request.AddParameter("application/json", postBody, ParameterType.RequestBody);

				result = RestClient.Execute(request);

                if (result.StatusCode == HttpStatusCode.Unauthorized || result.StatusCode == HttpStatusCode.Forbidden)
                {
                    authenticator.RefreshToken();
                    continue;
                }
                break;
            }
            return (Object) result;

        }
    
        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        public void AddDefaultHeader(string key, string value)
        {
            _defaultHeaderMap.Add(key, value);
        }
    
        /// <summary>
        /// Escape string (url-encoded).
        /// </summary>
        /// <param name="str">String to be escaped.</param>
        /// <returns>Escaped string.</returns>
        public string EscapeString(string str)
        {
            return RestSharp.Contrib.HttpUtility.UrlEncode(str);
        }
    
        /// <summary>
        /// Create FileParameter based on Stream.
        /// </summary>
        /// <param name="name">Parameter name.</param>
        /// <param name="stream">Input stream.</param>
        /// <returns>FileParameter.</returns>
        public FileParameter ParameterToFile(string name, Stream stream)
        {
            if (stream is FileStream)
                return FileParameter.Create(name, stream.ReadAsBytes(), Path.GetFileName(((FileStream)stream).Name));
            else
                return FileParameter.Create(name, stream.ReadAsBytes(), "no_file_name_provided");
        }
    
        /// <summary>
        /// If parameter is DateTime, output in a formatted string (default ISO 8601), customizable with Configuration.DateTime.
        /// If parameter is a list of string, join the list with ",".
        /// Otherwise just return the string.
        /// </summary>
        /// <param name="obj">The parameter (header, path, query, form).</param>
        /// <returns>Formatted string.</returns>
        public string ParameterToString(object obj)
        {
            if (obj is DateTime)
                // Return a formatted date string - Can be customized with Configuration.DateTimeFormat
                // Defaults to an ISO 8601, using the known as a Round-trip date/time pattern ("o")
                // https://msdn.microsoft.com/en-us/library/az4se3k1(v=vs.110).aspx#Anchor_8
                // For example: 2009-06-15T13:45:30.0000000
                return ((DateTime)obj).ToString (Configuration.DateTimeFormat);
            else if (obj is List<string>)
                return String.Join(",", (obj as List<string>).ToArray());
            else
                return Convert.ToString (obj);
        }
    
        /// <summary>
        /// Deserialize the JSON string into a proper object.
        /// </summary>
        /// <param name="content">HTTP body (e.g. string, JSON).</param>
        /// <param name="type">Object type.</param>
        /// <param name="headers">HTTP headers.</param>
        /// <returns>Object representation of the JSON string.</returns>
        public object Deserialize(string content, Type type, IList<Parameter> headers=null)
        {
            if (type == typeof(Object)) // return an object
            {
                return content;
            }

            if (type == typeof(Stream))
            {
                var filePath = String.IsNullOrEmpty(Configuration.TempFolderPath)
                    ? Path.GetTempPath()
                    : Configuration.TempFolderPath;

                var fileName = filePath + Guid.NewGuid();
                if (headers != null)
                {
                    var regex = new Regex(@"Content-Disposition:.*filename=['""]?([^'""\s]+)['""]?$");
                    var match = regex.Match(headers.ToString());
                    if (match.Success)
                        fileName = filePath + match.Value.Replace("\"", "").Replace("'", "");
                }
                File.WriteAllText(fileName, content);
                return new FileStream(fileName, FileMode.Open);

            }

            if (type.Name.StartsWith("System.Nullable`1[[System.DateTime")) // return a datetime object
            {
                return DateTime.Parse(content,  null, System.Globalization.DateTimeStyles.RoundtripKind);
            }

            if (type == typeof(String) || type.Name.StartsWith("System.Nullable")) // return primitive type
            {
                return ConvertType(content, type); 
            }
    
            // at this point, it must be a model (json)
            try
            {
                return JsonConvert.DeserializeObject(content, type);
            }
            catch (IOException e)
            {
                throw new ApiException(500, e.Message);
            }
        }
    
        /// <summary>
        /// Serialize an object into JSON string.
        /// </summary>
        /// <param name="obj">Object.</param>
        /// <returns>JSON string.</returns>
        public string Serialize(object obj)
        {
            try
            {
                return obj != null ? JsonConvert.SerializeObject(obj) : null;
            }
            catch (Exception e)
            {
                throw new ApiException(500, e.Message);
            }
        }
    
        /// <summary>
        /// Get the API key with prefix.
        /// </summary>
        /// <param name="apiKeyIdentifier">API key identifier (authentication scheme).</param>
        /// <returns>API key with prefix.</returns>
        public string GetApiKeyWithPrefix (string apiKeyIdentifier)
        {
            var apiKeyValue = "";
            Configuration.ApiKey.TryGetValue (apiKeyIdentifier, out apiKeyValue);
            var apiKeyPrefix = "";
            if (Configuration.ApiKeyPrefix.TryGetValue (apiKeyIdentifier, out apiKeyPrefix))
                return apiKeyPrefix + " " + apiKeyValue;
            else
                return apiKeyValue;
        }
        /// <summary>
        /// Update parameters based on authentication.
        /// </summary>
        /// <param name="queryParams">Query parameters.</param>
        /// <param name="headerParams">Header parameters.</param>
        /// <param name="authSettings">Authentication settings.</param>
        public void UpdateParamsForAuth(Dictionary<String, String> queryParams, Dictionary<String, String> headerParams, string[] authSettings)
        {
            if (authSettings == null || authSettings.Length == 0)
                return;

            foreach (string auth in authSettings)
            {
                // determine which one to use
                switch(auth)
                {
                    case "appsid":
                        queryParams["appsid"] = GetApiKeyWithPrefix("appsid");
                        
                        break;
                    case "oauth":
                        
                        //TODO support oauth
                        break;
                    case "signature":
                        queryParams["signature"] = GetApiKeyWithPrefix("signature");
                        
                        break;
                    default:
                        //TODO show warning about security definition not found
                        break;
                }
            }
        }
 
        /// <summary>
        /// Encode string in base64 format.
        /// </summary>
        /// <param name="text">String to be encoded.</param>
        /// <returns>Encoded string.</returns>
        public static string Base64Encode(string text)
        {
            var textByte = System.Text.Encoding.UTF8.GetBytes(text);
            return System.Convert.ToBase64String(textByte);
        }
    
        /// <summary>
        /// Dynamically cast the object into target type.
        /// Ref: http://stackoverflow.com/questions/4925718/c-dynamic-runtime-cast
        /// </summary>
        /// <param name="source">Object to be casted</param>
        /// <param name="dest">Target type</param>
        /// <returns>Casted object</returns>
        public static Object ConvertType(Object source, Type dest) {
            return Convert.ChangeType(source, dest);
        }
  
    }
}
