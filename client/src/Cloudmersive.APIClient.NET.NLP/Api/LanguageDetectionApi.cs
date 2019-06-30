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
using Cloudmersive.APIClient.NET.NLP.Model;

namespace Cloudmersive.APIClient.NET.NLP.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ILanguageDetectionApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Detect language of text
        /// </summary>
        /// <remarks>
        /// Automatically determine which language a text string is written in.  Supports Danish (DAN), German (DEU), English (ENG), French (FRA), Italian (ITA), Japanese (JPN), Korean (KOR), Dutch (NLD), Norwegian (NOR), Portuguese (POR), Russian (RUS), Spanish (SPA), Swedish (SWE), Chinese (ZHO).
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NET.NLP.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="textToDetect">Text to detect language of</param>
        /// <returns>LanguageDetectionResponse</returns>
        LanguageDetectionResponse LanguageDetectionPost (string textToDetect);

        /// <summary>
        /// Detect language of text
        /// </summary>
        /// <remarks>
        /// Automatically determine which language a text string is written in.  Supports Danish (DAN), German (DEU), English (ENG), French (FRA), Italian (ITA), Japanese (JPN), Korean (KOR), Dutch (NLD), Norwegian (NOR), Portuguese (POR), Russian (RUS), Spanish (SPA), Swedish (SWE), Chinese (ZHO).
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NET.NLP.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="textToDetect">Text to detect language of</param>
        /// <returns>ApiResponse of LanguageDetectionResponse</returns>
        ApiResponse<LanguageDetectionResponse> LanguageDetectionPostWithHttpInfo (string textToDetect);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Detect language of text
        /// </summary>
        /// <remarks>
        /// Automatically determine which language a text string is written in.  Supports Danish (DAN), German (DEU), English (ENG), French (FRA), Italian (ITA), Japanese (JPN), Korean (KOR), Dutch (NLD), Norwegian (NOR), Portuguese (POR), Russian (RUS), Spanish (SPA), Swedish (SWE), Chinese (ZHO).
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NET.NLP.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="textToDetect">Text to detect language of</param>
        /// <returns>Task of LanguageDetectionResponse</returns>
        System.Threading.Tasks.Task<LanguageDetectionResponse> LanguageDetectionPostAsync (string textToDetect);

        /// <summary>
        /// Detect language of text
        /// </summary>
        /// <remarks>
        /// Automatically determine which language a text string is written in.  Supports Danish (DAN), German (DEU), English (ENG), French (FRA), Italian (ITA), Japanese (JPN), Korean (KOR), Dutch (NLD), Norwegian (NOR), Portuguese (POR), Russian (RUS), Spanish (SPA), Swedish (SWE), Chinese (ZHO).
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NET.NLP.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="textToDetect">Text to detect language of</param>
        /// <returns>Task of ApiResponse (LanguageDetectionResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<LanguageDetectionResponse>> LanguageDetectionPostAsyncWithHttpInfo (string textToDetect);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class LanguageDetectionApi : ILanguageDetectionApi
    {
        private Cloudmersive.APIClient.NET.NLP.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageDetectionApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LanguageDetectionApi(String basePath)
        {
            this.Configuration = new Cloudmersive.APIClient.NET.NLP.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Cloudmersive.APIClient.NET.NLP.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageDetectionApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public LanguageDetectionApi(Cloudmersive.APIClient.NET.NLP.Client.Configuration configuration = null)
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
        /// Detect language of text Automatically determine which language a text string is written in.  Supports Danish (DAN), German (DEU), English (ENG), French (FRA), Italian (ITA), Japanese (JPN), Korean (KOR), Dutch (NLD), Norwegian (NOR), Portuguese (POR), Russian (RUS), Spanish (SPA), Swedish (SWE), Chinese (ZHO).
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NET.NLP.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="textToDetect">Text to detect language of</param>
        /// <returns>LanguageDetectionResponse</returns>
        public LanguageDetectionResponse LanguageDetectionPost (string textToDetect)
        {
             ApiResponse<LanguageDetectionResponse> localVarResponse = LanguageDetectionPostWithHttpInfo(textToDetect);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Detect language of text Automatically determine which language a text string is written in.  Supports Danish (DAN), German (DEU), English (ENG), French (FRA), Italian (ITA), Japanese (JPN), Korean (KOR), Dutch (NLD), Norwegian (NOR), Portuguese (POR), Russian (RUS), Spanish (SPA), Swedish (SWE), Chinese (ZHO).
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NET.NLP.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="textToDetect">Text to detect language of</param>
        /// <returns>ApiResponse of LanguageDetectionResponse</returns>
        public ApiResponse< LanguageDetectionResponse > LanguageDetectionPostWithHttpInfo (string textToDetect)
        {
            // verify the required parameter 'textToDetect' is set
            if (textToDetect == null)
                throw new ApiException(400, "Missing required parameter 'textToDetect' when calling LanguageDetectionApi->LanguageDetectionPost");

            var localVarPath = "/nlp/language/detect";
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

            if (textToDetect != null && textToDetect.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(textToDetect); // http body (model) parameter
            }
            else
            {
                localVarPostBody = textToDetect; // byte array
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
                Exception exception = ExceptionFactory("LanguageDetectionPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<LanguageDetectionResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LanguageDetectionResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LanguageDetectionResponse)));
        }

        /// <summary>
        /// Detect language of text Automatically determine which language a text string is written in.  Supports Danish (DAN), German (DEU), English (ENG), French (FRA), Italian (ITA), Japanese (JPN), Korean (KOR), Dutch (NLD), Norwegian (NOR), Portuguese (POR), Russian (RUS), Spanish (SPA), Swedish (SWE), Chinese (ZHO).
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NET.NLP.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="textToDetect">Text to detect language of</param>
        /// <returns>Task of LanguageDetectionResponse</returns>
        public async System.Threading.Tasks.Task<LanguageDetectionResponse> LanguageDetectionPostAsync (string textToDetect)
        {
             ApiResponse<LanguageDetectionResponse> localVarResponse = await LanguageDetectionPostAsyncWithHttpInfo(textToDetect);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Detect language of text Automatically determine which language a text string is written in.  Supports Danish (DAN), German (DEU), English (ENG), French (FRA), Italian (ITA), Japanese (JPN), Korean (KOR), Dutch (NLD), Norwegian (NOR), Portuguese (POR), Russian (RUS), Spanish (SPA), Swedish (SWE), Chinese (ZHO).
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NET.NLP.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="textToDetect">Text to detect language of</param>
        /// <returns>Task of ApiResponse (LanguageDetectionResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LanguageDetectionResponse>> LanguageDetectionPostAsyncWithHttpInfo (string textToDetect)
        {
            // verify the required parameter 'textToDetect' is set
            if (textToDetect == null)
                throw new ApiException(400, "Missing required parameter 'textToDetect' when calling LanguageDetectionApi->LanguageDetectionPost");

            var localVarPath = "/nlp/language/detect";
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

            if (textToDetect != null && textToDetect.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(textToDetect); // http body (model) parameter
            }
            else
            {
                localVarPostBody = textToDetect; // byte array
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
                Exception exception = ExceptionFactory("LanguageDetectionPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<LanguageDetectionResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LanguageDetectionResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LanguageDetectionResponse)));
        }

    }
}
