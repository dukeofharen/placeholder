/* 
 * HttPlaceholder API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using HttPlaceholder.Client.Client;
using HttPlaceholder.Client.Model;

namespace HttPlaceholder.Client.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IRequestApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// An endpoint which accepts the correlation ID of a request made earlier. HttPlaceholder will create a stub based on this request for you to tweak lateron.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HttPlaceholder.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="correlationId"></param>
        /// <returns>FullStubDto</returns>
        FullStubDto RequestCreateStubForRequest (string correlationId);

        /// <summary>
        /// An endpoint which accepts the correlation ID of a request made earlier. HttPlaceholder will create a stub based on this request for you to tweak lateron.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HttPlaceholder.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="correlationId"></param>
        /// <returns>ApiResponse of FullStubDto</returns>
        ApiResponse<FullStubDto> RequestCreateStubForRequestWithHttpInfo (string correlationId);
        /// <summary>
        /// Delete all requests. This call flushes all the requests.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HttPlaceholder.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns></returns>
        void RequestDeleteAll ();

        /// <summary>
        /// Delete all requests. This call flushes all the requests.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HttPlaceholder.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> RequestDeleteAllWithHttpInfo ();
        /// <summary>
        /// Get all Requests.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HttPlaceholder.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;RequestResultDto&gt;</returns>
        List<RequestResultDto> RequestGetAll ();

        /// <summary>
        /// Get all Requests.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HttPlaceholder.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;RequestResultDto&gt;</returns>
        ApiResponse<List<RequestResultDto>> RequestGetAllWithHttpInfo ();
        /// <summary>
        /// Get overview of all Requests.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HttPlaceholder.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;RequestOverviewDto&gt;</returns>
        List<RequestOverviewDto> RequestGetOverview ();

        /// <summary>
        /// Get overview of all Requests.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HttPlaceholder.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;RequestOverviewDto&gt;</returns>
        ApiResponse<List<RequestOverviewDto>> RequestGetOverviewWithHttpInfo ();
        /// <summary>
        /// Gets a specific request by correlation ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HttPlaceholder.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="correlationId">The original correlation ID.</param>
        /// <returns>RequestResultDto</returns>
        RequestResultDto RequestGetRequest (string correlationId);

        /// <summary>
        /// Gets a specific request by correlation ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HttPlaceholder.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="correlationId">The original correlation ID.</param>
        /// <returns>ApiResponse of RequestResultDto</returns>
        ApiResponse<RequestResultDto> RequestGetRequestWithHttpInfo (string correlationId);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IRequestApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// An endpoint which accepts the correlation ID of a request made earlier. HttPlaceholder will create a stub based on this request for you to tweak lateron.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HttPlaceholder.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="correlationId"></param>
        /// <returns>Task of FullStubDto</returns>
        System.Threading.Tasks.Task<FullStubDto> RequestCreateStubForRequestAsync (string correlationId);

        /// <summary>
        /// An endpoint which accepts the correlation ID of a request made earlier. HttPlaceholder will create a stub based on this request for you to tweak lateron.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HttPlaceholder.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="correlationId"></param>
        /// <returns>Task of ApiResponse (FullStubDto)</returns>
        System.Threading.Tasks.Task<ApiResponse<FullStubDto>> RequestCreateStubForRequestAsyncWithHttpInfo (string correlationId);
        /// <summary>
        /// Delete all requests. This call flushes all the requests.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HttPlaceholder.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task RequestDeleteAllAsync ();

        /// <summary>
        /// Delete all requests. This call flushes all the requests.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HttPlaceholder.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> RequestDeleteAllAsyncWithHttpInfo ();
        /// <summary>
        /// Get all Requests.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HttPlaceholder.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;RequestResultDto&gt;</returns>
        System.Threading.Tasks.Task<List<RequestResultDto>> RequestGetAllAsync ();

        /// <summary>
        /// Get all Requests.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HttPlaceholder.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;RequestResultDto&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<RequestResultDto>>> RequestGetAllAsyncWithHttpInfo ();
        /// <summary>
        /// Get overview of all Requests.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HttPlaceholder.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;RequestOverviewDto&gt;</returns>
        System.Threading.Tasks.Task<List<RequestOverviewDto>> RequestGetOverviewAsync ();

        /// <summary>
        /// Get overview of all Requests.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HttPlaceholder.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;RequestOverviewDto&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<RequestOverviewDto>>> RequestGetOverviewAsyncWithHttpInfo ();
        /// <summary>
        /// Gets a specific request by correlation ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HttPlaceholder.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="correlationId">The original correlation ID.</param>
        /// <returns>Task of RequestResultDto</returns>
        System.Threading.Tasks.Task<RequestResultDto> RequestGetRequestAsync (string correlationId);

        /// <summary>
        /// Gets a specific request by correlation ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HttPlaceholder.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="correlationId">The original correlation ID.</param>
        /// <returns>Task of ApiResponse (RequestResultDto)</returns>
        System.Threading.Tasks.Task<ApiResponse<RequestResultDto>> RequestGetRequestAsyncWithHttpInfo (string correlationId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IRequestApi : IRequestApiSync, IRequestApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class RequestApi : IRequestApi
    {
        private HttPlaceholder.Client.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RequestApi() : this((string) null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RequestApi(String basePath)
        {
            this.Configuration = HttPlaceholder.Client.Client.Configuration.MergeConfigurations(
                HttPlaceholder.Client.Client.GlobalConfiguration.Instance,
                new HttPlaceholder.Client.Client.Configuration { BasePath = basePath }
            );
            this.Client = new HttPlaceholder.Client.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new HttPlaceholder.Client.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = HttPlaceholder.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public RequestApi(HttPlaceholder.Client.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = HttPlaceholder.Client.Client.Configuration.MergeConfigurations(
                HttPlaceholder.Client.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new HttPlaceholder.Client.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new HttPlaceholder.Client.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = HttPlaceholder.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public RequestApi(HttPlaceholder.Client.Client.ISynchronousClient client,HttPlaceholder.Client.Client.IAsynchronousClient asyncClient, HttPlaceholder.Client.Client.IReadableConfiguration configuration)
        {
            if(client == null) throw new ArgumentNullException("client");
            if(asyncClient == null) throw new ArgumentNullException("asyncClient");
            if(configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = HttPlaceholder.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public HttPlaceholder.Client.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public HttPlaceholder.Client.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public HttPlaceholder.Client.Client.IReadableConfiguration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public HttPlaceholder.Client.Client.ExceptionFactory ExceptionFactory
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
        /// An endpoint which accepts the correlation ID of a request made earlier. HttPlaceholder will create a stub based on this request for you to tweak lateron. 
        /// </summary>
        /// <exception cref="HttPlaceholder.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="correlationId"></param>
        /// <returns>FullStubDto</returns>
        public FullStubDto RequestCreateStubForRequest (string correlationId)
        {
             HttPlaceholder.Client.Client.ApiResponse<FullStubDto> localVarResponse = RequestCreateStubForRequestWithHttpInfo(correlationId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// An endpoint which accepts the correlation ID of a request made earlier. HttPlaceholder will create a stub based on this request for you to tweak lateron. 
        /// </summary>
        /// <exception cref="HttPlaceholder.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="correlationId"></param>
        /// <returns>ApiResponse of FullStubDto</returns>
        public HttPlaceholder.Client.Client.ApiResponse< FullStubDto > RequestCreateStubForRequestWithHttpInfo (string correlationId)
        {
            // verify the required parameter 'correlationId' is set
            if (correlationId == null)
                throw new HttPlaceholder.Client.Client.ApiException(400, "Missing required parameter 'correlationId' when calling RequestApi->RequestCreateStubForRequest");

            HttPlaceholder.Client.Client.RequestOptions localVarRequestOptions = new HttPlaceholder.Client.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = HttPlaceholder.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = HttPlaceholder.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("CorrelationId", HttPlaceholder.Client.Client.ClientUtils.ParameterToString(correlationId)); // path parameter


            // make the HTTP request
            var localVarResponse = this.Client.Post< FullStubDto >("/ph-api/requests/{CorrelationId}/stubs", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("RequestCreateStubForRequest", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// An endpoint which accepts the correlation ID of a request made earlier. HttPlaceholder will create a stub based on this request for you to tweak lateron. 
        /// </summary>
        /// <exception cref="HttPlaceholder.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="correlationId"></param>
        /// <returns>Task of FullStubDto</returns>
        public async System.Threading.Tasks.Task<FullStubDto> RequestCreateStubForRequestAsync (string correlationId)
        {
             HttPlaceholder.Client.Client.ApiResponse<FullStubDto> localVarResponse = await RequestCreateStubForRequestAsyncWithHttpInfo(correlationId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// An endpoint which accepts the correlation ID of a request made earlier. HttPlaceholder will create a stub based on this request for you to tweak lateron. 
        /// </summary>
        /// <exception cref="HttPlaceholder.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="correlationId"></param>
        /// <returns>Task of ApiResponse (FullStubDto)</returns>
        public async System.Threading.Tasks.Task<HttPlaceholder.Client.Client.ApiResponse<FullStubDto>> RequestCreateStubForRequestAsyncWithHttpInfo (string correlationId)
        {
            // verify the required parameter 'correlationId' is set
            if (correlationId == null)
                throw new HttPlaceholder.Client.Client.ApiException(400, "Missing required parameter 'correlationId' when calling RequestApi->RequestCreateStubForRequest");


            HttPlaceholder.Client.Client.RequestOptions localVarRequestOptions = new HttPlaceholder.Client.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            localVarRequestOptions.PathParameters.Add("CorrelationId", HttPlaceholder.Client.Client.ClientUtils.ParameterToString(correlationId)); // path parameter


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<FullStubDto>("/ph-api/requests/{CorrelationId}/stubs", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("RequestCreateStubForRequest", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete all requests. This call flushes all the requests. 
        /// </summary>
        /// <exception cref="HttPlaceholder.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns></returns>
        public void RequestDeleteAll ()
        {
             RequestDeleteAllWithHttpInfo();
        }

        /// <summary>
        /// Delete all requests. This call flushes all the requests. 
        /// </summary>
        /// <exception cref="HttPlaceholder.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Object(void)</returns>
        public HttPlaceholder.Client.Client.ApiResponse<Object> RequestDeleteAllWithHttpInfo ()
        {
            HttPlaceholder.Client.Client.RequestOptions localVarRequestOptions = new HttPlaceholder.Client.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = HttPlaceholder.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = HttPlaceholder.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);



            // make the HTTP request
            var localVarResponse = this.Client.Delete<Object>("/ph-api/requests", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("RequestDeleteAll", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete all requests. This call flushes all the requests. 
        /// </summary>
        /// <exception cref="HttPlaceholder.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task RequestDeleteAllAsync ()
        {
             await RequestDeleteAllAsyncWithHttpInfo();

        }

        /// <summary>
        /// Delete all requests. This call flushes all the requests. 
        /// </summary>
        /// <exception cref="HttPlaceholder.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<HttPlaceholder.Client.Client.ApiResponse<Object>> RequestDeleteAllAsyncWithHttpInfo ()
        {

            HttPlaceholder.Client.Client.RequestOptions localVarRequestOptions = new HttPlaceholder.Client.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.DeleteAsync<Object>("/ph-api/requests", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("RequestDeleteAll", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get all Requests. 
        /// </summary>
        /// <exception cref="HttPlaceholder.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;RequestResultDto&gt;</returns>
        public List<RequestResultDto> RequestGetAll ()
        {
             HttPlaceholder.Client.Client.ApiResponse<List<RequestResultDto>> localVarResponse = RequestGetAllWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all Requests. 
        /// </summary>
        /// <exception cref="HttPlaceholder.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;RequestResultDto&gt;</returns>
        public HttPlaceholder.Client.Client.ApiResponse< List<RequestResultDto> > RequestGetAllWithHttpInfo ()
        {
            HttPlaceholder.Client.Client.RequestOptions localVarRequestOptions = new HttPlaceholder.Client.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = HttPlaceholder.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = HttPlaceholder.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);



            // make the HTTP request
            var localVarResponse = this.Client.Get< List<RequestResultDto> >("/ph-api/requests", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("RequestGetAll", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get all Requests. 
        /// </summary>
        /// <exception cref="HttPlaceholder.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;RequestResultDto&gt;</returns>
        public async System.Threading.Tasks.Task<List<RequestResultDto>> RequestGetAllAsync ()
        {
             HttPlaceholder.Client.Client.ApiResponse<List<RequestResultDto>> localVarResponse = await RequestGetAllAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all Requests. 
        /// </summary>
        /// <exception cref="HttPlaceholder.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;RequestResultDto&gt;)</returns>
        public async System.Threading.Tasks.Task<HttPlaceholder.Client.Client.ApiResponse<List<RequestResultDto>>> RequestGetAllAsyncWithHttpInfo ()
        {

            HttPlaceholder.Client.Client.RequestOptions localVarRequestOptions = new HttPlaceholder.Client.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<List<RequestResultDto>>("/ph-api/requests", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("RequestGetAll", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get overview of all Requests. 
        /// </summary>
        /// <exception cref="HttPlaceholder.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;RequestOverviewDto&gt;</returns>
        public List<RequestOverviewDto> RequestGetOverview ()
        {
             HttPlaceholder.Client.Client.ApiResponse<List<RequestOverviewDto>> localVarResponse = RequestGetOverviewWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get overview of all Requests. 
        /// </summary>
        /// <exception cref="HttPlaceholder.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;RequestOverviewDto&gt;</returns>
        public HttPlaceholder.Client.Client.ApiResponse< List<RequestOverviewDto> > RequestGetOverviewWithHttpInfo ()
        {
            HttPlaceholder.Client.Client.RequestOptions localVarRequestOptions = new HttPlaceholder.Client.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = HttPlaceholder.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = HttPlaceholder.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);



            // make the HTTP request
            var localVarResponse = this.Client.Get< List<RequestOverviewDto> >("/ph-api/requests/overview", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("RequestGetOverview", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get overview of all Requests. 
        /// </summary>
        /// <exception cref="HttPlaceholder.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;RequestOverviewDto&gt;</returns>
        public async System.Threading.Tasks.Task<List<RequestOverviewDto>> RequestGetOverviewAsync ()
        {
             HttPlaceholder.Client.Client.ApiResponse<List<RequestOverviewDto>> localVarResponse = await RequestGetOverviewAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get overview of all Requests. 
        /// </summary>
        /// <exception cref="HttPlaceholder.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;RequestOverviewDto&gt;)</returns>
        public async System.Threading.Tasks.Task<HttPlaceholder.Client.Client.ApiResponse<List<RequestOverviewDto>>> RequestGetOverviewAsyncWithHttpInfo ()
        {

            HttPlaceholder.Client.Client.RequestOptions localVarRequestOptions = new HttPlaceholder.Client.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<List<RequestOverviewDto>>("/ph-api/requests/overview", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("RequestGetOverview", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Gets a specific request by correlation ID. 
        /// </summary>
        /// <exception cref="HttPlaceholder.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="correlationId">The original correlation ID.</param>
        /// <returns>RequestResultDto</returns>
        public RequestResultDto RequestGetRequest (string correlationId)
        {
             HttPlaceholder.Client.Client.ApiResponse<RequestResultDto> localVarResponse = RequestGetRequestWithHttpInfo(correlationId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets a specific request by correlation ID. 
        /// </summary>
        /// <exception cref="HttPlaceholder.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="correlationId">The original correlation ID.</param>
        /// <returns>ApiResponse of RequestResultDto</returns>
        public HttPlaceholder.Client.Client.ApiResponse< RequestResultDto > RequestGetRequestWithHttpInfo (string correlationId)
        {
            // verify the required parameter 'correlationId' is set
            if (correlationId == null)
                throw new HttPlaceholder.Client.Client.ApiException(400, "Missing required parameter 'correlationId' when calling RequestApi->RequestGetRequest");

            HttPlaceholder.Client.Client.RequestOptions localVarRequestOptions = new HttPlaceholder.Client.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = HttPlaceholder.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = HttPlaceholder.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("correlationId", HttPlaceholder.Client.Client.ClientUtils.ParameterToString(correlationId)); // path parameter


            // make the HTTP request
            var localVarResponse = this.Client.Get< RequestResultDto >("/ph-api/requests/{correlationId}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("RequestGetRequest", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Gets a specific request by correlation ID. 
        /// </summary>
        /// <exception cref="HttPlaceholder.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="correlationId">The original correlation ID.</param>
        /// <returns>Task of RequestResultDto</returns>
        public async System.Threading.Tasks.Task<RequestResultDto> RequestGetRequestAsync (string correlationId)
        {
             HttPlaceholder.Client.Client.ApiResponse<RequestResultDto> localVarResponse = await RequestGetRequestAsyncWithHttpInfo(correlationId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets a specific request by correlation ID. 
        /// </summary>
        /// <exception cref="HttPlaceholder.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="correlationId">The original correlation ID.</param>
        /// <returns>Task of ApiResponse (RequestResultDto)</returns>
        public async System.Threading.Tasks.Task<HttPlaceholder.Client.Client.ApiResponse<RequestResultDto>> RequestGetRequestAsyncWithHttpInfo (string correlationId)
        {
            // verify the required parameter 'correlationId' is set
            if (correlationId == null)
                throw new HttPlaceholder.Client.Client.ApiException(400, "Missing required parameter 'correlationId' when calling RequestApi->RequestGetRequest");


            HttPlaceholder.Client.Client.RequestOptions localVarRequestOptions = new HttPlaceholder.Client.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            localVarRequestOptions.PathParameters.Add("correlationId", HttPlaceholder.Client.Client.ClientUtils.ParameterToString(correlationId)); // path parameter


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<RequestResultDto>("/ph-api/requests/{correlationId}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("RequestGetRequest", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}