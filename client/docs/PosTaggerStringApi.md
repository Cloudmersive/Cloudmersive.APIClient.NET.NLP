# Cloudmersive.APIClient.NET.NLP.Api.PosTaggerStringApi

All URIs are relative to *https://api.cloudmersive.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PosTaggerStringPost**](PosTaggerStringApi.md#postaggerstringpost) | **POST** /nlp/PosTaggerString | Part-of-speech tag a string


<a name="postaggerstringpost"></a>
# **PosTaggerStringPost**
> string PosTaggerStringPost (string input)

Part-of-speech tag a string

Perform a part-of-speech (POS) tagging on the input string.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.NLP.Api;
using Cloudmersive.APIClient.NET.NLP.Client;
using Cloudmersive.APIClient.NET.NLP.Model;

namespace Example
{
    public class PosTaggerStringPostExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new PosTaggerStringApi();
            var input = input_example;  // string | Input string

            try
            {
                // Part-of-speech tag a string
                string result = apiInstance.PosTaggerStringPost(input);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PosTaggerStringApi.PosTaggerStringPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **input** | **string**| Input string | 

### Return type

**string**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

