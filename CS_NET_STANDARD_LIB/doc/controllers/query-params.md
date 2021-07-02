# Query Params

```csharp
IQueryParamsController queryParamsController = client.QueryParamsController;
```

## Class Name

`QueryParamsController`

## Methods

* [Send Number as Optional](/doc/controllers/query-params.md#send-number-as-optional)
* [Send Long as Optional](/doc/controllers/query-params.md#send-long-as-optional)
* [Precision as Optional](/doc/controllers/query-params.md#precision-as-optional)
* [Boolean as Optional](/doc/controllers/query-params.md#boolean-as-optional)
* [Rfc 1123 Datetime as Optional](/doc/controllers/query-params.md#rfc-1123-datetime-as-optional)
* [Rfc 3339 Datetime as Optional](/doc/controllers/query-params.md#rfc-3339-datetime-as-optional)
* [Send Date as Optional](/doc/controllers/query-params.md#send-date-as-optional)
* [Send String as Optional](/doc/controllers/query-params.md#send-string-as-optional)
* [Unixdatetime as Optional](/doc/controllers/query-params.md#unixdatetime-as-optional)


# Send Number as Optional

```csharp
SendNumberAsOptionalAsync(
    int number,
    int? number1 = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `number` | `int` | Query, Required | - |
| `number1` | `int?` | Query, Optional | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
int number = 1;
int? number1 = 1;

try
{
    ServerResponse result = await queryParamsController.SendNumberAsOptionalAsync(number, number1);
}
catch (ApiException e){};
```


# Send Long as Optional

```csharp
SendLongAsOptionalAsync(
    long mLong,
    long? long1 = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `mLong` | `long` | Query, Required | - |
| `long1` | `long?` | Query, Optional | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
long mLong = 123123L;
long? long1 = 123123L;

try
{
    ServerResponse result = await queryParamsController.SendLongAsOptionalAsync(mLong, long1);
}
catch (ApiException e){};
```


# Precision as Optional

```csharp
PrecisionAsOptionalAsync(
    double precision,
    double? precision1 = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `precision` | `double` | Query, Required | - |
| `precision1` | `double?` | Query, Optional | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
double precision = 1.23;
double? precision1 = 1.23;

try
{
    ServerResponse result = await queryParamsController.PrecisionAsOptionalAsync(precision, precision1);
}
catch (ApiException e){};
```


# Boolean as Optional

```csharp
BooleanAsOptionalAsync(
    bool boolean,
    bool? boolean1 = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `boolean` | `bool` | Query, Required | - |
| `boolean1` | `bool?` | Query, Optional | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
bool boolean = true;
bool? boolean1 = true;

try
{
    ServerResponse result = await queryParamsController.BooleanAsOptionalAsync(boolean, boolean1);
}
catch (ApiException e){};
```


# Rfc 1123 Datetime as Optional

```csharp
Rfc1123DatetimeAsOptionalAsync(
    DateTime dateTime,
    DateTime? dateTime1 = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `dateTime` | `DateTime` | Query, Required | - |
| `dateTime1` | `DateTime?` | Query, Optional | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
DateTime dateTime = DateTime.Parse("Sun, 06 Nov 1994 08:49:37 GMT");
DateTime? dateTime1 = DateTime.Parse("Sun, 06 Nov 1994 08:49:37 GMT");

try
{
    ServerResponse result = await queryParamsController.Rfc1123DatetimeAsOptionalAsync(dateTime, dateTime1);
}
catch (ApiException e){};
```


# Rfc 3339 Datetime as Optional

```csharp
Rfc3339DatetimeAsOptionalAsync(
    DateTime dateTime,
    DateTime? dateTime1 = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `dateTime` | `DateTime` | Query, Required | - |
| `dateTime1` | `DateTime?` | Query, Optional | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
DateTime dateTime = DateTime.Parse("1994-02-13 14:01:54");
DateTime? dateTime1 = DateTime.Parse("1994-02-13 14:01:54");

try
{
    ServerResponse result = await queryParamsController.Rfc3339DatetimeAsOptionalAsync(dateTime, dateTime1);
}
catch (ApiException e){};
```


# Send Date as Optional

```csharp
SendDateAsOptionalAsync(
    DateTime date,
    DateTime? date1 = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `date` | `DateTime` | Query, Required | - |
| `date1` | `DateTime?` | Query, Optional | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
DateTime date = DateTime.Parse("1994-02-13");
DateTime? date1 = DateTime.Parse("1994-02-13");

try
{
    ServerResponse result = await queryParamsController.SendDateAsOptionalAsync(date, date1);
}
catch (ApiException e){};
```


# Send String as Optional

```csharp
SendStringAsOptionalAsync(
    string mString,
    string string1 = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `mString` | `string` | Query, Required | - |
| `string1` | `string` | Query, Optional | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
string mString = "test";
string string1 = "test";

try
{
    ServerResponse result = await queryParamsController.SendStringAsOptionalAsync(mString, string1);
}
catch (ApiException e){};
```


# Unixdatetime as Optional

```csharp
UnixdatetimeAsOptionalAsync(
    DateTime dateTime,
    DateTime? dateTime1 = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `dateTime` | `DateTime` | Query, Required | - |
| `dateTime1` | `DateTime?` | Query, Optional | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
DateTime dateTime = DateTime.Parse("Liquid error: Object of type 'System.Int64' cannot be converted to type 'System.String'.");
DateTime? dateTime1 = DateTime.Parse("Liquid error: Object of type 'System.Int64' cannot be converted to type 'System.String'.");

try
{
    ServerResponse result = await queryParamsController.UnixdatetimeAsOptionalAsync(dateTime, dateTime1);
}
catch (ApiException e){};
```

