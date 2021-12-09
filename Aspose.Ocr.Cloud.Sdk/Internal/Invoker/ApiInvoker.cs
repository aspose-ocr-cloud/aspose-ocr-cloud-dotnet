// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ApiInvoker.cs">
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

using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using Aspose.Ocr.Cloud.Sdk.Internal.Invoker.Exceptions;
using Aspose.Ocr.Cloud.Sdk.Invoker.Exceptions;
using Aspose.Ocr.Cloud.Sdk.Model;
using Newtonsoft.Json.Linq;

namespace Aspose.Ocr.Cloud.Sdk.Internal.Invoker
{
    /// <summary>
    ///     Api Invoker
    /// </summary>
    public class ApiInvoker
    {
        private readonly Dictionary<string, string> defaultHeaderMap = new Dictionary<string, string>();
        private readonly List<IRequestHandler> requestHandlers;

        /// <summary>
        ///     Public constructor
        /// </summary>
        /// <param name="requestHandlers"></param>
        public ApiInvoker(List<IRequestHandler> requestHandlers)
        {
            this.requestHandlers = requestHandlers;
        }

        /// <summary>
        ///     Invoke Api
        /// </summary>
        public T InvokeApiNew<T>(
            string path,
            string method,
            string body = null,
            Dictionary<string, string> headerParams = null,
            Dictionary<string, object> formParams = null,
            string contentType = "application/json") where T : class, IOCRResponse, new()
        {
            try
            {
                return InvokeInternal<T>(path, method, body, headerParams, formParams, contentType);
            }
            catch (TimeoutException)
            {
                T ocrRespose = new T();
                ocrRespose.Status = "2";
                ocrRespose.StatusMessage = "TimeOutException";
                return ocrRespose;
            }
        }

        /// <summary>
        ///     Invoke Api
        /// </summary>
        public T InvokeApi<T>(
            string path,
            string method,
            string body = null,
            Dictionary<string, string> headerParams = null,
            Dictionary<string, object> formParams = null,
            string contentType = "application/json") where T : class
        {
            return InvokeInternal<T>(path, method, body, headerParams, formParams, contentType);
        }


        private T InvokeInternal<T>(
            string path,
            string method,
            string body,
            Dictionary<string, string> headerParams,
            Dictionary<string, object> formParams,
            string contentType) where T : class
        {
            if (formParams == null)
                formParams = new Dictionary<string, object>();

            if (headerParams == null)
                headerParams = new Dictionary<string, string>();

            requestHandlers.ForEach(p => path = p.ProcessUrl(path));

            WebRequest request;
            try
            {
                request = PrepareRequest(path, method, formParams, headerParams, body, contentType);
                return ReadResponse<T>(request);
            }
            catch (NeedRepeatRequestException)
            {
                request = PrepareRequest(path, method, formParams, headerParams, body, contentType);
                return ReadResponse<T>(request);
            }
        }

        /// <summary>
        ///     Convert Stream to FileInfo
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="paramName"></param>
        public FileInfo ToFileInfo(Stream stream, string paramName)
        {
            string contentType = paramName.Equals("File", StringComparison.InvariantCultureIgnoreCase)
                ? "application/octet-stream"
                : (paramName.Equals("XML", StringComparison.InvariantCultureIgnoreCase) ? "application/xml" : "application/json");

            return new FileInfo
            {
                Name = paramName,
                MimeType = contentType,
                FileContent = StreamHelper.ReadAsBytes(stream)
            };
        }

        #region private helpers

        private static byte[] GetMultipartFormData(Dictionary<string, object> postParameters, string boundary)
        {
            Stream formDataStream = new MemoryStream();
            var needsClrf = false;

            if (postParameters.Count > 1)
            {
                foreach (var param in postParameters)
                {
                    // Thanks to feedback from commenters, add a CRLF to allow multiple parameters to be added.
                    // Skip it on the first parameter, add it to subsequent parameters.
                    if (needsClrf)
                        formDataStream.Write(Encoding.UTF8.GetBytes("\r\n"), 0, Encoding.UTF8.GetByteCount("\r\n"));

                    needsClrf = true;

                    if (param.Value is FileInfo)
                    {
                        var fileInfo = (FileInfo)param.Value;
                        var postData =
                            string.Format(
                                "--{0}\r\nContent-Disposition: form-data; name=\"{1}\"; filename=\"{1}\"\r\nContent-Type: {2}\r\n\r\n",
                                boundary,
                                param.Key,
                                fileInfo.MimeType);
                        formDataStream.Write(Encoding.UTF8.GetBytes(postData), 0, Encoding.UTF8.GetByteCount(postData));

                        // Write the file data directly to the Stream, rather than serializing it to a string.
                        formDataStream.Write(fileInfo.FileContent, 0, fileInfo.FileContent.Length);
                    }
                    else
                    {
                        var stringData = JsonSerializationHelper.Serialize(param.Value);
                        var postData =
                            string.Format(
                                "--{0}\r\nContent-Disposition: form-data; name=\"{1}\"\r\n\r\n{2}",
                                boundary,
                                param.Key,
                                stringData);
                        formDataStream.Write(Encoding.UTF8.GetBytes(postData), 0, Encoding.UTF8.GetByteCount(postData));
                    }
                }

                // Add the end of the request.  Start with a newline
                var footer = "\r\n--" + boundary + "--\r\n";
                formDataStream.Write(Encoding.UTF8.GetBytes(footer), 0, Encoding.UTF8.GetByteCount(footer));
            }
            else
            {
                foreach (var param in postParameters)
                    if (param.Value is FileInfo)
                    {
                        var fileInfo = (FileInfo)param.Value;

                        // Write the file data directly to the Stream, rather than serializing it to a string.
                        formDataStream.Write(fileInfo.FileContent, 0, fileInfo.FileContent.Length);
                    }
                    else if (param.Value is byte[])
                    {
                        // Write the file data directly to the Stream, rather than serializing it to a string.
                        formDataStream.Write(param.Value as byte[], 0, (param.Value as byte[]).Length);
                    }
                    else
                    {
                        string postData;
                        if (!(param.Value is string))
                            postData = JsonSerializationHelper.Serialize(param.Value);
                        else
                            postData = (string)param.Value;

                        formDataStream.Write(Encoding.UTF8.GetBytes(postData), 0, Encoding.UTF8.GetByteCount(postData));
                    }
            }

            // Dump the Stream into a byte[]
            formDataStream.Position = 0;
            var formData = new byte[formDataStream.Length];
            formDataStream.Read(formData, 0, formData.Length);
            formDataStream.Close();

            return formData;
        }

