/* 
 * nlpapi
 *
 * The powerful Natural Language Processing APIs let you perform part of speech tagging, entity identification, sentence parsing, and much more to help you understand the meaning of unstructured text.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Cloudmersive.APIClient.NET.NLP.Client;

namespace Cloudmersive.APIClient.NET.NLP.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISentencesApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Extract sentences from string
        /// </summary>
        /// <remarks>
        /// Segment an input string into separate sentences, output result as a string.
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NET.NLP.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="input">Input string</param>
        /// <returns>string</returns>
        string SentencesPost (string input);

        /// <summary>
        /// Extract sentences from string
        /// </summary>
        /// <remarks>
        /// Segment an input string into separate sentences, output result as a string.
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NET.NLP.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="input">Input string</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> SentencesPostWithHttpInfo (string input);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Extract sentences from string
        /// </summary>
        /// <remarks>
        /// Segment an input string into separate sentences, output result as a string.
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NET.NLP.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="input">Input string</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> SentencesPostAsync (string input);

        /// <summary>
        /// Extract sentences from string
        /// </summary>
        /// <remarks>
        /// Segment an input string into separate sentences, output result as a string.
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NET.NLP.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="input">Input string</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> SentencesPostAsyncWithHttpInfo (string input);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SentencesApi : ISentencesApi
    {
        private Cloudmersive.APIClient.NET.NLP.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SentencesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SentencesApi(String basePath)
        {
            this.Configuration = new Cloudmersive.APIClient.NET.NLP.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Cloudmersive.APIClient.NET.NLP.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SentencesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SentencesApi(Cloudmersive.APIClient.NET.NLP.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Cloudmersive.APIClient.NET.NLP.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Cloudmersive.APIClient.NET.NLP.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Cloudmersive.APIClient.NET.NLP.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Cloudmersive.APIClient.NET.NLP.Client.ExceptionFactory ExceptionFactory
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
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Extract sentences from string Segment an input string into separate sentences, output result as a string.
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NET.NLP.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="input">Input string</param>
        /// <returns>string</returns>
        public string SentencesPost (string input)
        {
             ApiResponse<string> localVarResponse = SentencesPostWithHttpInfo(input);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Extract sentences from string Segment an input string into separate sentences, output result as a string.
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NET.NLP.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="input">Input string</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > SentencesPostWithHttpInfo (string input)
        {
            // verify the required parameter 'input' is set
            if (input == null)
                throw new ApiException(400, "Missing required parameter 'input' when calling SentencesApi->SentencesPost");

            var localVarPath = "/nlp/get/sentences/string";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "text/json", 
                "application/xml", 
                "text/xml", 
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (input != null && input.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(input); // http body (model) parameter
            }
            else
            {
                localVarPostBody = input; // byte array
            }

            // authentication (Apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Apikey")))
            {
                localVarHeaderParams["Apikey"] = this.Configuration.GetApiKeyWithPrefix("Apikey");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SentencesPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

        /// <summary>
        /// Extract sentences from string Segment an input string into separate sentences, output result as a string.
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NET.NLP.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="input">Input string</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> SentencesPostAsync (string input)
        {
             ApiResponse<string> localVarResponse = await SentencesPostAsyncWithHttpInfo(input);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Extract sentences from string Segment an input string into separate sentences, output result as a string.
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NET.NLP.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="input">Input string</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> SentencesPostAsyncWithHttpInfo (string input)
        {
            // verify the required parameter 'input' is set
            if (input == null)
                throw new ApiException(400, "Missing required parameter 'input' when calling SentencesApi->SentencesPost");

            var localVarPath = "/nlp/get/sentences/string";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "text/json", 
                "application/xml", 
                "text/xml", 
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (input != null && input.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(input); // http body (model) parameter
            }
            else
            {
                localVarPostBody = input; // byte array
            }

            // authentication (Apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Apikey")))
            {
                localVarHeaderParams["Apikey"] = this.Configuration.GetApiKeyWithPrefix("Apikey");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SentencesPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

    }
}
