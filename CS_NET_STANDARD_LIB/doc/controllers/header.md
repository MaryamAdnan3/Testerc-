# Header

```csharp
IHeaderController headerController = client.HeaderController;
```

## Class Name

`HeaderController`


# Send Headers

Sends a single header params

```csharp
SendHeadersAsync(
    string customHeader,
    string mValue)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `customHeader` | `string` | Header, Required | - |
| `mValue` | `string` | Form, Required | Represents the value of the custom header |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
string customHeader = "custom-header2";
string mValue = "value2";

try
{
    ServerResponse result = await headerController.SendHeadersAsync(customHeader, mValue);
}
catch (ApiException e){};
```

