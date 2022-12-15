/*
 * Aspose OCR Cloud 5.0 API
 *
 * Aspose OCR Cloud 5.0 API
 *


 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using System.Text.RegularExpressions;
using Aspose.OCR.Cloud.SDK.Client;
using Aspose.OCR.Cloud.SDK.Client.Auth;
using Aspose.OCR.Cloud.SDK.Model;

namespace Aspose.OCR.Cloud.SDK.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDetectRegionsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// CancelDetectRegions
        /// </summary>
        /// <exception cref="Aspose.OCR.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        void CancelDetectRegions(string id, int operationIndex = 0);

        /// <summary>
        /// CancelDetectRegions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.OCR.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> CancelDetectRegionsWithHttpInfo(string id, int operationIndex = 0);
        /// <summary>
        /// GetDetectRegions
        /// </summary>
        /// <exception cref="Aspose.OCR.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Task id to select the result</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>OCRResponse</returns>
        OCRResponse GetDetectRegions(string id, int operationIndex = 0);

        /// <summary>
        /// GetDetectRegions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.OCR.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Task id to select the result</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of OCRResponse</returns>
        ApiResponse<OCRResponse> GetDetectRegionsWithHttpInfo(string id, int operationIndex = 0);
        /// <summary>
        /// PostDetectRegions
        /// </summary>
        /// <exception cref="Aspose.OCR.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oCRDetectRegionsBody"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>string</returns>
        string PostDetectRegions(OCRDetectRegionsBody oCRDetectRegionsBody, int operationIndex = 0);

        /// <summary>
        /// PostDetectRegions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.OCR.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oCRDetectRegionsBody"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> PostDetectRegionsWithHttpInfo(OCRDetectRegionsBody oCRDetectRegionsBody, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDetectRegionsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// CancelDetectRegions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.OCR.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task CancelDetectRegionsAsync(string id, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// CancelDetectRegions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.OCR.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> CancelDetectRegionsWithHttpInfoAsync(string id, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// GetDetectRegions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.OCR.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Task id to select the result</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of OCRResponse</returns>
        System.Threading.Tasks.Task<OCRResponse> GetDetectRegionsAsync(string id, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// GetDetectRegions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.OCR.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Task id to select the result</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (OCRResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<OCRResponse>> GetDetectRegionsWithHttpInfoAsync(string id, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// PostDetectRegions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.OCR.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oCRDetectRegionsBody"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> PostDetectRegionsAsync(OCRDetectRegionsBody oCRDetectRegionsBody, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// PostDetectRegions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.OCR.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oCRDetectRegionsBody"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> PostDetectRegionsWithHttpInfoAsync(OCRDetectRegionsBody oCRDetectRegionsBody, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDetectRegionsApi : IDetectRegionsApiSync, IDetectRegionsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class DetectRegionsApi : IDetectRegionsApi
    {
        private Aspose.OCR.Cloud.SDK.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary> 
        /// Initializes a new instance of the <see cref="RecognizeImageApi"/> class.
        /// </summary>
        /// <param name="client_id">client ID</param>
        /// <param name="client_secret">client secret</param>
        public DetectRegionsApi(string client_id, string client_secret)
        {
            if (String.IsNullOrEmpty(client_id) || String.IsNullOrEmpty(client_secret)) 
                throw new ArgumentNullException("Client_id or client_secret is empty.\n" +
                    "Follow https://dashboard.aspose.cloud/applications to register and get credentials for your application");

            this.Configuration = Aspose.OCR.Cloud.SDK.Client.Configuration.MergeConfigurations(
                Aspose.OCR.Cloud.SDK.Client.GlobalConfiguration.Instance,
                new Aspose.OCR.Cloud.SDK.Client.Configuration {
                    BasePath = "https://api.aspose.cloud/v5.0/ocr",
                    OAuthClientId = client_id,
                    OAuthClientSecret = client_secret,
                    OAuthTokenUrl = @"https://api.aspose.cloud/connect/token",
                    OAuthFlow = OAuthFlow.APPLICATION
                }
            );
            this.Client = new Aspose.OCR.Cloud.SDK.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Aspose.OCR.Cloud.SDK.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Aspose.OCR.Cloud.SDK.Client.Configuration.DefaultExceptionFactory;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="DetectRegionsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DetectRegionsApi(Aspose.OCR.Cloud.SDK.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");            
            if (configuration.BasePath == null) configuration.BasePath = "https://api.aspose.cloud/v5.0/ocr";
            
            if (String.IsNullOrEmpty(configuration.OAuthClientId)) throw new ArgumentNullException("client id");
            if (String.IsNullOrEmpty(configuration.OAuthClientSecret)) throw new ArgumentNullException("client secret");
            if (configuration.OAuthFlow == null) configuration.OAuthFlow = OAuthFlow.APPLICATION;
            if (configuration.OAuthTokenUrl == null) configuration.OAuthTokenUrl = @"https://api.aspose.cloud/connect/token";

            this.Configuration = Aspose.OCR.Cloud.SDK.Client.Configuration.MergeConfigurations(
                Aspose.OCR.Cloud.SDK.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Aspose.OCR.Cloud.SDK.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Aspose.OCR.Cloud.SDK.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Aspose.OCR.Cloud.SDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectRegionsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public DetectRegionsApi(Aspose.OCR.Cloud.SDK.Client.ISynchronousClient client, Aspose.OCR.Cloud.SDK.Client.IAsynchronousClient asyncClient, Aspose.OCR.Cloud.SDK.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Aspose.OCR.Cloud.SDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Aspose.OCR.Cloud.SDK.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Aspose.OCR.Cloud.SDK.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Aspose.OCR.Cloud.SDK.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Aspose.OCR.Cloud.SDK.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// CancelDetectRegions 
        /// </summary>
        /// <exception cref="Aspose.OCR.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        public void CancelDetectRegions(string id, int operationIndex = 0)
        {
            CancelDetectRegionsWithHttpInfo(id);
        }

        /// <summary>
        /// CancelDetectRegions 
        /// </summary>
        /// <exception cref="Aspose.OCR.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public Aspose.OCR.Cloud.SDK.Client.ApiResponse<Object> CancelDetectRegionsWithHttpInfo(string id, int operationIndex = 0)
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new Aspose.OCR.Cloud.SDK.Client.ApiException(400, "Missing required parameter 'id' when calling DetectRegionsApi->CancelDetectRegions");
            }

            Aspose.OCR.Cloud.SDK.Client.RequestOptions localVarRequestOptions = new Aspose.OCR.Cloud.SDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };

            var localVarContentType = Aspose.OCR.Cloud.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Aspose.OCR.Cloud.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add(Aspose.OCR.Cloud.SDK.Client.ClientUtils.ParameterToMultiMap("", "id", id));

            localVarRequestOptions.Operation = "DetectRegionsApi.CancelDetectRegions";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (JWT) required
            // oauth required
            if (!localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
                }
                else if (!string.IsNullOrEmpty(this.Configuration.OAuthTokenUrl) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientId) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientSecret) &&
                         this.Configuration.OAuthFlow != null)
                {
                    localVarRequestOptions.OAuth = true;
                }
            }

            // make the HTTP request
            var localVarResponse = this.Client.Delete<Object>(GetAdjustedPath("./v5/DetectRegions"), localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CancelDetectRegions", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// CancelDetectRegions 
        /// </summary>
        /// <exception cref="Aspose.OCR.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task CancelDetectRegionsAsync(string id, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await CancelDetectRegionsWithHttpInfoAsync(id, operationIndex, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// CancelDetectRegions 
        /// </summary>
        /// <exception cref="Aspose.OCR.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<Aspose.OCR.Cloud.SDK.Client.ApiResponse<Object>> CancelDetectRegionsWithHttpInfoAsync(string id, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new Aspose.OCR.Cloud.SDK.Client.ApiException(400, "Missing required parameter 'id' when calling DetectRegionsApi->CancelDetectRegions");
            }


            Aspose.OCR.Cloud.SDK.Client.RequestOptions localVarRequestOptions = new Aspose.OCR.Cloud.SDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };

            var localVarContentType = Aspose.OCR.Cloud.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Aspose.OCR.Cloud.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add(Aspose.OCR.Cloud.SDK.Client.ClientUtils.ParameterToMultiMap("", "id", id));

            localVarRequestOptions.Operation = "DetectRegionsApi.CancelDetectRegions";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (JWT) required
            // oauth required
            if (!localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
                }
                else if (!string.IsNullOrEmpty(this.Configuration.OAuthTokenUrl) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientId) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientSecret) &&
                         this.Configuration.OAuthFlow != null)
                {
                    localVarRequestOptions.OAuth = true;
                }
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.DeleteAsync<Object>(GetAdjustedPath("./v5/DetectRegions"), localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CancelDetectRegions", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        
        /// <summary>
        /// GetDetectRegions 
        /// </summary>
        /// <exception cref="Aspose.OCR.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Task id to select the result</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>OCRResponse</returns>
        public OCRResponse GetDetectRegions(string id, int operationIndex = 0)
        {
            Aspose.OCR.Cloud.SDK.Client.ApiResponse<OCRResponse> localVarResponse = GetDetectRegionsWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GetDetectRegions 
        /// </summary>
        /// <exception cref="Aspose.OCR.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Task id to select the result</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of OCRResponse</returns>
        public Aspose.OCR.Cloud.SDK.Client.ApiResponse<OCRResponse> GetDetectRegionsWithHttpInfo(string id, int operationIndex = 0)
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new Aspose.OCR.Cloud.SDK.Client.ApiException(400, "Missing required parameter 'id' when calling DetectRegionsApi->GetDetectRegions");
            }

            Aspose.OCR.Cloud.SDK.Client.RequestOptions localVarRequestOptions = new Aspose.OCR.Cloud.SDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Aspose.OCR.Cloud.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Aspose.OCR.Cloud.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add(Aspose.OCR.Cloud.SDK.Client.ClientUtils.ParameterToMultiMap("", "id", id));

            localVarRequestOptions.Operation = "DetectRegionsApi.GetDetectRegions";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (JWT) required
            // oauth required
            if (!localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
                }
                else if (!string.IsNullOrEmpty(this.Configuration.OAuthTokenUrl) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientId) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientSecret) &&
                         this.Configuration.OAuthFlow != null)
                {
                    localVarRequestOptions.OAuth = true;
                }
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<OCRResponse>(GetAdjustedPath("./v5/DetectRegions"), localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetDetectRegions", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// GetDetectRegions 
        /// </summary>
        /// <exception cref="Aspose.OCR.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Task id to select the result</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of OCRResponse</returns>
        public async System.Threading.Tasks.Task<OCRResponse> GetDetectRegionsAsync(string id, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Aspose.OCR.Cloud.SDK.Client.ApiResponse<OCRResponse> localVarResponse = await GetDetectRegionsWithHttpInfoAsync(id, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GetDetectRegions 
        /// </summary>
        /// <exception cref="Aspose.OCR.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Task id to select the result</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (OCRResponse)</returns>
        public async System.Threading.Tasks.Task<Aspose.OCR.Cloud.SDK.Client.ApiResponse<OCRResponse>> GetDetectRegionsWithHttpInfoAsync(string id, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new Aspose.OCR.Cloud.SDK.Client.ApiException(400, "Missing required parameter 'id' when calling DetectRegionsApi->GetDetectRegions");
            }


            Aspose.OCR.Cloud.SDK.Client.RequestOptions localVarRequestOptions = new Aspose.OCR.Cloud.SDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Aspose.OCR.Cloud.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Aspose.OCR.Cloud.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add(Aspose.OCR.Cloud.SDK.Client.ClientUtils.ParameterToMultiMap("", "id", id));

            localVarRequestOptions.Operation = "DetectRegionsApi.GetDetectRegions";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (JWT) required
            // oauth required
            if (!localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
                }
                else if (!string.IsNullOrEmpty(this.Configuration.OAuthTokenUrl) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientId) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientSecret) &&
                         this.Configuration.OAuthFlow != null)
                {
                    localVarRequestOptions.OAuth = true;
                }
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<OCRResponse>(GetAdjustedPath("./v5/DetectRegions"), localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetDetectRegions", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        
        /// <summary>
        /// PostDetectRegions 
        /// </summary>
        /// <exception cref="Aspose.OCR.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oCRDetectRegionsBody"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>string</returns>
        public string PostDetectRegions(OCRDetectRegionsBody oCRDetectRegionsBody, int operationIndex = 0)
        {
            Aspose.OCR.Cloud.SDK.Client.ApiResponse<string> localVarResponse = PostDetectRegionsWithHttpInfo(oCRDetectRegionsBody);
            return localVarResponse.Data;
        }

        /// <summary>
        /// PostDetectRegions 
        /// </summary>
        /// <exception cref="Aspose.OCR.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oCRDetectRegionsBody"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of string</returns>
        public Aspose.OCR.Cloud.SDK.Client.ApiResponse<string> PostDetectRegionsWithHttpInfo(OCRDetectRegionsBody oCRDetectRegionsBody, int operationIndex = 0)
        {
            // verify the required parameter 'oCRDetectRegionsBody' is set
            if (oCRDetectRegionsBody == null)
            {
                throw new Aspose.OCR.Cloud.SDK.Client.ApiException(400, "Missing required parameter 'oCRDetectRegionsBody' when calling DetectRegionsApi->PostDetectRegions");
            }

            Aspose.OCR.Cloud.SDK.Client.RequestOptions localVarRequestOptions = new Aspose.OCR.Cloud.SDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/plain"
            };

            var localVarContentType = Aspose.OCR.Cloud.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Aspose.OCR.Cloud.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = oCRDetectRegionsBody;

            localVarRequestOptions.Operation = "DetectRegionsApi.PostDetectRegions";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (JWT) required
            // oauth required
            if (!localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
                }
                else if (!string.IsNullOrEmpty(this.Configuration.OAuthTokenUrl) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientId) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientSecret) &&
                         this.Configuration.OAuthFlow != null)
                {
                    localVarRequestOptions.OAuth = true;
                }
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<string>(GetAdjustedPath("./v5/DetectRegions"), localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PostDetectRegions", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// PostDetectRegions 
        /// </summary>
        /// <exception cref="Aspose.OCR.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oCRDetectRegionsBody"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> PostDetectRegionsAsync(OCRDetectRegionsBody oCRDetectRegionsBody, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Aspose.OCR.Cloud.SDK.Client.ApiResponse<string> localVarResponse = await PostDetectRegionsWithHttpInfoAsync(oCRDetectRegionsBody, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// PostDetectRegions 
        /// </summary>
        /// <exception cref="Aspose.OCR.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oCRDetectRegionsBody"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<Aspose.OCR.Cloud.SDK.Client.ApiResponse<string>> PostDetectRegionsWithHttpInfoAsync(OCRDetectRegionsBody oCRDetectRegionsBody, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'oCRDetectRegionsBody' is set
            if (oCRDetectRegionsBody == null)
            {
                throw new Aspose.OCR.Cloud.SDK.Client.ApiException(400, "Missing required parameter 'oCRDetectRegionsBody' when calling DetectRegionsApi->PostDetectRegions");
            }


            Aspose.OCR.Cloud.SDK.Client.RequestOptions localVarRequestOptions = new Aspose.OCR.Cloud.SDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/plain"
            };

            var localVarContentType = Aspose.OCR.Cloud.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Aspose.OCR.Cloud.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = oCRDetectRegionsBody;

            localVarRequestOptions.Operation = "DetectRegionsApi.PostDetectRegions";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (JWT) required
            // oauth required
            if (!localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
                }
                else if (!string.IsNullOrEmpty(this.Configuration.OAuthTokenUrl) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientId) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientSecret) &&
                         this.Configuration.OAuthFlow != null)
                {
                    localVarRequestOptions.OAuth = true;
                }
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<string>(GetAdjustedPath("./v5/DetectRegions"), localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PostDetectRegions", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        
    
        /// <summary>
        /// Returns adjusted path in case if base path contains version identifier 
        /// </summary>
        /// <param name="srcPath"></param>
        /// <returns></returns>
        string GetAdjustedPath(string srcPath)
        {
            if (Regex.IsMatch(this.Configuration.BasePath,
                @"^*(\/v\d{1,5}.?\d{0,3}\/)"))
            {
                return Regex.Replace(srcPath, @"(\/v\d{1,5}.?\d{0,3}\/)", @"/");
            }
            else
            {
                return srcPath;
            }
        }
    }

    

}
