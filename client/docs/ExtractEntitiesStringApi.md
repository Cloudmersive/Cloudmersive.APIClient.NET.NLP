# Cloudmersive.APIClient.NET.NLP.Api.ExtractEntitiesStringApi

All URIs are relative to *https://api.cloudmersive.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ExtractEntitiesStringPost**](ExtractEntitiesStringApi.md#extractentitiesstringpost) | **POST** /nlp/ExtractEntitiesString | Extract entities from string


<a name="extractentitiesstringpost"></a>
# **ExtractEntitiesStringPost**
> string ExtractEntitiesStringPost (string value)

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
    public class ExtractEntitiesStringPostExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ExtractEntitiesStringApi();
            var value = value_example;  // string | Input string

            try
            {
                // Extract entities from string
                string result = apiInstance.ExtractEntitiesStringPost(value);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExtractEntitiesStringApi.ExtractEntitiesStringPost: " + e.Message );
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

**string**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

