# Cloudmersive.APIClient.NET.NLP.Api.ExtractEntitiesApi

All URIs are relative to *https://api.cloudmersive.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ExtractEntitiesPost**](ExtractEntitiesApi.md#extractentitiespost) | **POST** /nlp-v2/extract-entities | Extract entities from string


<a name="extractentitiespost"></a>
# **ExtractEntitiesPost**
> ExtractEntitiesResponse ExtractEntitiesPost (ExtractEntitiesRequest value)

Extract entities from string

Extract the named entitites from an input string.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.NLP.Api;
using Cloudmersive.APIClient.NET.NLP.Client;
using Cloudmersive.APIClient.NET.NLP.Model;

namespace Example
{
    public class ExtractEntitiesPostExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ExtractEntitiesApi();
            var value = new ExtractEntitiesRequest(); // ExtractEntitiesRequest | Input string

            try
            {
                // Extract entities from string
                ExtractEntitiesResponse result = apiInstance.ExtractEntitiesPost(value);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExtractEntitiesApi.ExtractEntitiesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **value** | [**ExtractEntitiesRequest**](ExtractEntitiesRequest.md)| Input string | 

### Return type

[**ExtractEntitiesResponse**](ExtractEntitiesResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

