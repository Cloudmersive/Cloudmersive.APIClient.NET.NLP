# Cloudmersive.APIClient.NET.NLP.Api.AnalyticsApi

All URIs are relative to *https://api.cloudmersive.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AnalyticsHateSpeech**](AnalyticsApi.md#analyticshatespeech) | **POST** /nlp-v2/analytics/hate-speech | Perform Hate Speech Analysis and Detection on Text
[**AnalyticsProfanity**](AnalyticsApi.md#analyticsprofanity) | **POST** /nlp-v2/analytics/profanity | Perform Profanity and Obscene Language Analysis and Detection on Text
[**AnalyticsSentiment**](AnalyticsApi.md#analyticssentiment) | **POST** /nlp-v2/analytics/sentiment | Perform Sentiment Analysis and Classification on Text
[**AnalyticsSimilarity**](AnalyticsApi.md#analyticssimilarity) | **POST** /nlp-v2/analytics/similarity | Perform Semantic Similarity Comparison of Two Strings
[**AnalyticsSubjectivity**](AnalyticsApi.md#analyticssubjectivity) | **POST** /nlp-v2/analytics/subjectivity | Perform Subjectivity and Objectivity Analysis on Text


<a name="analyticshatespeech"></a>
# **AnalyticsHateSpeech**
> HateSpeechAnalysisResponse AnalyticsHateSpeech (HateSpeechAnalysisRequest input)

Perform Hate Speech Analysis and Detection on Text

Analyze input text using advanced Hate Speech Analysis to determine if the input contains hate speech language.  Supports English language input.  Consumes 1-2 API calls per sentence.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.NLP.Api;
using Cloudmersive.APIClient.NET.NLP.Client;
using Cloudmersive.APIClient.NET.NLP.Model;

namespace Example
{
    public class AnalyticsHateSpeechExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new AnalyticsApi();
            var input = new HateSpeechAnalysisRequest(); // HateSpeechAnalysisRequest | Input hate speech analysis request

            try
            {
                // Perform Hate Speech Analysis and Detection on Text
                HateSpeechAnalysisResponse result = apiInstance.AnalyticsHateSpeech(input);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.AnalyticsHateSpeech: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **input** | [**HateSpeechAnalysisRequest**](HateSpeechAnalysisRequest.md)| Input hate speech analysis request | 

### Return type

[**HateSpeechAnalysisResponse**](HateSpeechAnalysisResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="analyticsprofanity"></a>
# **AnalyticsProfanity**
> ProfanityAnalysisResponse AnalyticsProfanity (ProfanityAnalysisRequest input)

Perform Profanity and Obscene Language Analysis and Detection on Text

Analyze input text using advanced Profanity and Obscene Language Analysis to determine if the input contains profane language.  Supports English language input.  Consumes 1-2 API calls per sentence.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.NLP.Api;
using Cloudmersive.APIClient.NET.NLP.Client;
using Cloudmersive.APIClient.NET.NLP.Model;

namespace Example
{
    public class AnalyticsProfanityExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new AnalyticsApi();
            var input = new ProfanityAnalysisRequest(); // ProfanityAnalysisRequest | Input profanity analysis request

            try
            {
                // Perform Profanity and Obscene Language Analysis and Detection on Text
                ProfanityAnalysisResponse result = apiInstance.AnalyticsProfanity(input);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.AnalyticsProfanity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **input** | [**ProfanityAnalysisRequest**](ProfanityAnalysisRequest.md)| Input profanity analysis request | 

### Return type

[**ProfanityAnalysisResponse**](ProfanityAnalysisResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="analyticssentiment"></a>
# **AnalyticsSentiment**
> SentimentAnalysisResponse AnalyticsSentiment (SentimentAnalysisRequest input)

Perform Sentiment Analysis and Classification on Text

Analyze input text using advanced Sentiment Analysis to determine if the input is positive, negative, or neutral.  Supports English language input.  Consumes 1-2 API calls per sentence.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.NLP.Api;
using Cloudmersive.APIClient.NET.NLP.Client;
using Cloudmersive.APIClient.NET.NLP.Model;

namespace Example
{
    public class AnalyticsSentimentExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new AnalyticsApi();
            var input = new SentimentAnalysisRequest(); // SentimentAnalysisRequest | Input sentiment analysis request

            try
            {
                // Perform Sentiment Analysis and Classification on Text
                SentimentAnalysisResponse result = apiInstance.AnalyticsSentiment(input);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.AnalyticsSentiment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **input** | [**SentimentAnalysisRequest**](SentimentAnalysisRequest.md)| Input sentiment analysis request | 

### Return type

[**SentimentAnalysisResponse**](SentimentAnalysisResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="analyticssimilarity"></a>
# **AnalyticsSimilarity**
> SimilarityAnalysisResponse AnalyticsSimilarity (SimilarityAnalysisRequest input)

Perform Semantic Similarity Comparison of Two Strings

Analyze two input text strings, typically sentences, and determine the semantic similarity of each.  Semantic similarity refers to the degree to which two sentences mean the same thing semantically.  Uses advanced Deep Learning to perform the semantic similarity comparison.  Consumes 1-2 API calls per sentence.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.NLP.Api;
using Cloudmersive.APIClient.NET.NLP.Client;
using Cloudmersive.APIClient.NET.NLP.Model;

namespace Example
{
    public class AnalyticsSimilarityExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new AnalyticsApi();
            var input = new SimilarityAnalysisRequest(); // SimilarityAnalysisRequest | Input similarity analysis request

            try
            {
                // Perform Semantic Similarity Comparison of Two Strings
                SimilarityAnalysisResponse result = apiInstance.AnalyticsSimilarity(input);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.AnalyticsSimilarity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **input** | [**SimilarityAnalysisRequest**](SimilarityAnalysisRequest.md)| Input similarity analysis request | 

### Return type

[**SimilarityAnalysisResponse**](SimilarityAnalysisResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="analyticssubjectivity"></a>
# **AnalyticsSubjectivity**
> SubjectivityAnalysisResponse AnalyticsSubjectivity (SubjectivityAnalysisRequest input)

Perform Subjectivity and Objectivity Analysis on Text

Analyze input text using advanced Subjectivity and Objectivity Language Analysis to determine if the input text is objective or subjective, and how much.  Supports English language input.  Consumes 1-2 API calls per sentence.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.NLP.Api;
using Cloudmersive.APIClient.NET.NLP.Client;
using Cloudmersive.APIClient.NET.NLP.Model;

namespace Example
{
    public class AnalyticsSubjectivityExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new AnalyticsApi();
            var input = new SubjectivityAnalysisRequest(); // SubjectivityAnalysisRequest | Input subjectivity analysis request

            try
            {
                // Perform Subjectivity and Objectivity Analysis on Text
                SubjectivityAnalysisResponse result = apiInstance.AnalyticsSubjectivity(input);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.AnalyticsSubjectivity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **input** | [**SubjectivityAnalysisRequest**](SubjectivityAnalysisRequest.md)| Input subjectivity analysis request | 

### Return type

[**SubjectivityAnalysisResponse**](SubjectivityAnalysisResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

