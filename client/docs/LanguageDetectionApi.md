# Cloudmersive.APIClient.NET.NLP.Api.LanguageDetectionApi

All URIs are relative to *https://api.cloudmersive.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**LanguageDetectionGetLanguage**](LanguageDetectionApi.md#languagedetectiongetlanguage) | **POST** /nlp-v2/language/detect | Detect language of text


<a name="languagedetectiongetlanguage"></a>
# **LanguageDetectionGetLanguage**
> LanguageDetectionResponse LanguageDetectionGetLanguage (LanguageDetectionRequest input)

Detect language of text

Automatically determine which language a text string is written in.  Supports Danish (DAN), German (DEU), English (ENG), French (FRA), Italian (ITA), Japanese (JPN), Korean (KOR), Dutch (NLD), Norwegian (NOR), Portuguese (POR), Russian (RUS), Spanish (SPA), Swedish (SWE), Chinese (ZHO).

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.NLP.Api;
using Cloudmersive.APIClient.NET.NLP.Client;
using Cloudmersive.APIClient.NET.NLP.Model;

namespace Example
{
    public class LanguageDetectionGetLanguageExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new LanguageDetectionApi();
            var input = new LanguageDetectionRequest(); // LanguageDetectionRequest | 

            try
            {
                // Detect language of text
                LanguageDetectionResponse result = apiInstance.LanguageDetectionGetLanguage(input);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LanguageDetectionApi.LanguageDetectionGetLanguage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **input** | [**LanguageDetectionRequest**](LanguageDetectionRequest.md)|  | 

### Return type

[**LanguageDetectionResponse**](LanguageDetectionResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

