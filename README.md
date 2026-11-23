# HelloWorld

Simple .NET console app (Hello World) with Azure DevOps pipeline.
Code is on GitHub, pipeline runs on Azure clean machine (ubuntu-latest).

- main and feature branches: build, print version, upload to Azure Artifacts
- feature branch only: unit tests, SonarQube scan, NuGet package `<branch>_<version>` uploaded to Artifacts, build tag
- email with pipeline status after every run

## Project structure

```
HelloWorld/
├── HelloWorld.Tests/
│   ├── GreeterTests.cs          # xUnit test for Greeter
│   └── HelloWorld.Tests.csproj
├── Greeter.cs                   # app logic
├── Program.cs                   # prints greeting and version
├── HelloWorld.csproj
└── azure-pipelines.yml          # pipeline
```
