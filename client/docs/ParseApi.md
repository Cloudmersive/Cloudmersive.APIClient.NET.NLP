# Cloudmersive.APIClient.NET.NLP.Api.ParseApi

All URIs are relative to *https://api.cloudmersive.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ParseParseString**](ParseApi.md#parseparsestring) | **POST** /nlp-v2/parse/tree | Parse string to syntax tree


<a name="parseparsestring"></a>
# **ParseParseString**
> ParseResponse ParseParseString (ParseRequest input)

Parse string to syntax tree

Parses the input string into a Penn Treebank syntax tree

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.NLP.Api;
using Cloudmersive.APIClient.NET.NLP.Client;
using Cloudmersive.APIClient.NET.NLP.Model;

namespace Example
{
    public class ParseParseStringExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ParseApi();
            var input = new ParseRequest(); // ParseRequest | Input string

            try
            {
                // Parse string to syntax tree
                ParseResponse result = apiInstance.ParseParseString(input);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ParseApi.ParseParseString: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **input** | [**ParseRequest**](ParseRequest.md)| Input string | 

### Return type

[**ParseResponse**](ParseResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

