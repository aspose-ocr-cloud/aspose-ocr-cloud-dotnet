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
    public interface ITextToSpeechApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// GetTextToSpeechResult
        /// </summary>
        /// <exception cref="Aspose.OCR.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Task id to select the result</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>TTSResponse</returns>
        TTSResponse GetTextToSpeechResult(string id, int operationIndex = 0);

        /// <summary>
        /// GetTextToSpeechResult
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.OCR.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Task id to select the result</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of TTSResponse</returns>
        ApiResponse<TTSResponse> GetTextToSpeechResultWithHttpInfo(string id, int operationIndex = 0);
        /// <summary>
        /// GetTextToSpeechResultFile
        /// </summary>
        /// <exception cref="Aspose.OCR.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Task id to select the result</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Object</returns>
        Object GetTextToSpeechResultFile(string id, int operationIndex = 0);

        /// <summary>
        /// GetTextToSpeechResultFile
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.OCR.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Task id to select the result</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> GetTextToSpeechResultFileWithHttpInfo(string id, int operationIndex = 0);
        /// <summary>
        /// PostTextToSpeech
        /// </summary>
        /// <exception cref="Aspose.OCR.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tTSBody"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>string</returns>
        string PostTextToSpeech(TTSBody tTSBody, int operationIndex = 0);

        /// <summary>
        /// PostTextToSpeech
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.OCR.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tTSBody"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> PostTextToSpeechWithHttpInfo(TTSBody tTSBody, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITextToSpeechApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// GetTextToSpeechResult
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.OCR.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Task id to select the result</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of TTSResponse</returns>
        System.Threading.Tasks.Task<TTSResponse> GetTextToSpeechResultAsync(string id, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// GetTextToSpeechResult
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.OCR.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Task id to select the result</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (TTSResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TTSResponse>> GetTextToSpeechResultWithHttpInfoAsync(string id, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// GetTextToSpeechResultFile
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.OCR.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Task id to select the result</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> GetTextToSpeechResultFileAsync(string id, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// GetTextToSpeechResultFile
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.OCR.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Task id to select the result</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetTextToSpeechResultFileWithHttpInfoAsync(string id, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// PostTextToSpeech
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.OCR.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tTSBody"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> PostTextToSpeechAsync(TTSBody tTSBody, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// PostTextToSpeech
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.OCR.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tTSBody"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> PostTextToSpeechWithHttpInfoAsync(TTSBody tTSBody, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITextToSpeechApi : ITextToSpeechApiSync, ITextToSpeechApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class TextToSpeechApi : ITextToSpeechApi
    {
        private Aspose.OCR.Cloud.SDK.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary> 
        /// Initializes a new instance of the <see cref="RecognizeImageApi"/> class.
        /// </summary>
        /// <param name="client_id">client ID</param>
        /// <param name="client_secret">client secret</param>
        public TextToSpeechApi(string client_id, string client_secret)
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
        /// Initializes a new instance of the <see cref="TextToSpeechApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TextToSpeechApi(Aspose.OCR.Cloud.SDK.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="TextToSpeechApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public TextToSpeechApi(Aspose.OCR.Cloud.SDK.Client.ISynchronousClient client, Aspose.OCR.Cloud.SDK.Client.IAsynchronousClient asyncClient, Aspose.OCR.Cloud.SDK.Client.IReadableConfiguration configuration)
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
        /// GetTextToSpeechResult 
        /// </summary>
        /// <exception cref="Aspose.OCR.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Task id to select the result</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>TTSResponse</returns>
        public TTSResponse GetTextToSpeechResult(string id, int operationIndex = 0)
        {
            Aspose.OCR.Cloud.SDK.Client.ApiResponse<TTSResponse> localVarResponse = GetTextToSpeechResultWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GetTextToSpeechResult 
        /// </summary>
        /// <exception cref="Aspose.OCR.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Task id to select the result</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of TTSResponse</returns>
        public Aspose.OCR.Cloud.SDK.Client.ApiResponse<TTSResponse> GetTextToSpeechResultWithHttpInfo(string id, int operationIndex = 0)
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new Aspose.OCR.Cloud.SDK.Client.ApiException(400, "Missing required parameter 'id' when calling TextToSpeechApi->GetTextToSpeechResult");
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

            localVarRequestOptions.Operation = "TextToSpeechApi.GetTextToSpeechResult";
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
            var localVarResponse = this.Client.Get<TTSResponse>(GetAdjustedPath("./v5/TextToSpeech/GetTextToSpeechResult"), localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetTextToSpeechResult", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// GetTextToSpeechResult 
        /// </summary>
        /// <exception cref="Aspose.OCR.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Task id to select the result</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of TTSResponse</returns>
        public async System.Threading.Tasks.Task<TTSResponse> GetTextToSpeechResultAsync(string id, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Aspose.OCR.Cloud.SDK.Client.ApiResponse<TTSResponse> localVarResponse = await GetTextToSpeechResultWithHttpInfoAsync(id, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GetTextToSpeechResult 
        /// </summary>
        /// <exception cref="Aspose.OCR.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Task id to select the result</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (TTSResponse)</returns>
        public async System.Threading.Tasks.Task<Aspose.OCR.Cloud.SDK.Client.ApiResponse<TTSResponse>> GetTextToSpeechResultWithHttpInfoAsync(string id, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new Aspose.OCR.Cloud.SDK.Client.ApiException(400, "Missing required parameter 'id' when calling TextToSpeechApi->GetTextToSpeechResult");
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

            localVarRequestOptions.Operation = "TextToSpeechApi.GetTextToSpeechResult";
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
            var localVarResponse = await this.AsynchronousClient.GetAsync<TTSResponse>(GetAdjustedPath("./v5/TextToSpeech/GetTextToSpeechResult"), localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetTextToSpeechResult", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        
        /// <summary>
        /// GetTextToSpeechResultFile 
        /// </summary>
        /// <exception cref="Aspose.OCR.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Task id to select the result</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Object</returns>
        public Object GetTextToSpeechResultFile(string id, int operationIndex = 0)
        {
            Aspose.OCR.Cloud.SDK.Client.ApiResponse<Object> localVarResponse = GetTextToSpeechResultFileWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GetTextToSpeechResultFile 
        /// </summary>
        /// <exception cref="Aspose.OCR.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Task id to select the result</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object</returns>
        public Aspose.OCR.Cloud.SDK.Client.ApiResponse<Object> GetTextToSpeechResultFileWithHttpInfo(string id, int operationIndex = 0)
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new Aspose.OCR.Cloud.SDK.Client.ApiException(400, "Missing required parameter 'id' when calling TextToSpeechApi->GetTextToSpeechResultFile");
            }

            Aspose.OCR.Cloud.SDK.Client.RequestOptions localVarRequestOptions = new Aspose.OCR.Cloud.SDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/octet-stream"
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

            localVarRequestOptions.Operation = "TextToSpeechApi.GetTextToSpeechResultFile";
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
            var localVarResponse = this.Client.Get<Object>(GetAdjustedPath("./v5/TextToSpeech/GetTextToSpeechResultFile"), localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetTextToSpeechResultFile", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// GetTextToSpeechResultFile 
        /// </summary>
        /// <exception cref="Aspose.OCR.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Task id to select the result</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> GetTextToSpeechResultFileAsync(string id, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Aspose.OCR.Cloud.SDK.Client.ApiResponse<Object> localVarResponse = await GetTextToSpeechResultFileWithHttpInfoAsync(id, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GetTextToSpeechResultFile 
        /// </summary>
        /// <exception cref="Aspose.OCR.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Task id to select the result</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<Aspose.OCR.Cloud.SDK.Client.ApiResponse<Object>> GetTextToSpeechResultFileWithHttpInfoAsync(string id, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new Aspose.OCR.Cloud.SDK.Client.ApiException(400, "Missing required parameter 'id' when calling TextToSpeechApi->GetTextToSpeechResultFile");
            }


            Aspose.OCR.Cloud.SDK.Client.RequestOptions localVarRequestOptions = new Aspose.OCR.Cloud.SDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/octet-stream"
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

            localVarRequestOptions.Operation = "TextToSpeechApi.GetTextToSpeechResultFile";
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
            var localVarResponse = await this.AsynchronousClient.GetAsync<Object>(GetAdjustedPath("./v5/TextToSpeech/GetTextToSpeechResultFile"), localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetTextToSpeechResultFile", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        
        /// <summary>
        /// PostTextToSpeech 
        /// </summary>
        /// <exception cref="Aspose.OCR.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tTSBody"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>string</returns>
        public string PostTextToSpeech(TTSBody tTSBody, int operationIndex = 0)
        {
            Aspose.OCR.Cloud.SDK.Client.ApiResponse<string> localVarResponse = PostTextToSpeechWithHttpInfo(tTSBody);
            return localVarResponse.Data;
        }

        /// <summary>
        /// PostTextToSpeech 
        /// </summary>
        /// <exception cref="Aspose.OCR.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tTSBody"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of string</returns>
        public Aspose.OCR.Cloud.SDK.Client.ApiResponse<string> PostTextToSpeechWithHttpInfo(TTSBody tTSBody, int operationIndex = 0)
        {
            // verify the required parameter 'tTSBody' is set
            if (tTSBody == null)
            {
                throw new Aspose.OCR.Cloud.SDK.Client.ApiException(400, "Missing required parameter 'tTSBody' when calling TextToSpeechApi->PostTextToSpeech");
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

            localVarRequestOptions.Data = tTSBody;

            localVarRequestOptions.Operation = "TextToSpeechApi.PostTextToSpeech";
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
            var localVarResponse = this.Client.Post<string>(GetAdjustedPath("./v5/TextToSpeech/PostTextToSpeech"), localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PostTextToSpeech", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// PostTextToSpeech 
        /// </summary>
        /// <exception cref="Aspose.OCR.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tTSBody"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> PostTextToSpeechAsync(TTSBody tTSBody, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Aspose.OCR.Cloud.SDK.Client.ApiResponse<string> localVarResponse = await PostTextToSpeechWithHttpInfoAsync(tTSBody, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// PostTextToSpeech 
        /// </summary>
        /// <exception cref="Aspose.OCR.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tTSBody"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<Aspose.OCR.Cloud.SDK.Client.ApiResponse<string>> PostTextToSpeechWithHttpInfoAsync(TTSBody tTSBody, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'tTSBody' is set
            if (tTSBody == null)
            {
                throw new Aspose.OCR.Cloud.SDK.Client.ApiException(400, "Missing required parameter 'tTSBody' when calling TextToSpeechApi->PostTextToSpeech");
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

            localVarRequestOptions.Data = tTSBody;

            localVarRequestOptions.Operation = "TextToSpeechApi.PostTextToSpeech";
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
            var localVarResponse = await this.AsynchronousClient.PostAsync<string>(GetAdjustedPath("./v5/TextToSpeech/PostTextToSpeech"), localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PostTextToSpeech", localVarResponse);
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
