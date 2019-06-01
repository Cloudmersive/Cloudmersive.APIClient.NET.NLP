# Cloudmersive.APIClient.NET.NLP - the C# library for the nlpapi

The powerful Natural Language Processing APIs let you perform part of speech tagging, entity identification, sentence parsing, and much more to help you understand the meaning of unstructured text.

This C# SDK is for the [Cloudmersive Natural Language Processing API](https://www.cloudmersive.com/nlp-api):

- API version: v1
- SDK version: 1.2.4
- Build package: io.swagger.codegen.languages.CSharpClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet] (https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Cloudmersive.APIClient.NET.NLP.Api;
using Cloudmersive.APIClient.NET.NLP.Client;
using Cloudmersive.APIClient.NET.NLP.Model;
```
<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out Cloudmersive.APIClient.NET.NLP.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.NLP.Api;
using Cloudmersive.APIClient.NET.NLP.Client;
using Cloudmersive.APIClient.NET.NLP.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {

            // Configure API key authorization: Apikey
            Configuration.Default.ApiKey.Add("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Apikey", "Bearer");

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

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.cloudmersive.com*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*ExtractEntitiesStringApi* | [**ExtractEntitiesStringPost**](docs/ExtractEntitiesStringApi.md#extractentitiesstringpost) | **POST** /nlp/ExtractEntitiesString | Extract entities from string
*LanguageDetectionApi* | [**LanguageDetectionPost**](docs/LanguageDetectionApi.md#languagedetectionpost) | **POST** /nlp/language/detect | Detect language of text
*ParseStringApi* | [**ParseStringPost**](docs/ParseStringApi.md#parsestringpost) | **POST** /nlp/ParseString | Parse string to syntax tree
*PosTaggerJsonApi* | [**PosTaggerJsonPost**](docs/PosTaggerJsonApi.md#postaggerjsonpost) | **POST** /nlp/PosTaggerJson | Part-of-speech tag a string
*PosTaggerStringApi* | [**PosTaggerStringPost**](docs/PosTaggerStringApi.md#postaggerstringpost) | **POST** /nlp/PosTaggerString | Part-of-speech tag a string
*SentencesApi* | [**SentencesPost**](docs/SentencesApi.md#sentencespost) | **POST** /nlp/get/sentences/string | Extract sentences from string
*SpellCheckApi* | [**SpellCheckCheckJson**](docs/SpellCheckApi.md#spellcheckcheckjson) | **POST** /nlp/spellcheck/check/word/json | Spell check word
*SpellCheckApi* | [**SpellCheckCheckSentenceJson**](docs/SpellCheckApi.md#spellcheckchecksentencejson) | **POST** /nlp/spellcheck/check/sentence/json | Check if sentence is spelled correctly
*SpellCheckApi* | [**SpellCheckCheckSentenceString**](docs/SpellCheckApi.md#spellcheckchecksentencestring) | **POST** /nlp/spellcheck/check/sentence/string | Spell check a sentence
*SpellCheckApi* | [**SpellCheckCorrect**](docs/SpellCheckApi.md#spellcheckcorrect) | **POST** /nlp/spellcheck/correct/word/string | Find spelling corrections
*SpellCheckApi* | [**SpellCheckCorrectJson**](docs/SpellCheckApi.md#spellcheckcorrectjson) | **POST** /nlp/spellcheck/correct/word/json | Find spelling corrections
*SpellCheckApi* | [**SpellCheckPost**](docs/SpellCheckApi.md#spellcheckpost) | **POST** /nlp/spellcheck/check/word/string | Spell check a word
*WordsApi* | [**WordsAdjectives**](docs/WordsApi.md#wordsadjectives) | **POST** /nlp/get/words/adjectives/string | Get adjectives in string
*WordsApi* | [**WordsAdverbs**](docs/WordsApi.md#wordsadverbs) | **POST** /nlp/get/words/adverbs/string | Get adverbs in input string
*WordsApi* | [**WordsGetWordsJson**](docs/WordsApi.md#wordsgetwordsjson) | **POST** /nlp/get/words/json | Get words in input string (JSON)
*WordsApi* | [**WordsGetWordsString**](docs/WordsApi.md#wordsgetwordsstring) | **POST** /nlp/get/words/string | Get words from string
*WordsApi* | [**WordsNouns**](docs/WordsApi.md#wordsnouns) | **POST** /nlp/get/words/nouns/string | Get nouns in string
*WordsApi* | [**WordsPost**](docs/WordsApi.md#wordspost) | **POST** /nlp/get/words/verbs/string | Get the verbs in a string
*WordsApi* | [**WordsPronouns**](docs/WordsApi.md#wordspronouns) | **POST** /nlp/get/words/pronouns/string | Returns all pronounts in string
*WordsApi* | [**WordsProperNouns**](docs/WordsApi.md#wordspropernouns) | **POST** /nlp/get/words/properNouns/string | Get proper nouns in a string


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.CheckJsonResponse](docs/CheckJsonResponse.md)
 - [Model.CheckSentenceJsonResponse](docs/CheckSentenceJsonResponse.md)
 - [Model.CorrectJsonResponse](docs/CorrectJsonResponse.md)
 - [Model.CorrectWordInSentenceJsonResponse](docs/CorrectWordInSentenceJsonResponse.md)
 - [Model.GetWordsJsonResponse](docs/GetWordsJsonResponse.md)
 - [Model.LanguageDetectionResponse](docs/LanguageDetectionResponse.md)
 - [Model.PosRequest](docs/PosRequest.md)
 - [Model.PosResponse](docs/PosResponse.md)
 - [Model.PosSentence](docs/PosSentence.md)
 - [Model.PosTaggedWord](docs/PosTaggedWord.md)
 - [Model.WordPosition](docs/WordPosition.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="Apikey"></a>
### Apikey

- **Type**: API key
- **API key parameter name**: Apikey
- **Location**: HTTP header
