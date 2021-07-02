# Query Param

```csharp
IQueryParamController queryParamController = client.QueryParamController;
```

## Class Name

`QueryParamController`

## Methods

* [Date Array](/doc/controllers/query-param.md#date-array)
* [Optional Dynamic Query Param](/doc/controllers/query-param.md#optional-dynamic-query-param)
* [Date](/doc/controllers/query-param.md#date)
* [Unix Date Time Array](/doc/controllers/query-param.md#unix-date-time-array)
* [Unix Date Time](/doc/controllers/query-param.md#unix-date-time)
* [Rfc 1123 Date Time](/doc/controllers/query-param.md#rfc-1123-date-time)
* [Rfc 1123 Date Time Array](/doc/controllers/query-param.md#rfc-1123-date-time-array)
* [Rfc 3339 Date Time Array](/doc/controllers/query-param.md#rfc-3339-date-time-array)
* [Rfc 3339 Date Time](/doc/controllers/query-param.md#rfc-3339-date-time)
* [No Params](/doc/controllers/query-param.md#no-params)
* [String Param](/doc/controllers/query-param.md#string-param)
* [Url Param](/doc/controllers/query-param.md#url-param)
* [Number Array](/doc/controllers/query-param.md#number-array)
* [String Array](/doc/controllers/query-param.md#string-array)
* [Simple Query](/doc/controllers/query-param.md#simple-query)
* [String Enum Array](/doc/controllers/query-param.md#string-enum-array)
* [Multiple Params](/doc/controllers/query-param.md#multiple-params)
* [Integer Enum Array](/doc/controllers/query-param.md#integer-enum-array)


# Date Array

```csharp
DateArrayAsync(
    List<DateTime> dates)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `dates` | `List<DateTime>` | Query, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
var dates = new List<DateTime>();
dates.Add(DateTime.Parse("2016-03-13"));
dates.Add(DateTime.Parse("2016-03-13"));

try
{
    ServerResponse result = await queryParamController.DateArrayAsync(dates);
}
catch (ApiException e){};
```


# Optional Dynamic Query Param

get optional dynamic query parameter

```csharp
OptionalDynamicQueryParamAsync(
    string name,
    Dictionary<string, object> queryParameters = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `name` | `string` | Query, Required | - |
| `queryParameters` | `Dictionary<string, object>` | Optional | Pass additional query parameters. |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
string name = "name0";
var queryParameters = new Dictionary<string, Object>();
queryParameters.Add("key0", "additionalQueryParams2");

try
{
    ServerResponse result = await queryParamController.OptionalDynamicQueryParamAsync(name, queryParameters);
}
catch (ApiException e){};
```


# Date

```csharp
DateAsync(
    DateTime date)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `date` | `DateTime` | Query, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
DateTime date = DateTime.Parse("2016-03-13");

try
{
    ServerResponse result = await queryParamController.DateAsync(date);
}
catch (ApiException e){};
```


# Unix Date Time Array

```csharp
UnixDateTimeArrayAsync(
    List<DateTime> datetimes)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `datetimes` | `List<DateTime>` | Query, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
var datetimes = new List<DateTime>();
datetimes.Add(DateTime.Parse("Liquid error: Object of type 'System.Int64' cannot be converted to type 'System.String'."));
datetimes.Add(DateTime.Parse("Liquid error: Object of type 'System.Int64' cannot be converted to type 'System.String'."));
datetimes.Add(DateTime.Parse("Liquid error: Object of type 'System.Int64' cannot be converted to type 'System.String'."));

try
{
    ServerResponse result = await queryParamController.UnixDateTimeArrayAsync(datetimes);
}
catch (ApiException e){};
```


# Unix Date Time

```csharp
UnixDateTimeAsync(
    DateTime datetime)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `datetime` | `DateTime` | Query, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
DateTime datetime = DateTime.Parse("Liquid error: Object of type 'System.Int64' cannot be converted to type 'System.String'.");

try
{
    ServerResponse result = await queryParamController.UnixDateTimeAsync(datetime);
}
catch (ApiException e){};
```


# Rfc 1123 Date Time

```csharp
Rfc1123DateTimeAsync(
    DateTime datetime)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `datetime` | `DateTime` | Query, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
DateTime datetime = DateTime.Parse("Mon, 15 Jun 2009 20:45:30 GMT");

try
{
    ServerResponse result = await queryParamController.Rfc1123DateTimeAsync(datetime);
}
catch (ApiException e){};
```


# Rfc 1123 Date Time Array

```csharp
Rfc1123DateTimeArrayAsync(
    List<DateTime> datetimes)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `datetimes` | `List<DateTime>` | Query, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
var datetimes = new List<DateTime>();
datetimes.Add(DateTime.Parse("Mon, 15 Jun 2009 20:45:30 GMT"));
datetimes.Add(DateTime.Parse("Mon, 15 Jun 2009 20:45:30 GMT"));
datetimes.Add(DateTime.Parse("Mon, 15 Jun 2009 20:45:30 GMT"));

try
{
    ServerResponse result = await queryParamController.Rfc1123DateTimeArrayAsync(datetimes);
}
catch (ApiException e){};
```


# Rfc 3339 Date Time Array

```csharp
Rfc3339DateTimeArrayAsync(
    List<DateTime> datetimes)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `datetimes` | `List<DateTime>` | Query, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
var datetimes = new List<DateTime>();
datetimes.Add(DateTime.Parse("2016-03-13T12:52:32.123Z"));
datetimes.Add(DateTime.Parse("2016-03-13T12:52:32.123Z"));
datetimes.Add(DateTime.Parse("2016-03-13T12:52:32.123Z"));

try
{
    ServerResponse result = await queryParamController.Rfc3339DateTimeArrayAsync(datetimes);
}
catch (ApiException e){};
```


# Rfc 3339 Date Time

```csharp
Rfc3339DateTimeAsync(
    DateTime datetime)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `datetime` | `DateTime` | Query, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
DateTime datetime = DateTime.Parse("2016-03-13T12:52:32.123Z");

try
{
    ServerResponse result = await queryParamController.Rfc3339DateTimeAsync(datetime);
}
catch (ApiException e){};
```


# No Params

```csharp
NoParamsAsync()
```

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
try
{
    ServerResponse result = await queryParamController.NoParamsAsync();
}
catch (ApiException e){};
```


# String Param

```csharp
StringParamAsync(
    string mString)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `mString` | `string` | Query, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
string mString = "string4";

try
{
    ServerResponse result = await queryParamController.StringParamAsync(mString);
}
catch (ApiException e){};
```


# Url Param

```csharp
UrlParamAsync(
    string url)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `url` | `string` | Query, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
string url = "url4";

try
{
    ServerResponse result = await queryParamController.UrlParamAsync(url);
}
catch (ApiException e){};
```


# Number Array

```csharp
NumberArrayAsync(
    List<int> integers)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `integers` | `List<int>` | Query, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
var integers = new List<int>();
integers.Add(45);
integers.Add(46);
integers.Add(47);

try
{
    ServerResponse result = await queryParamController.NumberArrayAsync(integers);
}
catch (ApiException e){};
```


# String Array

```csharp
StringArrayAsync(
    List<string> strings)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `strings` | `List<string>` | Query, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
var strings = new List<string>();
strings.Add("strings5");

try
{
    ServerResponse result = await queryParamController.StringArrayAsync(strings);
}
catch (ApiException e){};
```


# Simple Query

```csharp
SimpleQueryAsync(
    bool boolean,
    int number,
    string mString,
    Dictionary<string, object> queryParameters = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `boolean` | `bool` | Query, Required | - |
| `number` | `int` | Query, Required | - |
| `mString` | `string` | Query, Required | - |
| `queryParameters` | `Dictionary<string, object>` | Optional | Pass additional query parameters. |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
bool boolean = false;
int number = 158;
string mString = "string4";
var queryParameters = new Dictionary<string, Object>();
queryParameters.Add("key0", "additionalQueryParams2");

try
{
    ServerResponse result = await queryParamController.SimpleQueryAsync(boolean, number, mString, queryParameters);
}
catch (ApiException e){};
```


# String Enum Array

```csharp
StringEnumArrayAsync(
    List<Models.Days> days)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `days` | [`List<Models.Days>`](/doc/models/days.md) | Query, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
var days = new List<Days>();
days.Add(Days.Sunday);
days.Add(Days.Monday);
days.Add(Days.Tuesday);

try
{
    ServerResponse result = await queryParamController.StringEnumArrayAsync(days);
}
catch (ApiException e){};
```


# Multiple Params

```csharp
MultipleParamsAsync(
    int number,
    double precision,
    string mString,
    string url)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `number` | `int` | Query, Required | - |
| `precision` | `double` | Query, Required | - |
| `mString` | `string` | Query, Required | - |
| `url` | `string` | Query, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
int number = 158;
double precision = 112.04;
string mString = "string4";
string url = "url4";

try
{
    ServerResponse result = await queryParamController.MultipleParamsAsync(number, precision, mString, url);
}
catch (ApiException e){};
```


# Integer Enum Array

```csharp
IntegerEnumArrayAsync(
    List<Models.SuiteCode> suites)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `suites` | [`List<Models.SuiteCode>`](/doc/models/suite-code.md) | Query, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
var suites = new List<SuiteCode>();
suites.Add(SuiteCode.Hearts);
suites.Add(SuiteCode.Spades);
suites.Add(SuiteCode.Clubs);

try
{
    ServerResponse result = await queryParamController.IntegerEnumArrayAsync(suites);
}
catch (ApiException e){};
```

