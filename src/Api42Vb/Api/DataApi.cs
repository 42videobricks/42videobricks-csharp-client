/*
 * 42videobricks
 *
 * 42videobricks is a Video Platform As A Service (VPaaS)
 *
 * The version of the OpenAPI document: 1.2
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Api42Vb.Client;
using Api42Vb.Model;

namespace Api42Vb.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDataApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// List Video Usage KPIs
        /// </summary>
        /// <remarks>
        /// Return the usage of the platform ressources.  By default, it returns monthly usage but unit (dayly|week|month) can be defined. For current period, usage is calculated until current time. Start and end dates can be also optionaly defined to filter results.
        /// </remarks>
        /// <exception cref="Api42Vb.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">Number of elements to return (default&#x3D;10) (optional)</param>
        /// <param name="offset">offset for pagination (optional)</param>
        /// <param name="interval">Period unit (day|week|month) (optional)</param>
        /// <param name="startDate">Start date for the period (optional)</param>
        /// <param name="endDate">End date for the period (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>DataVideoUsageList</returns>
        DataVideoUsageList GetDataVideoUsage(int? limit = default(int?), int? offset = default(int?), string? interval = default(string?), string? startDate = default(string?), string? endDate = default(string?), int operationIndex = 0);

        /// <summary>
        /// List Video Usage KPIs
        /// </summary>
        /// <remarks>
        /// Return the usage of the platform ressources.  By default, it returns monthly usage but unit (dayly|week|month) can be defined. For current period, usage is calculated until current time. Start and end dates can be also optionaly defined to filter results.
        /// </remarks>
        /// <exception cref="Api42Vb.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">Number of elements to return (default&#x3D;10) (optional)</param>
        /// <param name="offset">offset for pagination (optional)</param>
        /// <param name="interval">Period unit (day|week|month) (optional)</param>
        /// <param name="startDate">Start date for the period (optional)</param>
        /// <param name="endDate">End date for the period (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of DataVideoUsageList</returns>
        ApiResponse<DataVideoUsageList> GetDataVideoUsageWithHttpInfo(int? limit = default(int?), int? offset = default(int?), string? interval = default(string?), string? startDate = default(string?), string? endDate = default(string?), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDataApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// List Video Usage KPIs
        /// </summary>
        /// <remarks>
        /// Return the usage of the platform ressources.  By default, it returns monthly usage but unit (dayly|week|month) can be defined. For current period, usage is calculated until current time. Start and end dates can be also optionaly defined to filter results.
        /// </remarks>
        /// <exception cref="Api42Vb.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">Number of elements to return (default&#x3D;10) (optional)</param>
        /// <param name="offset">offset for pagination (optional)</param>
        /// <param name="interval">Period unit (day|week|month) (optional)</param>
        /// <param name="startDate">Start date for the period (optional)</param>
        /// <param name="endDate">End date for the period (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DataVideoUsageList</returns>
        System.Threading.Tasks.Task<DataVideoUsageList> GetDataVideoUsageAsync(int? limit = default(int?), int? offset = default(int?), string? interval = default(string?), string? startDate = default(string?), string? endDate = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// List Video Usage KPIs
        /// </summary>
        /// <remarks>
        /// Return the usage of the platform ressources.  By default, it returns monthly usage but unit (dayly|week|month) can be defined. For current period, usage is calculated until current time. Start and end dates can be also optionaly defined to filter results.
        /// </remarks>
        /// <exception cref="Api42Vb.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">Number of elements to return (default&#x3D;10) (optional)</param>
        /// <param name="offset">offset for pagination (optional)</param>
        /// <param name="interval">Period unit (day|week|month) (optional)</param>
        /// <param name="startDate">Start date for the period (optional)</param>
        /// <param name="endDate">End date for the period (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DataVideoUsageList)</returns>
        System.Threading.Tasks.Task<ApiResponse<DataVideoUsageList>> GetDataVideoUsageWithHttpInfoAsync(int? limit = default(int?), int? offset = default(int?), string? interval = default(string?), string? startDate = default(string?), string? endDate = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDataApi : IDataApiSync, IDataApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class DataApi : IDataApi
    {
        private Api42Vb.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="DataApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DataApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DataApi(string basePath)
        {
            this.Configuration = Api42Vb.Client.Configuration.MergeConfigurations(
                Api42Vb.Client.GlobalConfiguration.Instance,
                new Api42Vb.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Api42Vb.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Api42Vb.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Api42Vb.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DataApi(Api42Vb.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Api42Vb.Client.Configuration.MergeConfigurations(
                Api42Vb.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Api42Vb.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Api42Vb.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Api42Vb.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public DataApi(Api42Vb.Client.ISynchronousClient client, Api42Vb.Client.IAsynchronousClient asyncClient, Api42Vb.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Api42Vb.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Api42Vb.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Api42Vb.Client.ISynchronousClient Client { get; set; }

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
        public Api42Vb.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Api42Vb.Client.ExceptionFactory ExceptionFactory
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
        /// List Video Usage KPIs Return the usage of the platform ressources.  By default, it returns monthly usage but unit (dayly|week|month) can be defined. For current period, usage is calculated until current time. Start and end dates can be also optionaly defined to filter results.
        /// </summary>
        /// <exception cref="Api42Vb.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">Number of elements to return (default&#x3D;10) (optional)</param>
        /// <param name="offset">offset for pagination (optional)</param>
        /// <param name="interval">Period unit (day|week|month) (optional)</param>
        /// <param name="startDate">Start date for the period (optional)</param>
        /// <param name="endDate">End date for the period (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>DataVideoUsageList</returns>
        public DataVideoUsageList GetDataVideoUsage(int? limit = default(int?), int? offset = default(int?), string? interval = default(string?), string? startDate = default(string?), string? endDate = default(string?), int operationIndex = 0)
        {
            Api42Vb.Client.ApiResponse<DataVideoUsageList> localVarResponse = GetDataVideoUsageWithHttpInfo(limit, offset, interval, startDate, endDate);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List Video Usage KPIs Return the usage of the platform ressources.  By default, it returns monthly usage but unit (dayly|week|month) can be defined. For current period, usage is calculated until current time. Start and end dates can be also optionaly defined to filter results.
        /// </summary>
        /// <exception cref="Api42Vb.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">Number of elements to return (default&#x3D;10) (optional)</param>
        /// <param name="offset">offset for pagination (optional)</param>
        /// <param name="interval">Period unit (day|week|month) (optional)</param>
        /// <param name="startDate">Start date for the period (optional)</param>
        /// <param name="endDate">End date for the period (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of DataVideoUsageList</returns>
        public Api42Vb.Client.ApiResponse<DataVideoUsageList> GetDataVideoUsageWithHttpInfo(int? limit = default(int?), int? offset = default(int?), string? interval = default(string?), string? startDate = default(string?), string? endDate = default(string?), int operationIndex = 0)
        {
            Api42Vb.Client.RequestOptions localVarRequestOptions = new Api42Vb.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Api42Vb.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Api42Vb.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (limit != null)
            {
                localVarRequestOptions.QueryParameters.Add(Api42Vb.Client.ClientUtils.ParameterToMultiMap("", "limit", limit));
            }
            if (offset != null)
            {
                localVarRequestOptions.QueryParameters.Add(Api42Vb.Client.ClientUtils.ParameterToMultiMap("", "offset", offset));
            }
            if (interval != null)
            {
                localVarRequestOptions.QueryParameters.Add(Api42Vb.Client.ClientUtils.ParameterToMultiMap("", "interval", interval));
            }
            if (startDate != null)
            {
                localVarRequestOptions.QueryParameters.Add(Api42Vb.Client.ClientUtils.ParameterToMultiMap("", "startDate", startDate));
            }
            if (endDate != null)
            {
                localVarRequestOptions.QueryParameters.Add(Api42Vb.Client.ClientUtils.ParameterToMultiMap("", "endDate", endDate));
            }

            localVarRequestOptions.Operation = "DataApi.GetDataVideoUsage";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (api_key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<DataVideoUsageList>("/data/videos/usage", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetDataVideoUsage", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// List Video Usage KPIs Return the usage of the platform ressources.  By default, it returns monthly usage but unit (dayly|week|month) can be defined. For current period, usage is calculated until current time. Start and end dates can be also optionaly defined to filter results.
        /// </summary>
        /// <exception cref="Api42Vb.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">Number of elements to return (default&#x3D;10) (optional)</param>
        /// <param name="offset">offset for pagination (optional)</param>
        /// <param name="interval">Period unit (day|week|month) (optional)</param>
        /// <param name="startDate">Start date for the period (optional)</param>
        /// <param name="endDate">End date for the period (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DataVideoUsageList</returns>
        public async System.Threading.Tasks.Task<DataVideoUsageList> GetDataVideoUsageAsync(int? limit = default(int?), int? offset = default(int?), string? interval = default(string?), string? startDate = default(string?), string? endDate = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Api42Vb.Client.ApiResponse<DataVideoUsageList> localVarResponse = await GetDataVideoUsageWithHttpInfoAsync(limit, offset, interval, startDate, endDate, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List Video Usage KPIs Return the usage of the platform ressources.  By default, it returns monthly usage but unit (dayly|week|month) can be defined. For current period, usage is calculated until current time. Start and end dates can be also optionaly defined to filter results.
        /// </summary>
        /// <exception cref="Api42Vb.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">Number of elements to return (default&#x3D;10) (optional)</param>
        /// <param name="offset">offset for pagination (optional)</param>
        /// <param name="interval">Period unit (day|week|month) (optional)</param>
        /// <param name="startDate">Start date for the period (optional)</param>
        /// <param name="endDate">End date for the period (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DataVideoUsageList)</returns>
        public async System.Threading.Tasks.Task<Api42Vb.Client.ApiResponse<DataVideoUsageList>> GetDataVideoUsageWithHttpInfoAsync(int? limit = default(int?), int? offset = default(int?), string? interval = default(string?), string? startDate = default(string?), string? endDate = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Api42Vb.Client.RequestOptions localVarRequestOptions = new Api42Vb.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Api42Vb.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Api42Vb.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (limit != null)
            {
                localVarRequestOptions.QueryParameters.Add(Api42Vb.Client.ClientUtils.ParameterToMultiMap("", "limit", limit));
            }
            if (offset != null)
            {
                localVarRequestOptions.QueryParameters.Add(Api42Vb.Client.ClientUtils.ParameterToMultiMap("", "offset", offset));
            }
            if (interval != null)
            {
                localVarRequestOptions.QueryParameters.Add(Api42Vb.Client.ClientUtils.ParameterToMultiMap("", "interval", interval));
            }
            if (startDate != null)
            {
                localVarRequestOptions.QueryParameters.Add(Api42Vb.Client.ClientUtils.ParameterToMultiMap("", "startDate", startDate));
            }
            if (endDate != null)
            {
                localVarRequestOptions.QueryParameters.Add(Api42Vb.Client.ClientUtils.ParameterToMultiMap("", "endDate", endDate));
            }

            localVarRequestOptions.Operation = "DataApi.GetDataVideoUsage";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (api_key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<DataVideoUsageList>("/data/videos/usage", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetDataVideoUsage", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
