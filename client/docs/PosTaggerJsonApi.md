# Cloudmersive.APIClient.NET.NLP.Api.PosTaggerJsonApi

All URIs are relative to *https://api.cloudmersive.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PosTaggerJsonPost**](PosTaggerJsonApi.md#postaggerjsonpost) | **POST** /nlp/PosTaggerJson | Part-of-speech tag a string


<a name="postaggerjsonpost"></a>
# **PosTaggerJsonPost**
> PosResponse PosTaggerJsonPost (PosRequest request)

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
    public class PosTaggerJsonPostExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new PosTaggerJsonApi();
            var request = new PosRequest(); // PosRequest | Input string

            try
            {
                // Part-of-speech tag a string
                PosResponse result = apiInstance.PosTaggerJsonPost(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PosTaggerJsonApi.PosTaggerJsonPost: " + e.Message );
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
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

