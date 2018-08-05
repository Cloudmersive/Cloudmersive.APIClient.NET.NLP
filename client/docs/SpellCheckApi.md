# Cloudmersive.APIClient.NET.NLP.Api.SpellCheckApi

All URIs are relative to *https://api.cloudmersive.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SpellCheckCheckJson**](SpellCheckApi.md#spellcheckcheckjson) | **POST** /nlp/spellcheck/check/word/json | Spell check word
[**SpellCheckCheckSentenceJson**](SpellCheckApi.md#spellcheckchecksentencejson) | **POST** /nlp/spellcheck/check/sentence/json | Check if sentence is spelled correctly
[**SpellCheckCheckSentenceString**](SpellCheckApi.md#spellcheckchecksentencestring) | **POST** /nlp/spellcheck/check/sentence/string | Spell check a sentence
[**SpellCheckCorrect**](SpellCheckApi.md#spellcheckcorrect) | **POST** /nlp/spellcheck/correct/word/string | Find spelling corrections
[**SpellCheckCorrectJson**](SpellCheckApi.md#spellcheckcorrectjson) | **POST** /nlp/spellcheck/correct/word/json | Find spelling corrections
[**SpellCheckPost**](SpellCheckApi.md#spellcheckpost) | **POST** /nlp/spellcheck/check/word/string | Spell check a word


<a name="spellcheckcheckjson"></a>
# **SpellCheckCheckJson**
> CheckJsonResponse SpellCheckCheckJson (string value)

Spell check word

Spell check a word as JSON

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.NLP.Api;
using Cloudmersive.APIClient.NET.NLP.Client;
using Cloudmersive.APIClient.NET.NLP.Model;

namespace Example
{
    public class SpellCheckCheckJsonExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new SpellCheckApi();
            var value = value_example;  // string | Input sentence

            try
            {
                // Spell check word
                CheckJsonResponse result = apiInstance.SpellCheckCheckJson(value);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpellCheckApi.SpellCheckCheckJson: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **value** | **string**| Input sentence | 

### Return type

[**CheckJsonResponse**](CheckJsonResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="spellcheckchecksentencejson"></a>
# **SpellCheckCheckSentenceJson**
> CheckSentenceJsonResponse SpellCheckCheckSentenceJson (string value)

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
    public class SpellCheckCheckSentenceJsonExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new SpellCheckApi();
            var value = value_example;  // string | Input sentence

            try
            {
                // Check if sentence is spelled correctly
                CheckSentenceJsonResponse result = apiInstance.SpellCheckCheckSentenceJson(value);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpellCheckApi.SpellCheckCheckSentenceJson: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **value** | **string**| Input sentence | 

### Return type

[**CheckSentenceJsonResponse**](CheckSentenceJsonResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="spellcheckchecksentencestring"></a>
# **SpellCheckCheckSentenceString**
> bool? SpellCheckCheckSentenceString (string value)

Spell check a sentence

Check if a sentence is spelled correctly

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.NLP.Api;
using Cloudmersive.APIClient.NET.NLP.Client;
using Cloudmersive.APIClient.NET.NLP.Model;

namespace Example
{
    public class SpellCheckCheckSentenceStringExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new SpellCheckApi();
            var value = value_example;  // string | Input sentence word

            try
            {
                // Spell check a sentence
                bool? result = apiInstance.SpellCheckCheckSentenceString(value);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpellCheckApi.SpellCheckCheckSentenceString: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **value** | **string**| Input sentence word | 

### Return type

**bool?**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="spellcheckcorrect"></a>
# **SpellCheckCorrect**
> string SpellCheckCorrect (string value)

Find spelling corrections

Find the spelling corrections for a word

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.NLP.Api;
using Cloudmersive.APIClient.NET.NLP.Client;
using Cloudmersive.APIClient.NET.NLP.Model;

namespace Example
{
    public class SpellCheckCorrectExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new SpellCheckApi();
            var value = value_example;  // string | Input word

            try
            {
                // Find spelling corrections
                string result = apiInstance.SpellCheckCorrect(value);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpellCheckApi.SpellCheckCorrect: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **value** | **string**| Input word | 

### Return type

**string**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="spellcheckcorrectjson"></a>
# **SpellCheckCorrectJson**
> CorrectJsonResponse SpellCheckCorrectJson (string value)

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
    public class SpellCheckCorrectJsonExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new SpellCheckApi();
            var value = value_example;  // string | Input string

            try
            {
                // Find spelling corrections
                CorrectJsonResponse result = apiInstance.SpellCheckCorrectJson(value);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpellCheckApi.SpellCheckCorrectJson: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **value** | **string**| Input string | 

### Return type

[**CorrectJsonResponse**](CorrectJsonResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="spellcheckpost"></a>
# **SpellCheckPost**
> bool? SpellCheckPost (string value)

Spell check a word

Check if a word is spelled correctly

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.NLP.Api;
using Cloudmersive.APIClient.NET.NLP.Client;
using Cloudmersive.APIClient.NET.NLP.Model;

namespace Example
{
    public class SpellCheckPostExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new SpellCheckApi();
            var value = value_example;  // string | Input string word

            try
            {
                // Spell check a word
                bool? result = apiInstance.SpellCheckPost(value);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpellCheckApi.SpellCheckPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **value** | **string**| Input string word | 

### Return type

**bool?**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

