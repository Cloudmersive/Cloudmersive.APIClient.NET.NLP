# Cloudmersive.APIClient.NET.NLP.Api.PosTaggerApi

All URIs are relative to *https://api.cloudmersive.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PosTaggerTagAdjectives**](PosTaggerApi.md#postaggertagadjectives) | **POST** /nlp-v2/pos/tag/adjectives | Part-of-speech tag a string, filter to adjectives
[**PosTaggerTagAdverbs**](PosTaggerApi.md#postaggertagadverbs) | **POST** /nlp-v2/pos/tag/adverbs | Part-of-speech tag a string, filter to adverbs
[**PosTaggerTagNouns**](PosTaggerApi.md#postaggertagnouns) | **POST** /nlp-v2/pos/tag/nouns | Part-of-speech tag a string, filter to nouns
[**PosTaggerTagPronouns**](PosTaggerApi.md#postaggertagpronouns) | **POST** /nlp-v2/pos/tag/pronouns | Part-of-speech tag a string, filter to pronouns
[**PosTaggerTagSentence**](PosTaggerApi.md#postaggertagsentence) | **POST** /nlp-v2/pos/tag/sentence | Part-of-speech tag a string
[**PosTaggerTagVerbs**](PosTaggerApi.md#postaggertagverbs) | **POST** /nlp-v2/pos/tag/verbs | Part-of-speech tag a string, filter to verbs


<a name="postaggertagadjectives"></a>
# **PosTaggerTagAdjectives**
> PosResponse PosTaggerTagAdjectives (PosRequest request)

Part-of-speech tag a string, filter to adjectives

Part-of-speech (POS) tag a string, find the adjectives, and return result as JSON

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.NLP.Api;
using Cloudmersive.APIClient.NET.NLP.Client;
using Cloudmersive.APIClient.NET.NLP.Model;

namespace Example
{
    public class PosTaggerTagAdjectivesExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new PosTaggerApi();
            var request = new PosRequest(); // PosRequest | Input string

            try
            {
                // Part-of-speech tag a string, filter to adjectives
                PosResponse result = apiInstance.PosTaggerTagAdjectives(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PosTaggerApi.PosTaggerTagAdjectives: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**PosRequest**](PosRequest.md)| Input string | 

### Return type

[**PosResponse**](PosResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postaggertagadverbs"></a>
# **PosTaggerTagAdverbs**
> PosResponse PosTaggerTagAdverbs (PosRequest request)

Part-of-speech tag a string, filter to adverbs

Part-of-speech (POS) tag a string, find the adverbs, and return result as JSON

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.NLP.Api;
using Cloudmersive.APIClient.NET.NLP.Client;
using Cloudmersive.APIClient.NET.NLP.Model;

namespace Example
{
    public class PosTaggerTagAdverbsExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new PosTaggerApi();
            var request = new PosRequest(); // PosRequest | Input string

            try
            {
                // Part-of-speech tag a string, filter to adverbs
                PosResponse result = apiInstance.PosTaggerTagAdverbs(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PosTaggerApi.PosTaggerTagAdverbs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**PosRequest**](PosRequest.md)| Input string | 

### Return type

[**PosResponse**](PosResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postaggertagnouns"></a>
# **PosTaggerTagNouns**
> PosResponse PosTaggerTagNouns (PosRequest request)

Part-of-speech tag a string, filter to nouns

Part-of-speech (POS) tag a string, find the nouns, and return result as JSON

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.NLP.Api;
using Cloudmersive.APIClient.NET.NLP.Client;
using Cloudmersive.APIClient.NET.NLP.Model;

namespace Example
{
    public class PosTaggerTagNounsExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new PosTaggerApi();
            var request = new PosRequest(); // PosRequest | Input string

            try
            {
                // Part-of-speech tag a string, filter to nouns
                PosResponse result = apiInstance.PosTaggerTagNouns(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PosTaggerApi.PosTaggerTagNouns: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**PosRequest**](PosRequest.md)| Input string | 

### Return type

[**PosResponse**](PosResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postaggertagpronouns"></a>
# **PosTaggerTagPronouns**
> PosResponse PosTaggerTagPronouns (PosRequest request)

Part-of-speech tag a string, filter to pronouns

Part-of-speech (POS) tag a string, find the pronouns, and return result as JSON

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.NLP.Api;
using Cloudmersive.APIClient.NET.NLP.Client;
using Cloudmersive.APIClient.NET.NLP.Model;

namespace Example
{
    public class PosTaggerTagPronounsExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new PosTaggerApi();
            var request = new PosRequest(); // PosRequest | Input string

            try
            {
                // Part-of-speech tag a string, filter to pronouns
                PosResponse result = apiInstance.PosTaggerTagPronouns(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PosTaggerApi.PosTaggerTagPronouns: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**PosRequest**](PosRequest.md)| Input string | 

### Return type

[**PosResponse**](PosResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postaggertagsentence"></a>
# **PosTaggerTagSentence**
> PosResponse PosTaggerTagSentence (PosRequest request)

Part-of-speech tag a string

Part-of-speech (POS) tag a string and return result as JSON

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.NLP.Api;
using Cloudmersive.APIClient.NET.NLP.Client;
using Cloudmersive.APIClient.NET.NLP.Model;

namespace Example
{
    public class PosTaggerTagSentenceExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new PosTaggerApi();
            var request = new PosRequest(); // PosRequest | Input string

            try
            {
                // Part-of-speech tag a string
                PosResponse result = apiInstance.PosTaggerTagSentence(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PosTaggerApi.PosTaggerTagSentence: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**PosRequest**](PosRequest.md)| Input string | 

### Return type

[**PosResponse**](PosResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postaggertagverbs"></a>
# **PosTaggerTagVerbs**
> PosResponse PosTaggerTagVerbs (PosRequest request)

Part-of-speech tag a string, filter to verbs

Part-of-speech (POS) tag a string, find the verbs, and return result as JSON

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.NLP.Api;
using Cloudmersive.APIClient.NET.NLP.Client;
using Cloudmersive.APIClient.NET.NLP.Model;

namespace Example
{
    public class PosTaggerTagVerbsExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new PosTaggerApi();
            var request = new PosRequest(); // PosRequest | Input string

            try
            {
                // Part-of-speech tag a string, filter to verbs
                PosResponse result = apiInstance.PosTaggerTagVerbs(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PosTaggerApi.PosTaggerTagVerbs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**PosRequest**](PosRequest.md)| Input string | 

### Return type

[**PosResponse**](PosResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

