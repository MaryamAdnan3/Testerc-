# Echo

```csharp
IEchoController echoController = client.EchoController;
```

## Class Name

`EchoController`

## Methods

* [Json Echo](/doc/controllers/echo.md#json-echo)
* [Form Echo](/doc/controllers/echo.md#form-echo)
* [Query Echo](/doc/controllers/echo.md#query-echo)


# Json Echo

Echo's back the request

```csharp
JsonEchoAsync(
    object input)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `input` | `object` | Body, Required | - |

## Response Type

`Task<dynamic>`

## Example Usage

```csharp
object input = ApiHelper.JsonDeserialize<Object>("{\"key1\":\"val1\",\"key2\":\"val2\"}");

try
{
    dynamic result = await echoController.JsonEchoAsync(input);
}
catch (ApiException e){};
```


# Form Echo

Sends the request including any form params as JSON

```csharp
FormEchoAsync(
    object input)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `input` | `object` | Form, Required | - |

## Response Type

`Task<dynamic>`

## Example Usage

```csharp
object input = ApiHelper.JsonDeserialize<Object>("{\"key1\":\"val1\",\"key2\":\"val2\"}");

try
{
    dynamic result = await echoController.FormEchoAsync(input);
}
catch (ApiException e){};
```


# Query Echo

```csharp
QueryEchoAsync(
    Dictionary<string, object> queryParameters = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `queryParameters` | `Dictionary<string, object>` | Optional | Pass additional query parameters. |

## Response Type

[`Task<Models.EchoResponse>`](/doc/models/echo-response.md)

## Example Usage

```csharp
var queryParameters = new Dictionary<string, Object>();
queryParameters.Add("key0", "additionalQueryParams2");

try
{
    EchoResponse result = await echoController.QueryEchoAsync(queryParameters);
}
catch (ApiException e){};
```

