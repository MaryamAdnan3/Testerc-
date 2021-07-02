# Template Params

```csharp
ITemplateParamsController templateParamsController = client.TemplateParamsController;
```

## Class Name

`TemplateParamsController`

## Methods

* [Send String Array](/doc/controllers/template-params.md#send-string-array)
* [Send Integer Array](/doc/controllers/template-params.md#send-integer-array)


# Send String Array

```csharp
SendStringArrayAsync(
    List<string> strings)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `strings` | `List<string>` | Template, Required | - |

## Response Type

[`Task<Models.EchoResponse>`](/doc/models/echo-response.md)

## Example Usage

```csharp
var strings = new List<string>();
strings.Add("strings5");

try
{
    EchoResponse result = await templateParamsController.SendStringArrayAsync(strings);
}
catch (ApiException e){};
```


# Send Integer Array

```csharp
SendIntegerArrayAsync(
    List<int> integers)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `integers` | `List<int>` | Template, Required | - |

## Response Type

[`Task<Models.EchoResponse>`](/doc/models/echo-response.md)

## Example Usage

```csharp
var integers = new List<int>();
integers.Add(45);
integers.Add(46);
integers.Add(47);

try
{
    EchoResponse result = await templateParamsController.SendIntegerArrayAsync(integers);
}
catch (ApiException e){};
```

