# Cloudmersive.APIClient.NET.NLP.Api.LanguageTranslationApi

All URIs are relative to *https://api.cloudmersive.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**LanguageTranslationTranslateDeuToEng**](LanguageTranslationApi.md#languagetranslationtranslatedeutoeng) | **POST** /nlp-v2/translate/language/deu/to/eng | Translate German to English text with Deep Learning AI
[**LanguageTranslationTranslateEngToDeu**](LanguageTranslationApi.md#languagetranslationtranslateengtodeu) | **POST** /nlp-v2/translate/language/eng/to/deu | Translate English to German text with Deep Learning AI
[**LanguageTranslationTranslateEngToFra**](LanguageTranslationApi.md#languagetranslationtranslateengtofra) | **POST** /nlp-v2/translate/language/eng/to/fra | Translate English to French text with Deep Learning AI
[**LanguageTranslationTranslateEngToRus**](LanguageTranslationApi.md#languagetranslationtranslateengtorus) | **POST** /nlp-v2/translate/language/eng/to/rus | Translate English to Russian text with Deep Learning AI
[**LanguageTranslationTranslateFraToEng**](LanguageTranslationApi.md#languagetranslationtranslatefratoeng) | **POST** /nlp-v2/translate/language/fra/to/eng | Translate French to English text with Deep Learning AI
[**LanguageTranslationTranslateRusToEng**](LanguageTranslationApi.md#languagetranslationtranslaterustoeng) | **POST** /nlp-v2/translate/language/rus/to/eng | Translate Russian to English text with Deep Learning AI


<a name="languagetranslationtranslatedeutoeng"></a>
# **LanguageTranslationTranslateDeuToEng**
> LanguageTranslationResponse LanguageTranslationTranslateDeuToEng (LanguageTranslationRequest input)

Translate German to English text with Deep Learning AI

Automatically translates input text in German to output text in English using advanced Deep Learning and Neural NLP.  Consumes 1-2 API calls per input sentence.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.NLP.Api;
using Cloudmersive.APIClient.NET.NLP.Client;
using Cloudmersive.APIClient.NET.NLP.Model;

namespace Example
{
    public class LanguageTranslationTranslateDeuToEngExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new LanguageTranslationApi();
            var input = new LanguageTranslationRequest(); // LanguageTranslationRequest | Input translation request

            try
            {
                // Translate German to English text with Deep Learning AI
                LanguageTranslationResponse result = apiInstance.LanguageTranslationTranslateDeuToEng(input);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LanguageTranslationApi.LanguageTranslationTranslateDeuToEng: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **input** | [**LanguageTranslationRequest**](LanguageTranslationRequest.md)| Input translation request | 

### Return type

[**LanguageTranslationResponse**](LanguageTranslationResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="languagetranslationtranslateengtodeu"></a>
# **LanguageTranslationTranslateEngToDeu**
> LanguageTranslationResponse LanguageTranslationTranslateEngToDeu (LanguageTranslationRequest input)

Translate English to German text with Deep Learning AI

Automatically translates input text in English to output text in German using advanced Deep Learning and Neural NLP.  Consumes 1-2 API calls per input sentence.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.NLP.Api;
using Cloudmersive.APIClient.NET.NLP.Client;
using Cloudmersive.APIClient.NET.NLP.Model;

namespace Example
{
    public class LanguageTranslationTranslateEngToDeuExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new LanguageTranslationApi();
            var input = new LanguageTranslationRequest(); // LanguageTranslationRequest | Input translation request

            try
            {
                // Translate English to German text with Deep Learning AI
                LanguageTranslationResponse result = apiInstance.LanguageTranslationTranslateEngToDeu(input);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LanguageTranslationApi.LanguageTranslationTranslateEngToDeu: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **input** | [**LanguageTranslationRequest**](LanguageTranslationRequest.md)| Input translation request | 

### Return type

[**LanguageTranslationResponse**](LanguageTranslationResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="languagetranslationtranslateengtofra"></a>
# **LanguageTranslationTranslateEngToFra**
> LanguageTranslationResponse LanguageTranslationTranslateEngToFra (LanguageTranslationRequest input)

Translate English to French text with Deep Learning AI

Automatically translates input text in English to output text in French using advanced Deep Learning and Neural NLP.  Consumes 1-2 API calls per input sentence.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.NLP.Api;
using Cloudmersive.APIClient.NET.NLP.Client;
using Cloudmersive.APIClient.NET.NLP.Model;

namespace Example
{
    public class LanguageTranslationTranslateEngToFraExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new LanguageTranslationApi();
            var input = new LanguageTranslationRequest(); // LanguageTranslationRequest | Input translation request

            try
            {
                // Translate English to French text with Deep Learning AI
                LanguageTranslationResponse result = apiInstance.LanguageTranslationTranslateEngToFra(input);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LanguageTranslationApi.LanguageTranslationTranslateEngToFra: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **input** | [**LanguageTranslationRequest**](LanguageTranslationRequest.md)| Input translation request | 

### Return type

[**LanguageTranslationResponse**](LanguageTranslationResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="languagetranslationtranslateengtorus"></a>
# **LanguageTranslationTranslateEngToRus**
> LanguageTranslationResponse LanguageTranslationTranslateEngToRus (LanguageTranslationRequest input)

Translate English to Russian text with Deep Learning AI

Automatically translates input text in English to output text in Russian using advanced Deep Learning and Neural NLP.  Consumes 1-2 API calls per input sentence.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.NLP.Api;
using Cloudmersive.APIClient.NET.NLP.Client;
using Cloudmersive.APIClient.NET.NLP.Model;

namespace Example
{
    public class LanguageTranslationTranslateEngToRusExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new LanguageTranslationApi();
            var input = new LanguageTranslationRequest(); // LanguageTranslationRequest | Input translation request

            try
            {
                // Translate English to Russian text with Deep Learning AI
                LanguageTranslationResponse result = apiInstance.LanguageTranslationTranslateEngToRus(input);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LanguageTranslationApi.LanguageTranslationTranslateEngToRus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **input** | [**LanguageTranslationRequest**](LanguageTranslationRequest.md)| Input translation request | 

### Return type

[**LanguageTranslationResponse**](LanguageTranslationResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="languagetranslationtranslatefratoeng"></a>
# **LanguageTranslationTranslateFraToEng**
> LanguageTranslationResponse LanguageTranslationTranslateFraToEng (LanguageTranslationRequest input)

Translate French to English text with Deep Learning AI

Automatically translates input text in French to output text in English using advanced Deep Learning and Neural NLP.  Consumes 1-2 API calls per input sentence.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.NLP.Api;
using Cloudmersive.APIClient.NET.NLP.Client;
using Cloudmersive.APIClient.NET.NLP.Model;

namespace Example
{
    public class LanguageTranslationTranslateFraToEngExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new LanguageTranslationApi();
            var input = new LanguageTranslationRequest(); // LanguageTranslationRequest | Input translation request

            try
            {
                // Translate French to English text with Deep Learning AI
                LanguageTranslationResponse result = apiInstance.LanguageTranslationTranslateFraToEng(input);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LanguageTranslationApi.LanguageTranslationTranslateFraToEng: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **input** | [**LanguageTranslationRequest**](LanguageTranslationRequest.md)| Input translation request | 

### Return type

[**LanguageTranslationResponse**](LanguageTranslationResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="languagetranslationtranslaterustoeng"></a>
# **LanguageTranslationTranslateRusToEng**
> LanguageTranslationResponse LanguageTranslationTranslateRusToEng (LanguageTranslationRequest input)

Translate Russian to English text with Deep Learning AI

Automatically translates input text in Russian to output text in English using advanced Deep Learning and Neural NLP.  Consumes 1-2 API calls per input sentence.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.NLP.Api;
using Cloudmersive.APIClient.NET.NLP.Client;
using Cloudmersive.APIClient.NET.NLP.Model;

namespace Example
{
    public class LanguageTranslationTranslateRusToEngExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new LanguageTranslationApi();
            var input = new LanguageTranslationRequest(); // LanguageTranslationRequest | Input translation request

            try
            {
                // Translate Russian to English text with Deep Learning AI
                LanguageTranslationResponse result = apiInstance.LanguageTranslationTranslateRusToEng(input);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LanguageTranslationApi.LanguageTranslationTranslateRusToEng: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **input** | [**LanguageTranslationRequest**](LanguageTranslationRequest.md)| Input translation request | 

### Return type

[**LanguageTranslationResponse**](LanguageTranslationResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

