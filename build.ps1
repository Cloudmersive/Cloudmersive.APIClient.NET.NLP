Remove-Item –path ./client –recurse
& java -jar swagger-codegen-cli-2.4.5.jar generate -i https://api.cloudmersive.com/swagger/api/nlp -l csharp -o client -c packageconfig.json
#(Get-Content ./client/src/api/ConvertDocumentApi.js).replace('var returnType = Object;', "var returnType = 'Blob';") | Set-Content ./client/src/api/ConvertDocumentApi.js
#(Get-Content ./client/src/api/ConvertWebApi.js).replace('var returnType = Object;', "var returnType = 'Blob';") | Set-Content ./client/src/api/ConvertWebApi.js
#& npm build ./client









$csprojpath = Resolve-Path ./client/src/Cloudmersive.APIClient.NET.NLP/Cloudmersive.APIClient.NET.NLP.csproj
$csprojtestpath = Resolve-Path ./client/src/Cloudmersive.APIClient.NET.NLP.Test/Cloudmersive.APIClient.NET.NLP.Test.csproj
$nuspecpath = Resolve-Path ./client/src/Cloudmersive.APIClient.NET.NLP/Cloudmersive.APIClient.NET.NLP.nuspec
$slnpath = Resolve-Path ./client/Cloudmersive.APIClient.NET.NLP.sln


(Get-Content $nuspecpath).replace('<title>Swagger Library</title>', "<title>Cloudmersive NLP API Client</title><licenseUrl>https://www.apache.org/licenses/LICENSE-2.0.txt</licenseUrl>") | Set-Content $nuspecpath
(Get-Content $nuspecpath).replace('<authors>$author$</authors>', "<authors>Cloudmersive</authors>") | Set-Content $nuspecpath
(Get-Content $nuspecpath).replace('<owners>$author$</owners>', "<owners>Cloudmersive</owners>") | Set-Content $nuspecpath
(Get-Content $nuspecpath).replace('<description>A library generated from a Swagger doc</description>', "<description>The powerful Natural Language Processing APIs let you perform part of speech tagging, entity identification, sentence parsing, and much more to help you understand the meaning of unstructured text.</description>") | Set-Content $nuspecpath
(Get-Content $nuspecpath).replace('<!-- Authors contain text that appears directly on the gallery -->', "<iconUrl>https://cloudmersive.com/images/cmsdk.png</iconUrl>") | Set-Content $nuspecpath
(Get-Content $nuspecpath).replace('<dependencies>', "<projectUrl>https://cloudmersive.com/nlp-api</projectUrl><dependencies>") | Set-Content $nuspecpath

# RestSharp 106.6.10 - Core Project
(Get-Content '.\client\src\Cloudmersive.APIClient.NET.NLP\Cloudmersive.APIClient.NET.NLP.csproj').replace('<PackageReference Include="RestSharp" Version="105.1.0" />', '<PackageReference Include="RestSharp" Version="106.6.10" />') | Set-Content '.\client\src\Cloudmersive.APIClient.NET.NLP\Cloudmersive.APIClient.NET.NLP.csproj'

(Get-Content $nuspecpath).replace('<dependency id="RestSharp" version="105.1.0" />', '<dependency id="RestSharp" version="106.6.10" />') | Set-Content $nuspecpath

(Get-Content '.\client\src\Cloudmersive.APIClient.NET.NLP\Cloudmersive.APIClient.NET.NLP.csproj').replace('<TargetFrameworkVersion>v4.5</TargetFrameworkVersion>', '<TargetFrameworkVersion>v4.5.2</TargetFrameworkVersion>') | Set-Content '.\client\src\Cloudmersive.APIClient.NET.NLP\Cloudmersive.APIClient.NET.NLP.csproj'
(Get-Content '.\client\src\Cloudmersive.APIClient.NET.NLP\Cloudmersive.APIClient.NET.NLP.csproj').replace('<Reference Include="RestSharp">', '<Reference Include="RestSharp, Version=106.6.10.0, Culture=neutral, PublicKeyToken=598062e77f915f75, processorArchitecture=MSIL">') | Set-Content '.\client\src\Cloudmersive.APIClient.NET.NLP\Cloudmersive.APIClient.NET.NLP.csproj'

