// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="JwtTokenRequestHandler.cs">
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

using System.Collections.Generic;
using System.IO;
using System.Net;
using Aspose.Ocr.Cloud.Sdk.Invoker.Exceptions;
using Newtonsoft.Json;

namespace Aspose.Ocr.Cloud.Sdk.Internal.Invoker.RequestHandlers
{
    /// <summary>
    ///     Access Token Handler
    /// </summary>
    public class JwtTokenRequestHandler : IRequestHandler
    {
        private readonly string baseApiUrl;
        private readonly string clientId;
        private readonly string clientSecret;
        private readonly ApiInvoker apiInvoker;
        private string accessToken;

        public JwtTokenRequestHandler(string baseApiUrl, string clientId, string clientSecret)
        {
            this.baseApiUrl = baseApiUrl;
            this.clientId = clientId;
            this.clientSecret = clientSecret;

            var requestHandlers = new List<IRequestHandler>();
            requestHandlers.Add(new ApiExceptionRequestHandler());
            apiInvoker = new ApiInvoker(requestHandlers);
        }

        public JwtTokenRequestHandler(Configuration configuration) : this(configuration.ApiBaseUrl, configuration.AppSid, configuration.AppKey)
        { }

        public string ProcessUrl(string url)
        {
            if (string.IsNullOrEmpty(accessToken))
                RequestToken();

            return url;
        }

        public void BeforeSend(WebRequest request, Stream streamToSend)
        {
            request.Headers.Add("Authorization", "Bearer " + accessToken);
        }

        public void ProcessResponse(HttpWebResponse response, Stream resultStream)
        {
            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                RequestToken();

                throw new NeedRepeatRequestException();
            }
        }

        private void RequestToken()
        {
            var requestUrl = baseApiUrl + "/connect/token";

            var postData = "grant_type=client_credentials";
            postData += "&client_id=" + clientId;
            postData += "&client_secret=" + clientSecret;

            var result = apiInvoker.InvokeApi<GetAccessTokenResult>(
                requestUrl,
                "POST",
                postData,
                contentType: "application/x-www-form-urlencoded");

            accessToken = result.AccessToken;
        }

        private class GetAccessTokenResult
        {
            [JsonProperty(PropertyName = "access_token")]
            public string AccessToken { get; set; }
        }
    }
}