        private void AddDefaultHeader(string key, string value)
        {
            if (!defaultHeaderMap.ContainsKey(key))
                defaultHeaderMap.Add(key, value);
        }

        private HttpWebRequest PrepareRequest(string path, string method, Dictionary<string, object> formParams,
            Dictionary<string, string> headerParams, string body, string contentType)
        {
            var client = (HttpWebRequest)WebRequest.Create(path);

            client.Method = method;

            byte[] formData = null;
            if (formParams.Count > 0)
            {
                if (formParams.Count > 1)
                {
                    string formDataBoundary = Guid.NewGuid().ToString("D");
                    client.ContentType = "multipart/form-data; boundary=" + formDataBoundary;
                    formData = GetMultipartFormData(formParams, formDataBoundary);
                }
                else
                {
                    client.ContentType = "multipart/form-data";
                    formData = GetMultipartFormData(formParams, string.Empty);
                }

                client.ContentLength = formData.Length;
            }
            else
            {
                client.ContentType = contentType;
            }

            foreach (var headerParamsItem in headerParams)
            {
                if (headerParamsItem.Key == "Accept")
                    client.Accept = headerParamsItem.Value;
                else
                    client.Headers.Add(headerParamsItem.Key, headerParamsItem.Value);
            }

            foreach (var defaultHeaderMapItem in defaultHeaderMap)
                if (!headerParams.ContainsKey(defaultHeaderMapItem.Key))
                    client.Headers.Add(defaultHeaderMapItem.Key, defaultHeaderMapItem.Value);

            MemoryStream streamToSend = null;
            try
            {
                switch (method)
                {
                    case "GET":
                        break;
                    case "POST":
                    case "PUT":
                    case "DELETE":
                        streamToSend = new MemoryStream();

                        if (formData != null)
                            streamToSend.Write(formData, 0, formData.Length);

                        if (body != null)
                        {
                            var requestWriter = new StreamWriter(streamToSend);
                            requestWriter.Write(body);
                            requestWriter.Flush();
                        }

                        break;
                    default:
                        throw new HttpWebException("Unknown method type " + method, CommonStatusCode.InternalError);
                }

                requestHandlers.ForEach(p => p.BeforeSend(client, streamToSend));

                if (streamToSend != null)
                    using (var requestStream = client.GetRequestStream())
                    {
                        StreamHelper.CopyTo(streamToSend, requestStream);
                    }
            }
            finally
            {
                if (streamToSend != null)
                    streamToSend.Dispose();
            }

            return client;
        }


        private T ReadResponse<T>(WebRequest client) where T : class
        {
            var webResponse = (HttpWebResponse)GetResponse(client);
            var resultStream = new MemoryStream();

            var responseStream = webResponse.GetResponseStream();
            if (responseStream != null)
                StreamHelper.CopyTo(responseStream, resultStream);

            try
            {
                requestHandlers.ForEach(p => p.ProcessResponse(webResponse, resultStream));

                resultStream.Position = 0;

                if (typeof(T) == typeof(HttpWebResponse))
                    return webResponse as T;

                if (typeof(T) == typeof(Stream))
                    return resultStream as T;

                var str = Encoding.UTF8.GetString(resultStream.ToArray());

                if (typeof(T) == typeof(string))
                    return str as T;

                if (typeof(T) == typeof(JObject))
                    return JObject.Parse(str) as T;

                return JsonSerializationHelper.Deserialize(str, typeof(T)) as T;
            }
            catch (Exception)
            {
                resultStream.Dispose();
                throw;
            }
        }

        private WebResponse GetResponse(WebRequest request)
        {
            try
            {
                return request.GetResponse();
            }
            catch (WebException wex)
            {
                if (wex.Response != null)
                    return wex.Response;

                throw new TimeoutException("");
            }
        }

        #endregion

    }
}