
# Client Class Documentation

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

## TesterClient Class

The gateway for the SDK. This class acts as a factory for the Controllers and also holds the configuration of the SDK.

### Controllers

| Name | Description |
|  --- | --- |
| ResponseTypesController | Gets ResponseTypesController controller. |
| FormParamsController | Gets FormParamsController controller. |
| BodyParamsController | Gets BodyParamsController controller. |
| ErrorCodesController | Gets ErrorCodesController controller. |
| QueryParamController | Gets QueryParamController controller. |
| EchoController | Gets EchoController controller. |
| HeaderController | Gets HeaderController controller. |
| TemplateParamsController | Gets TemplateParamsController controller. |
| QueryParamsController | Gets QueryParamsController controller. |

### Properties

| Name | Description | Type |
|  --- | --- | --- |
| HttpClientConfiguration | Gets the configuration of the Http Client associated with this client. | `IHttpClientConfiguration` |
| Timeout | Http client timeout. | `TimeSpan` |
| Environment | Current API environment. | `Environment` |
| Port | Port value. | `string` |
| Suites | Suites value. | `Models.SuiteCode` |

### Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `GetBaseUri(Server alias = Server.Default)` | Gets the URL for a particular alias in the current environment and appends it with template parameters. | `string` |
| `ToBuilder()` | Creates an object of the TesterClient using the values provided for the builder. | `Builder` |

## TesterClient Builder Class

Class to build instances of TesterClient.

### Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `HttpClientConfiguration(Action<HttpClientConfiguration.Builder> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `Port(string port)` | Port value. | `Builder` |
| `Suites(Models.SuiteCode suites)` | Suites value. | `Builder` |

