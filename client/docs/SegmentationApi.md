# Cloudmersive.APIClient.NET.NLP.Api.SegmentationApi

All URIs are relative to *https://api.cloudmersive.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SegmentationGetSentences**](SegmentationApi.md#segmentationgetsentences) | **POST** /nlp-v2/segmentation/sentences | Extract sentences from string
[**SegmentationGetWords**](SegmentationApi.md#segmentationgetwords) | **POST** /nlp-v2/segmentation/words | Get words in input string


<a name="segmentationgetsentences"></a>
# **SegmentationGetSentences**
> SentenceSegmentationResponse SegmentationGetSentences (SentenceSegmentationRequest input)

Extract sentences from string

Segment an input string into separate sentences, output result as a string.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.NLP.Api;
using Cloudmersive.APIClient.NET.NLP.Client;
using Cloudmersive.APIClient.NET.NLP.Model;

namespace Example
{
    public class SegmentationGetSentencesExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new SegmentationApi();
            var input = new SentenceSegmentationRequest(); // SentenceSegmentationRequest | Input string

            try
            {
                // Extract sentences from string
                SentenceSegmentationResponse result = apiInstance.SegmentationGetSentences(input);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SegmentationApi.SegmentationGetSentences: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **input** | [**SentenceSegmentationRequest**](SentenceSegmentationRequest.md)| Input string | 

### Return type

[**SentenceSegmentationResponse**](SentenceSegmentationResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="segmentationgetwords"></a>
# **SegmentationGetWords**
> GetWordsResponse SegmentationGetWords (GetWordsRequest input)

Get words in input string

Get the component words in an input string

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.NLP.Api;
using Cloudmersive.APIClient.NET.NLP.Client;
using Cloudmersive.APIClient.NET.NLP.Model;

namespace Example
{
    public class SegmentationGetWordsExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new SegmentationApi();
            var input = new GetWordsRequest(); // GetWordsRequest | String to process

            try
            {
                // Get words in input string
                GetWordsResponse result = apiInstance.SegmentationGetWords(input);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SegmentationApi.SegmentationGetWords: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **input** | [**GetWordsRequest**](GetWordsRequest.md)| String to process | 

### Return type

[**GetWordsResponse**](GetWordsResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

