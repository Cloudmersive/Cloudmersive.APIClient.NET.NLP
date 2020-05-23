# Cloudmersive.APIClient.NET.NLP.Api.SpellcheckApi

All URIs are relative to *https://api.cloudmersive.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SpellcheckCheckSentence**](SpellcheckApi.md#spellcheckchecksentence) | **POST** /nlp-v2/spellcheck/check/sentence | Check if sentence is spelled correctly
[**SpellcheckCorrectJson**](SpellcheckApi.md#spellcheckcorrectjson) | **POST** /nlp-v2/spellcheck/check/word | Find spelling corrections


<a name="spellcheckchecksentence"></a>
# **SpellcheckCheckSentence**
> CheckSentenceResponse SpellcheckCheckSentence (CheckSentenceRequest value)

Check if sentence is spelled correctly

Checks whether the sentence is spelled correctly and returns the result as JSON

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.NLP.Api;
using Cloudmersive.APIClient.NET.NLP.Client;
using Cloudmersive.APIClient.NET.NLP.Model;

namespace Example
{
    public class SpellcheckCheckSentenceExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new SpellcheckApi();
            var value = new CheckSentenceRequest(); // CheckSentenceRequest | Input sentence

            try
            {
                // Check if sentence is spelled correctly
                CheckSentenceResponse result = apiInstance.SpellcheckCheckSentence(value);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpellcheckApi.SpellcheckCheckSentence: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **value** | [**CheckSentenceRequest**](CheckSentenceRequest.md)| Input sentence | 

### Return type

[**CheckSentenceResponse**](CheckSentenceResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="spellcheckcorrectjson"></a>
# **SpellcheckCorrectJson**
> CheckWordResponse SpellcheckCorrectJson (CheckWordRequest value)

Find spelling corrections

Find spelling correction suggestions and return result as JSON

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.NLP.Api;
using Cloudmersive.APIClient.NET.NLP.Client;
using Cloudmersive.APIClient.NET.NLP.Model;

namespace Example
{
    public class SpellcheckCorrectJsonExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new SpellcheckApi();
            var value = new CheckWordRequest(); // CheckWordRequest | Input string

            try
            {
                // Find spelling corrections
                CheckWordResponse result = apiInstance.SpellcheckCorrectJson(value);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpellcheckApi.SpellcheckCorrectJson: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **value** | [**CheckWordRequest**](CheckWordRequest.md)| Input string | 

### Return type

[**CheckWordResponse**](CheckWordResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

