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
    public interface ITagsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// List Video Tags
        /// </summary>
        /// <remarks>
        /// Return the list of tags created and set to videos
        /// </remarks>
        /// <exception cref="Api42Vb.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">Number of elements to return (default&#x3D;10) (optional)</param>
        /// <param name="offset">offset for pagination (optional)</param>
        /// <param name="partial">\\&#39;partial\\&#39; string to filter list (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>TagList</returns>
        TagList GetTags(int? limit = default(int?), int? offset = default(int?), string? partial = default(string?), int operationIndex = 0);

        /// <summary>
        /// List Video Tags
        /// </summary>
        /// <remarks>
        /// Return the list of tags created and set to videos
        /// </remarks>
        /// <exception cref="Api42Vb.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">Number of elements to return (default&#x3D;10) (optional)</param>
        /// <param name="offset">offset for pagination (optional)</param>
        /// <param name="partial">\\&#39;partial\\&#39; string to filter list (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of TagList</returns>
        ApiResponse<TagList> GetTagsWithHttpInfo(int? limit = default(int?), int? offset = default(int?), string? partial = default(string?), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITagsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// List Video Tags
        /// </summary>
        /// <remarks>
        /// Return the list of tags created and set to videos
        /// </remarks>
        /// <exception cref="Api42Vb.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">Number of elements to return (default&#x3D;10) (optional)</param>
        /// <param name="offset">offset for pagination (optional)</param>
        /// <param name="partial">\\&#39;partial\\&#39; string to filter list (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of TagList</returns>
        System.Threading.Tasks.Task<TagList> GetTagsAsync(int? limit = default(int?), int? offset = default(int?), string? partial = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// List Video Tags
        /// </summary>
        /// <remarks>
        /// Return the list of tags created and set to videos
        /// </remarks>
        /// <exception cref="Api42Vb.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">Number of elements to return (default&#x3D;10) (optional)</param>
        /// <param name="offset">offset for pagination (optional)</param>
        /// <param name="partial">\\&#39;partial\\&#39; string to filter list (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (TagList)</returns>
        System.Threading.Tasks.Task<ApiResponse<TagList>> GetTagsWithHttpInfoAsync(int? limit = default(int?), int? offset = default(int?), string? partial = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITagsApi : ITagsApiSync, ITagsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class TagsApi : ITagsApi
    {
        private Api42Vb.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="TagsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TagsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TagsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TagsApi(string basePath)
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
        /// Initializes a new instance of the <see cref="TagsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TagsApi(Api42Vb.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="TagsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public TagsApi(Api42Vb.Client.ISynchronousClient client, Api42Vb.Client.IAsynchronousClient asyncClient, Api42Vb.Client.IReadableConfiguration configuration)
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
        /// List Video Tags Return the list of tags created and set to videos
        /// </summary>
        /// <exception cref="Api42Vb.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">Number of elements to return (default&#x3D;10) (optional)</param>
        /// <param name="offset">offset for pagination (optional)</param>
        /// <param name="partial">\\&#39;partial\\&#39; string to filter list (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>TagList</returns>
        public TagList GetTags(int? limit = default(int?), int? offset = default(int?), string? partial = default(string?), int operationIndex = 0)
        {
            Api42Vb.Client.ApiResponse<TagList> localVarResponse = GetTagsWithHttpInfo(limit, offset, partial);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List Video Tags Return the list of tags created and set to videos
        /// </summary>
        /// <exception cref="Api42Vb.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">Number of elements to return (default&#x3D;10) (optional)</param>
        /// <param name="offset">offset for pagination (optional)</param>
        /// <param name="partial">\\&#39;partial\\&#39; string to filter list (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of TagList</returns>
        public Api42Vb.Client.ApiResponse<TagList> GetTagsWithHttpInfo(int? limit = default(int?), int? offset = default(int?), string? partial = default(string?), int operationIndex = 0)
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
            if (partial != null)
            {
                localVarRequestOptions.QueryParameters.Add(Api42Vb.Client.ClientUtils.ParameterToMultiMap("", "partial", partial));
            }

            localVarRequestOptions.Operation = "TagsApi.GetTags";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (api_key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<TagList>("/tags", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetTags", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// List Video Tags Return the list of tags created and set to videos
        /// </summary>
        /// <exception cref="Api42Vb.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">Number of elements to return (default&#x3D;10) (optional)</param>
        /// <param name="offset">offset for pagination (optional)</param>
        /// <param name="partial">\\&#39;partial\\&#39; string to filter list (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of TagList</returns>
        public async System.Threading.Tasks.Task<TagList> GetTagsAsync(int? limit = default(int?), int? offset = default(int?), string? partial = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Api42Vb.Client.ApiResponse<TagList> localVarResponse = await GetTagsWithHttpInfoAsync(limit, offset, partial, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List Video Tags Return the list of tags created and set to videos
        /// </summary>
        /// <exception cref="Api42Vb.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">Number of elements to return (default&#x3D;10) (optional)</param>
        /// <param name="offset">offset for pagination (optional)</param>
        /// <param name="partial">\\&#39;partial\\&#39; string to filter list (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (TagList)</returns>
        public async System.Threading.Tasks.Task<Api42Vb.Client.ApiResponse<TagList>> GetTagsWithHttpInfoAsync(int? limit = default(int?), int? offset = default(int?), string? partial = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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
            if (partial != null)
            {
                localVarRequestOptions.QueryParameters.Add(Api42Vb.Client.ClientUtils.ParameterToMultiMap("", "partial", partial));
            }

            localVarRequestOptions.Operation = "TagsApi.GetTags";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (api_key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<TagList>("/tags", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetTags", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}