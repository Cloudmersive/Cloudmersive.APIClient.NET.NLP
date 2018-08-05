﻿Remove-Item –path ./client –recurse
& java -jar swagger-codegen-cli.jar generate -i https://api.cloudmersive.com/swagger/api/nlp -l csharp -o client -c packageconfig.json
#(Get-Content ./client/src/api/ConvertDocumentApi.js).replace('var returnType = Object;', "var returnType = 'Blob';") | Set-Content ./client/src/api/ConvertDocumentApi.js
#(Get-Content ./client/src/api/ConvertWebApi.js).replace('var returnType = Object;', "var returnType = 'Blob';") | Set-Content ./client/src/api/ConvertWebApi.js
#& npm build ./client









$csprojpath = Resolve-Path ./client/src/Cloudmersive.APIClient.NET.NLP/Cloudmersive.APIClient.NET.NLP.csproj
$csprojtestpath = Resolve-Path ./client/src/Cloudmersive.APIClient.NET.NLP.Test/Cloudmersive.APIClient.NET.NLP.Test.csproj
$nuspecpath = Resolve-Path ./client/src/Cloudmersive.APIClient.NET.NLP/Cloudmersive.APIClient.NET.NLP.nuspec
$slnpath = Resolve-Path ./client/Cloudmersive.APIClient.NET.NLP.sln


(Get-Content $nuspecpath).replace('<title>Swagger Library</title>', "<title>Cloudmersive NLP API Client</title>") | Set-Content $nuspecpath
(Get-Content $nuspecpath).replace('<authors>$author$</authors>', "<authors>Cloudmersive</authors>") | Set-Content $nuspecpath
(Get-Content $nuspecpath).replace('<owners>$author$</owners>', "<owners>Cloudmersive</owners>") | Set-Content $nuspecpath
(Get-Content $nuspecpath).replace('<description>A library generated from a Swagger doc</description>', "<description>The powerful Natural Language Processing APIs let you perform part of speech tagging, entity identification, sentence parsing, and much more to help you understand the meaning of unstructured text.</description>") | Set-Content $nuspecpath
(Get-Content $nuspecpath).replace('<!-- Authors contain text that appears directly on the gallery -->', "<iconUrl>https://cloudmersive.com/images/cmsdk.png</iconUrl>") | Set-Content $nuspecpath







./nuget.exe restore $csprojpath -SolutionDirectory ./client

./nuget.exe restore $csprojtestpath -SolutionDirectory ./client

C:\Windows\Microsoft.NET\Framework\v4.0.30319\msbuild.exe $slnpath /t:rebuild 

./nuget.exe pack $csprojpath