# poc-codeQL

[![CodeQL Advanced](https://github.com/kaiwanyawit-chawankul/poc-codeQL/actions/workflows/codeql.yml/badge.svg)](https://github.com/kaiwanyawit-chawankul/poc-codeQL/actions/workflows/codeql.yml)

## Deteced Issues
https://github.com/kaiwanyawit-chawankul/poc-codeQL/security/code-scanning



## Learn about CodeQL
### Overview
 - https://codeql.github.com/docs/index.html
 - https://codeql.github.com/docs/codeql-overview/codeql-tools/

### Query

 - https://docs.github.com/en/code-security/code-scanning/creating-an-advanced-setup-for-code-scanning/customizing-your-advanced-setup-for-code-scanning#using-queries-in-ql-packs
 - https://docs.github.com/en/code-security/code-scanning/managing-your-code-scanning-configuration/csharp-built-in-queries
 - https://docs.github.com/en/code-security/code-scanning/managing-your-code-scanning-configuration/javascript-typescript-built-in-queries
 - https://codeql.github.com/docs/codeql-language-guides/codeql-for-csharp/
 - https://codeql.github.com/docs/codeql-language-guides/codeql-for-javascript/
 - https://codeql.github.com/docs/codeql-language-guides/customizing-library-models-for-csharp/
 - https://codeql.github.com/docs/codeql-language-guides/basic-query-for-csharp-code/



### Sample code & API

 - https://github.com/github/codeql/blob/main/csharp/ql/examples/snippets/method_call.ql
 - https://codeql.github.com/codeql-standard-libraries/csharp/
 - https://codeql.github.com/codeql-standard-libraries/csharp/semmle/code/csharp/Callable.qll/predicate.Callable$Callable$getCyclomaticComplexity.0.html
 - https://codeql.github.com/codeql-standard-libraries/search.html?addsearch=getcyclomaticcomplexity

### Prompt
CodeQL, can you give me scripts for csharp to cover area mentioned in https://learn.microsoft.com/en-us/visualstudio/code-quality/code-metrics-values?view=vs-2022
 - QL should have select in this format -> select something, "description"
 - use api from here as reference https://codeql.github.com/codeql-standard-libraries/csharp/semmle/code/csharp/

### References
 - https://docs.github.com/en/code-security/codeql-cli/getting-started-with-the-codeql-cli/about-the-codeql-cli#about-the-github-codeql-license
 - https://github.com/readme/guides/custom-codeql-queries
 - https://azurecodingarchitect.com/posts/ghas-starting-with-codeql/
 - https://blog.stackademic.com/unveiling-codeql-part-2-0-writing-codeql-queries-1f9656e6d66a

note:

https://github.com/SonarSource/sonar-custom-rules-examples?tab=readme-ov-file
https://github.com/SonarSource/sonar-dotnet/tree/master/analyzers/src/SonarAnalyzer.CSharp/Metrics


