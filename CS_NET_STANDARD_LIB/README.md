
# Getting Started with Tester

## Introduction

Testing various
api
features

## Building

The generated code uses the Newtonsoft Json.NET NuGet Package. If the automatic NuGet package restore is enabled, these dependencies will be installed automatically. Therefore, you will need internet access for build.

* Open the solution (Tester.sln) file.

Invoke the build process using Ctrl + Shift + B shortcut key or using the Build menu as shown below.

The build process generates a portable class library, which can be used like a normal class library. The generated library is compatible with Windows Forms, Windows RT, Windows Phone 8, Silverlight 5, Xamarin iOS, Xamarin Android and Mono. More information on how to use can be found at the MSDN Portable Class Libraries documentation.

## Installation

The following section explains how to use the Tester.Standard library in a new project.

### 1. Starting a new project

For starting a new project, right click on the current solution from the solution explorer and choose `Add -> New Project`.

![Add a new project in Visual Studio](https://apidocs.io/illustration/cs?workspaceFolder=Tester-CSharp&workspaceName=Tester&projectName=Tester.Standard&rootNamespace=Tester.Standard&step=addProject)

Next, choose `Console Application`, provide `TestConsoleProject` as the project name and click OK.

![Create a new Console Application in Visual Studio](https://apidocs.io/illustration/cs?workspaceFolder=Tester-CSharp&workspaceName=Tester&projectName=Tester.Standard&rootNamespace=Tester.Standard&step=createProject)

### 2. Set as startup project

The new console project is the entry point for the eventual execution. This requires us to set the `TestConsoleProject` as the start-up project. To do this, right-click on the `TestConsoleProject` and choose `Set as StartUp Project` form the context menu.

![Adding a project reference](https://apidocs.io/illustration/cs?workspaceFolder=Tester-CSharp&workspaceName=Tester&projectName=Tester.Standard&rootNamespace=Tester.Standard&step=setStartup)

### 3. Add reference of the library project

In order to use the Tester library in the new project, first we must add a project reference to the `TestConsoleProject`. First, right click on the `References` node in the solution explorer and click `Add Reference...`

![Adding a project reference](https://apidocs.io/illustration/cs?workspaceFolder=Tester-CSharp&workspaceName=Tester&projectName=Tester.Standard&rootNamespace=Tester.Standard&step=addReference)

Next, a window will be displayed where we must set the `checkbox` on `Tester.Tests` and click `OK`. By doing this, we have added a reference of the `Tester.Tests` project into the new `TestConsoleProject`.

![Creating a project reference](https://apidocs.io/illustration/cs?workspaceFolder=Tester-CSharp&workspaceName=Tester&projectName=Tester.Standard&rootNamespace=Tester.Standard&step=createReference)

### 4. Write sample code

Once the `TestConsoleProject` is created, a file named `Program.cs` will be visible in the solution explorer with an empty `Main` method. This is the entry point for the execution of the entire solution. Here, you can add code to initialize the client library and acquire the instance of a Controller class. Sample code to initialize the client library and using Controller methods is given in the subsequent sections.

![Adding a project reference](https://apidocs.io/illustration/cs?workspaceFolder=Tester-CSharp&workspaceName=Tester&projectName=Tester.Standard&rootNamespace=Tester.Standard&step=addCode)

## Test the SDK

The generated SDK also contain one or more Tests, which are contained in the Tests project. In order to invoke these test cases, you will need `NUnit 3.0 Test Adapter Extension` for Visual Studio. Once the SDK is complied, the test cases should appear in the Test Explorer window. Here, you can click `Run All` to execute these test cases.

## Initialize the API Client

**_Note:_** Documentation for the client can be found [here.](/doc/client.md)

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| `Port` | `string` | *Default*: `"80"` |
| `Suites` | `Models.SuiteCode` | *Default*: `SuiteCode.Hearts` |
| `Environment` | Environment | The API environment. <br> **Default: `Environment.Testing`** |
| `Timeout` | `TimeSpan` | Http client timeout.<br>*Default*: `TimeSpan.FromSeconds(100)` |

The API client can be initialized as follows:

```csharp
Tester.Standard.TesterClient client = new Tester.Standard.TesterClient.Builder()
    .Environment(Environment.Testing)
    .Port("80")
    .Suites(SuiteCode.Hearts)
    .HttpClientConfig(config => config.NumberOfRetries(3))
    .Build();
```

## Environments

The SDK can be configured to use a different environment for making API calls. Available environments are:

### Fields

| Name | Description |
|  --- | --- |
| production | - |
| testing | **Default** |

## API Errors

Here is the list of errors that the API might throw.

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | 400 Global | `ApiException` |
| 402 | 402 Global | `ApiException` |
| 403 | 403 Global | `ApiException` |
| 404 | 404 Global | `ApiException` |
| 412 | Precondition Failed | [`NestedModelException`](/doc/models/nested-model-exception.md) |
| 450 | caught global exception | [`CustomErrorResponseException`](/doc/models/custom-error-response-exception.md) |
| 452 | global exception with string | [`ExceptionWithStringException`](/doc/models/exception-with-string-exception.md) |
| 453 | boolean in global exception | [`ExceptionWithBooleanException`](/doc/models/exception-with-boolean-exception.md) |
| 454 | dynamic in global exception | [`ExceptionWithDynamicException`](/doc/models/exception-with-dynamic-exception.md) |
| 455 | uuid in global exception | [`ExceptionWithUUIDException`](/doc/models/exception-with-uuid-exception.md) |
| 456 | date in global exception | [`ExceptionWithDateException`](/doc/models/exception-with-date-exception.md) |
| 457 | number in global  exception | [`ExceptionWithNumberException`](/doc/models/exception-with-number-exception.md) |
| 458 | long in global exception | [`ExceptionWithLongException`](/doc/models/exception-with-long-exception.md) |
| 459 | precision in global  exception | [`ExceptionWithPrecisionException`](/doc/models/exception-with-precision-exception.md) |
| 460 | rfc3339 in global exception | [`ExceptionWithRfc3339DateTimeException`](/doc/models/exception-with-rfc-3339-date-time-exception.md) |
| 461 | unix time stamp in global exception | [`UnixTimeStampException`](/doc/models/unix-time-stamp-exception.md) |
| 462 | rfc1123 in global exception | [`Rfc1123Exception`](/doc/models/rfc-1123-exception.md) |
| 463 | boolean in model as global exception | [`SendBooleanInModelAsException`](/doc/models/send-boolean-in-model-as-exception.md) |
| 464 | rfc3339 in model as global exception | [`SendRfc3339InModelAsException`](/doc/models/send-rfc-3339-in-model-as-exception.md) |
| 465 | rfc1123 in model as global exception | [`SendRfc1123InModelAsException`](/doc/models/send-rfc-1123-in-model-as-exception.md) |
| 466 | unix time stamp in model as global exception | [`SendUnixTimeStampInModelAsException`](/doc/models/send-unix-time-stamp-in-model-as-exception.md) |
| 467 | send date in model as global exception | [`SendDateInModelAsException`](/doc/models/send-date-in-model-as-exception.md) |
| 468 | send dynamic in model as global exception | [`SendDynamicInModelAsException`](/doc/models/send-dynamic-in-model-as-exception.md) |
| 469 | send string in model as global exception | [`SendStringInModelAsException`](/doc/models/send-string-in-model-as-exception.md) |
| 470 | send long in model as global exception | [`SendLongInModelAsException`](/doc/models/send-long-in-model-as-exception.md) |
| 471 | send number in model as global exception | [`SendNumberInModelAsException`](/doc/models/send-number-in-model-as-exception.md) |
| 472 | send precision in model as global exception | [`SendPrecisionInModelAsException`](/doc/models/send-precision-in-model-as-exception.md) |
| 473 | send uuid in model as global exception | [`SendUuidInModelAsException`](/doc/models/send-uuid-in-model-as-exception.md) |
| 500 | 500 Global | [`GlobalTestException`](/doc/models/global-test-exception.md) |
| Default | Invalid response. | [`GlobalTestException`](/doc/models/global-test-exception.md) |

## List of APIs

* [Response Types](/doc/controllers/response-types.md)
* [Form Params](/doc/controllers/form-params.md)
* [Body Params](/doc/controllers/body-params.md)
* [Error Codes](/doc/controllers/error-codes.md)
* [Query Param](/doc/controllers/query-param.md)
* [Echo](/doc/controllers/echo.md)
* [Header](/doc/controllers/header.md)
* [Template Params](/doc/controllers/template-params.md)
* [Query Params](/doc/controllers/query-params.md)

## Classes Documentation

* [Utility Classes](/doc/utility-classes.md)
* [HttpRequest](/doc/http-request.md)
* [HttpResponse](/doc/http-response.md)
* [HttpStringResponse](/doc/http-string-response.md)
* [HttpContext](/doc/http-context.md)
* [HttpClientConfiguration](/doc/http-client-configuration.md)
* [HttpClientConfiguration Builder](/doc/http-client-configuration-builder.md)
* [IAuthManager](/doc/i-auth-manager.md)
* [ApiException](/doc/api-exception.md)