(Get-Content '.\client\src\Cloudmersive.APIClient.NET.NLP\Cloudmersive.APIClient.NET.NLP.csproj').replace('$(SolutionDir)\packages\RestSharp.105.1.0\lib\net45\RestSharp.dll', '$(SolutionDir)\packages\RestSharp.106.6.10\lib\net452\RestSharp.dll') | Set-Content '.\client\src\Cloudmersive.APIClient.NET.NLP\Cloudmersive.APIClient.NET.NLP.csproj'
(Get-Content '.\client\src\Cloudmersive.APIClient.NET.NLP\Cloudmersive.APIClient.NET.NLP.csproj').replace('..\packages\RestSharp.105.1.0\lib\net45\RestSharp.dll', '..\packages\RestSharp.106.6.10\lib\net452\RestSharp.dll') | Set-Content '.\client\src\Cloudmersive.APIClient.NET.NLP\Cloudmersive.APIClient.NET.NLP.csproj'
(Get-Content '.\client\src\Cloudmersive.APIClient.NET.NLP\Cloudmersive.APIClient.NET.NLP.csproj').replace('..\..\packages\RestSharp.105.1.0\lib\net45\RestSharp.dll', '..\..\packages\RestSharp.106.6.10\lib\net452\RestSharp.dll') | Set-Content '.\client\src\Cloudmersive.APIClient.NET.NLP\Cloudmersive.APIClient.NET.NLP.csproj'
(Get-Content '.\client\src\Cloudmersive.APIClient.NET.NLP\Cloudmersive.APIClient.NET.NLP.csproj').replace('..\..\vendor\RestSharp.105.1.0\lib\net45\RestSharp.dll', '..\..\vendor\RestSharp.106.6.10\lib\net452\RestSharp.dll') | Set-Content '.\client\src\Cloudmersive.APIClient.NET.NLP\Cloudmersive.APIClient.NET.NLP.csproj'

# RestSharp 106.6.10 - Test Project
(Get-Content $csprojtestpath).replace('<PackageReference Include="RestSharp" Version="105.1.0" />', '<PackageReference Include="RestSharp" Version="106.6.10" />') | Set-Content $csprojtestpath

(Get-Content $csprojtestpath).replace('<TargetFrameworkVersion>v4.5</TargetFrameworkVersion>', '<TargetFrameworkVersion>v4.5.2</TargetFrameworkVersion>') | Set-Content $csprojtestpath
(Get-Content $csprojtestpath).replace('<Reference Include="RestSharp">', '<Reference Include="RestSharp, Version=106.6.10.0, Culture=neutral, PublicKeyToken=598062e77f915f75, processorArchitecture=MSIL">') | Set-Content $csprojtestpath

(Get-Content $csprojtestpath).replace('$(SolutionDir)\packages\RestSharp.105.1.0\lib\net45\RestSharp.dll', '$(SolutionDir)\packages\RestSharp.106.6.10\lib\net452\RestSharp.dll') | Set-Content $csprojtestpath
(Get-Content $csprojtestpath).replace('..\packages\RestSharp.105.1.0\lib\net45\RestSharp.dll', '..\packages\RestSharp.106.6.10\lib\net452\RestSharp.dll') | Set-Content $csprojtestpath
(Get-Content $csprojtestpath).replace('..\..\packages\RestSharp.105.1.0\lib\net45\RestSharp.dll', '..\..\packages\RestSharp.106.6.10\lib\net452\RestSharp.dll') | Set-Content $csprojtestpath
(Get-Content $csprojtestpath).replace('..\..\vendor\RestSharp.105.1.0\lib\net45\RestSharp.dll', '..\..\vendor\RestSharp.106.6.10\lib\net452\RestSharp.dll') | Set-Content $csprojtestpath


# Packages.config

(Get-Content '.\client\src\Cloudmersive.APIClient.NET.NLP\packages.config').replace('<package id="RestSharp" version="105.1.0" targetFramework="net45" developmentDependency="true" />', '<package id="RestSharp" version="106.6.10" targetFramework="net45" developmentDependency="true" />') | Set-Content '.\client\src\Cloudmersive.APIClient.NET.NLP\packages.config'
(Get-Content '.\client\src\Cloudmersive.APIClient.NET.NLP\Client\ApiClient.cs').replace('request.AddFile(param.Value.Name, param.Value.Writer, param.Value.FileName, param.Value.ContentType);', 'request.AddFile(param.Value.Name, param.Value.Writer, param.Value.FileName, param.Value.ContentLength, param.Value.ContentType);') | Set-Content '.\client\src\Cloudmersive.APIClient.NET.NLP\Client\ApiClient.cs'





./nuget.exe restore $csprojpath -SolutionDirectory ./client

./nuget.exe restore $csprojtestpath -SolutionDirectory ./client

C:\Windows\Microsoft.NET\Framework\v4.0.30319\msbuild.exe $slnpath /t:rebuild 

./nuget.exe pack $csprojpath

(Get-Content ./client/README.md).replace(' automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project', " for the [Cloudmersive Natural Language Processing API](https://www.cloudmersive.com/nlp-api)") | Set-Content ./client/README.md

Copy-Item ./client/README.md ./README.md