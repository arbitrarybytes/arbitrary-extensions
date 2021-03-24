# Arbitrary Extensions

A .NET Standard 2.0 library consisting of a ton of very useful C# extension methods.

[![Build status](https://ci.appveyor.com/api/projects/status/5i2gmikvtr3fiyw9/branch/master?svg=true)](https://ci.appveyor.com/project/arbitrarybytes/arbitrary-extensions/branch/master) 
[![BCH compliance](https://bettercodehub.com/edge/badge/arbitrarybytes/arbitrary-extensions?branch=master)](https://bettercodehub.com/)
![Coverage](https://github.com/arbitrarybytes/arbitrary-extensions/blob/master/src/ArbitraryExtensions.Tests/coverage/reports/badge_combined.svg)

### Running Tests

Browse to the ArbitraryExtensions.Tests directory and execute the below command.

```batch
dotnet test /p:CollectCoverage=true "/p:CoverletOutputFormat=\"lcov,cobertura\"" /p:CoverletOutput=coverage/
```

### Generating Reports

Install the global report generator tool:

```batch

dotnet tool install -g dotnet-reportgenerator-globaltool
```


Generate the report:
```batch
reportgenerator "-reports:coverage/*.info" "-targetdir:coverage/reports" -reporttypes:HtmlInline;Badges -historydir:coverage/reports/history
```

To run test and generate code coverage report, a handy batch file is available:
```batch
coverage-gen.bat
```
