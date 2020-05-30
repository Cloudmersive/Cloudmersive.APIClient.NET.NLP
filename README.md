# Cloudmersive.APIClient.NET.NLP - the C# library for the nlpapiv2

The powerful Natural Language Processing APIs (v2) let you perform part of speech tagging, entity identification, sentence parsing, and much more to help you understand the meaning of unstructured text.

This C# SDK is for the [Cloudmersive Natural Language Processing API](https://www.cloudmersive.com/nlp-api):

- API version: v1
- SDK version: 4.0.9
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

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
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

            var apiInstance = new AnalyticsApi();
            var input = new HateSpeechAnalysisRequest(); // HateSpeechAnalysisRequest | Input hate speech analysis request

            try
            {
                // Perform Hate Speech Analysis and Detection on Text
                HateSpeechAnalysisResponse result = apiInstance.AnalyticsHateSpeech(input);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.AnalyticsHateSpeech: " + e.Message );
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
*AnalyticsApi* | [**AnalyticsHateSpeech**](docs/AnalyticsApi.md#analyticshatespeech) | **POST** /nlp-v2/analytics/hate-speech | Perform Hate Speech Analysis and Detection on Text
*AnalyticsApi* | [**AnalyticsProfanity**](docs/AnalyticsApi.md#analyticsprofanity) | **POST** /nlp-v2/analytics/profanity | Perform Profanity and Obscene Language Analysis and Detection on Text
*AnalyticsApi* | [**AnalyticsSentiment**](docs/AnalyticsApi.md#analyticssentiment) | **POST** /nlp-v2/analytics/sentiment | Perform Sentiment Analysis and Classification on Text
*AnalyticsApi* | [**AnalyticsSimilarity**](docs/AnalyticsApi.md#analyticssimilarity) | **POST** /nlp-v2/analytics/similarity | Perform Semantic Similarity Comparison of Two Strings
*AnalyticsApi* | [**AnalyticsSubjectivity**](docs/AnalyticsApi.md#analyticssubjectivity) | **POST** /nlp-v2/analytics/subjectivity | Perform Subjectivity and Objectivity Analysis on Text
*ExtractEntitiesApi* | [**ExtractEntitiesPost**](docs/ExtractEntitiesApi.md#extractentitiespost) | **POST** /nlp-v2/extract-entities | Extract entities from string
*LanguageDetectionApi* | [**LanguageDetectionGetLanguage**](docs/LanguageDetectionApi.md#languagedetectiongetlanguage) | **POST** /nlp-v2/language/detect | Detect language of text
*LanguageTranslationApi* | [**LanguageTranslationTranslateDeuToEng**](docs/LanguageTranslationApi.md#languagetranslationtranslatedeutoeng) | **POST** /nlp-v2/translate/language/deu/to/eng | Translate German to English text with Deep Learning AI
*LanguageTranslationApi* | [**LanguageTranslationTranslateEngToDeu**](docs/LanguageTranslationApi.md#languagetranslationtranslateengtodeu) | **POST** /nlp-v2/translate/language/eng/to/deu | Translate English to German text with Deep Learning AI
*LanguageTranslationApi* | [**LanguageTranslationTranslateEngToRus**](docs/LanguageTranslationApi.md#languagetranslationtranslateengtorus) | **POST** /nlp-v2/translate/language/eng/to/rus | Translate English to Russian text with Deep Learning AI
*LanguageTranslationApi* | [**LanguageTranslationTranslateRusToEng**](docs/LanguageTranslationApi.md#languagetranslationtranslaterustoeng) | **POST** /nlp-v2/translate/language/rus/to/eng | Translate Russian to English text with Deep Learning AI
*ParseApi* | [**ParseParseString**](docs/ParseApi.md#parseparsestring) | **POST** /nlp-v2/parse/tree | Parse string to syntax tree
*PosTaggerApi* | [**PosTaggerTagAdjectives**](docs/PosTaggerApi.md#postaggertagadjectives) | **POST** /nlp-v2/pos/tag/adjectives | Part-of-speech tag a string, filter to adjectives
*PosTaggerApi* | [**PosTaggerTagAdverbs**](docs/PosTaggerApi.md#postaggertagadverbs) | **POST** /nlp-v2/pos/tag/adverbs | Part-of-speech tag a string, filter to adverbs
*PosTaggerApi* | [**PosTaggerTagNouns**](docs/PosTaggerApi.md#postaggertagnouns) | **POST** /nlp-v2/pos/tag/nouns | Part-of-speech tag a string, filter to nouns
*PosTaggerApi* | [**PosTaggerTagPronouns**](docs/PosTaggerApi.md#postaggertagpronouns) | **POST** /nlp-v2/pos/tag/pronouns | Part-of-speech tag a string, filter to pronouns
*PosTaggerApi* | [**PosTaggerTagSentence**](docs/PosTaggerApi.md#postaggertagsentence) | **POST** /nlp-v2/pos/tag/sentence | Part-of-speech tag a string
*PosTaggerApi* | [**PosTaggerTagVerbs**](docs/PosTaggerApi.md#postaggertagverbs) | **POST** /nlp-v2/pos/tag/verbs | Part-of-speech tag a string, filter to verbs
*RephraseApi* | [**RephraseEnglishRephraseSentenceBySentence**](docs/RephraseApi.md#rephraseenglishrephrasesentencebysentence) | **POST** /nlp-v2/rephrase/rephrase/eng/by-sentence | Rephrase, paraphrase English text sentence-by-sentence using Deep Learning AI
*SegmentationApi* | [**SegmentationGetSentences**](docs/SegmentationApi.md#segmentationgetsentences) | **POST** /nlp-v2/segmentation/sentences | Extract sentences from string
*SegmentationApi* | [**SegmentationGetWords**](docs/SegmentationApi.md#segmentationgetwords) | **POST** /nlp-v2/segmentation/words | Get words in input string
*SpellcheckApi* | [**SpellcheckCheckSentence**](docs/SpellcheckApi.md#spellcheckchecksentence) | **POST** /nlp-v2/spellcheck/check/sentence | Check if sentence is spelled correctly
*SpellcheckApi* | [**SpellcheckCorrectJson**](docs/SpellcheckApi.md#spellcheckcorrectjson) | **POST** /nlp-v2/spellcheck/check/word | Find spelling corrections


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.CheckSentenceRequest](docs/CheckSentenceRequest.md)
 - [Model.CheckSentenceResponse](docs/CheckSentenceResponse.md)
 - [Model.CheckWordRequest](docs/CheckWordRequest.md)
 - [Model.CheckWordResponse](docs/CheckWordResponse.md)
 - [Model.CorrectWordInSentence](docs/CorrectWordInSentence.md)
 - [Model.Entity](docs/Entity.md)
 - [Model.ExtractEntitiesRequest](docs/ExtractEntitiesRequest.md)
 - [Model.ExtractEntitiesResponse](docs/ExtractEntitiesResponse.md)
 - [Model.GetWordsRequest](docs/GetWordsRequest.md)
 - [Model.GetWordsResponse](docs/GetWordsResponse.md)
 - [Model.HateSpeechAnalysisRequest](docs/HateSpeechAnalysisRequest.md)
 - [Model.HateSpeechAnalysisResponse](docs/HateSpeechAnalysisResponse.md)
 - [Model.LanguageDetectionRequest](docs/LanguageDetectionRequest.md)
 - [Model.LanguageDetectionResponse](docs/LanguageDetectionResponse.md)
 - [Model.LanguageTranslationRequest](docs/LanguageTranslationRequest.md)
 - [Model.LanguageTranslationResponse](docs/LanguageTranslationResponse.md)
 - [Model.ParseRequest](docs/ParseRequest.md)
 - [Model.ParseResponse](docs/ParseResponse.md)
 - [Model.PosRequest](docs/PosRequest.md)
 - [Model.PosResponse](docs/PosResponse.md)
 - [Model.PosSentence](docs/PosSentence.md)
 - [Model.PosTaggedWord](docs/PosTaggedWord.md)
 - [Model.ProfanityAnalysisRequest](docs/ProfanityAnalysisRequest.md)
 - [Model.ProfanityAnalysisResponse](docs/ProfanityAnalysisResponse.md)
 - [Model.RephraseRequest](docs/RephraseRequest.md)
 - [Model.RephraseResponse](docs/RephraseResponse.md)
 - [Model.RephrasedSentence](docs/RephrasedSentence.md)
 - [Model.RephrasedSentenceOption](docs/RephrasedSentenceOption.md)
 - [Model.SentenceSegmentationRequest](docs/SentenceSegmentationRequest.md)
 - [Model.SentenceSegmentationResponse](docs/SentenceSegmentationResponse.md)
 - [Model.SentimentAnalysisRequest](docs/SentimentAnalysisRequest.md)
 - [Model.SentimentAnalysisResponse](docs/SentimentAnalysisResponse.md)
 - [Model.SimilarityAnalysisRequest](docs/SimilarityAnalysisRequest.md)
 - [Model.SimilarityAnalysisResponse](docs/SimilarityAnalysisResponse.md)
 - [Model.SubjectivityAnalysisRequest](docs/SubjectivityAnalysisRequest.md)
 - [Model.SubjectivityAnalysisResponse](docs/SubjectivityAnalysisResponse.md)
 - [Model.WordPosition](docs/WordPosition.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="Apikey"></a>
### Apikey

- **Type**: API key
- **API key parameter name**: Apikey
- **Location**: HTTP header

