//// --------------------------------------------------------------------------------------------------------------------
//// <copyright company="Aspose Pty Ltd" file="Auth.cs">
////  Copyright (c) 2003-2019 Aspose Pty Ltd
//// </copyright>
//// <summary>
////  Permission is hereby granted, free of charge, to any person obtaining a copy
////  of this software and associated documentation files (the "Software"), to deal
////  in the Software without restriction, including without limitation the rights
////  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
////  copies of the Software, and to permit persons to whom the Software is
////  furnished to do so, subject to the following conditions:
//// 
////  The above copyright notice and this permission notice shall be included in all
////  copies or substantial portions of the Software.
//// 
////  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
////  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
////  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
////  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
////  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
////  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
////  SOFTWARE.
//// </summary>
//// --------------------------------------------------------------------------------------------------------------------

//using System;
//using System.Collections.Generic;
//using System.Threading.Tasks;
//using Newtonsoft.Json;
//using Newtonsoft.Json.Linq;
//using RestSharp.Portable;
//using RestSharp.Portable.HttpClient;

//namespace Aspose.Ocr.Cloud.Sdk
//{
//    public class Auth : IAuthorization
//    {
//        private readonly Configuration _configuration;
//        private readonly RestClient _restClient;
//        private string _accessToken;                

//        public Auth(Configuration configuration, List<Parameter> defaultParameters)
//        {
//            _configuration = configuration;

//            _restClient = new RestClient(configuration.ApiBaseUrl)
//            {
//                Timeout = TimeSpan.FromMilliseconds(_configuration.Timeout), IgnoreResponseStatusCode = true
//            };

//            foreach (var defaultParameter in defaultParameters)
//                _restClient.DefaultParameters.Add(defaultParameter);
//        }

//        public void ApplyToParams(List<KeyValuePair<string, string>> queryParams, Dictionary<string, string> headerParams)
//        {
//            var accessToken = GetAccessTokenAsync().Result;

//            headerParams.Add("Authorization", "Bearer " + accessToken);
//        }

//        private async Task<string> GetAccessTokenAsync()
//        {
//            return _accessToken ?? (_accessToken = await RequestAccessTokenAsync());
//        }

//        private async Task<string> RequestAccessTokenAsync()
//        {
//            const string path = "./connect/token";
//            var postBody = $"grant_type=client_credentials&client_id={_configuration.AppSid}&client_secret={_configuration.AppKey}";

//            var request = new RestRequest(path, Method.POST) {Serializer = null};
//            request.AddParameter(new Parameter
//            {
//                Value = postBody,
//                Type = ParameterType.RequestBody,
//                ContentType = "application/x-www-form-urlencoded"
//            });

//            var response = await _restClient.Execute(request);

//            var statusCode = (int)response.StatusCode;
//            if (statusCode != 200)
//                throw new ApiException(statusCode, response.Content);

//            var obj = JsonConvert.DeserializeObject<JObject>(response.Content);

//            var accessToken = obj["access_token"].Value<string>();

//            return accessToken;
//        }
//    }
//}