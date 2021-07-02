# Error Codes

```csharp
IErrorCodesController errorCodesController = client.ErrorCodesController;
```

## Class Name

`ErrorCodesController`

## Methods

* [Catch 412 Global Error](/doc/controllers/error-codes.md#catch-412-global-error)
* [Get 501](/doc/controllers/error-codes.md#get-501)
* [Get 400](/doc/controllers/error-codes.md#get-400)
* [Get 500](/doc/controllers/error-codes.md#get-500)
* [Get 401](/doc/controllers/error-codes.md#get-401)
* [Receive Exception With Unixtimestamp Exception](/doc/controllers/error-codes.md#receive-exception-with-unixtimestamp-exception)
* [Receive Exception With Rfc 1123 Datetime](/doc/controllers/error-codes.md#receive-exception-with-rfc-1123-datetime)
* [Receive Exception With Rfc 3339 Datetime](/doc/controllers/error-codes.md#receive-exception-with-rfc-3339-datetime)
* [Receive Endpoint Level Exception](/doc/controllers/error-codes.md#receive-endpoint-level-exception)
* [Receive Global Level Exception](/doc/controllers/error-codes.md#receive-global-level-exception)
* [Date in Exception](/doc/controllers/error-codes.md#date-in-exception)
* [UUID in Exception](/doc/controllers/error-codes.md#uuid-in-exception)
* [Dynamic in Exception](/doc/controllers/error-codes.md#dynamic-in-exception)
* [Precision in Exception](/doc/controllers/error-codes.md#precision-in-exception)
* [Boolean in Exception](/doc/controllers/error-codes.md#boolean-in-exception)
* [Long in Exception](/doc/controllers/error-codes.md#long-in-exception)
* [Number in Exception](/doc/controllers/error-codes.md#number-in-exception)
* [Get Exception With String](/doc/controllers/error-codes.md#get-exception-with-string)


# Catch 412 Global Error

```csharp
Catch412GlobalErrorAsync()
```

## Response Type

`Task<dynamic>`

## Example Usage

```csharp
try
{
    dynamic result = await errorCodesController.Catch412GlobalErrorAsync();
}
catch (ApiException e){};
```


# Get 501

```csharp
Get501Async()
```

## Response Type

`Task<dynamic>`

## Example Usage

```csharp
try
{
    dynamic result = await errorCodesController.Get501Async();
}
catch (ApiException e){};
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 501 | error 501 | [`NestedModelException`](/doc/models/nested-model-exception.md) |


# Get 400

```csharp
Get400Async()
```

## Response Type

`Task<dynamic>`

## Example Usage

```csharp
try
{
    dynamic result = await errorCodesController.Get400Async();
}
catch (ApiException e){};
```


# Get 500

```csharp
Get500Async()
```

## Response Type

`Task<dynamic>`

## Example Usage

```csharp
try
{
    dynamic result = await errorCodesController.Get500Async();
}
catch (ApiException e){};
```


# Get 401

```csharp
Get401Async()
```

## Response Type

`Task<dynamic>`

## Example Usage

```csharp
try
{
    dynamic result = await errorCodesController.Get401Async();
}
catch (ApiException e){};
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 401 | 401 Local | [`LocalTestException`](/doc/models/local-test-exception.md) |
| 421 | Default | [`LocalTestException`](/doc/models/local-test-exception.md) |
| 431 | Default | [`LocalTestException`](/doc/models/local-test-exception.md) |
| 432 | Default | [`LocalTestException`](/doc/models/local-test-exception.md) |
| 441 | Default | [`LocalTestException`](/doc/models/local-test-exception.md) |
| Default | Invalid response. | [`LocalTestException`](/doc/models/local-test-exception.md) |


# Receive Exception With Unixtimestamp Exception

```csharp
ReceiveExceptionWithUnixtimestampExceptionAsync()
```

## Response Type

`Task<dynamic>`

## Example Usage

```csharp
try
{
    dynamic result = await errorCodesController.ReceiveExceptionWithUnixtimestampExceptionAsync();
}
catch (ApiException e){};
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 444 | unixtimestamp exception | [`UnixTimeStampException`](/doc/models/unix-time-stamp-exception.md) |


# Receive Exception With Rfc 1123 Datetime

```csharp
ReceiveExceptionWithRfc1123DatetimeAsync()
```

## Response Type

`Task<dynamic>`

## Example Usage

```csharp
try
{
    dynamic result = await errorCodesController.ReceiveExceptionWithRfc1123DatetimeAsync();
}
catch (ApiException e){};
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 444 | Rfc1123 Exception | [`Rfc1123Exception`](/doc/models/rfc-1123-exception.md) |


# Receive Exception With Rfc 3339 Datetime

```csharp
ReceiveExceptionWithRfc3339DatetimeAsync()
```

## Response Type

`Task<dynamic>`

## Example Usage

```csharp
try
{
    dynamic result = await errorCodesController.ReceiveExceptionWithRfc3339DatetimeAsync();
}
catch (ApiException e){};
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 444 | DateTime Exception | [`ExceptionWithRfc3339DateTimeException`](/doc/models/exception-with-rfc-3339-date-time-exception.md) |


# Receive Endpoint Level Exception

```csharp
ReceiveEndpointLevelExceptionAsync()
```

## Response Type

[`Task<Models.Complex5>`](/doc/models/complex-5.md)

## Example Usage

```csharp
try
{
    Complex5 result = await errorCodesController.ReceiveEndpointLevelExceptionAsync();
}
catch (ApiException e){};
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 451 | caught endpoint exception | [`CustomErrorResponseException`](/doc/models/custom-error-response-exception.md) |


# Receive Global Level Exception

```csharp
ReceiveGlobalLevelExceptionAsync()
```

## Response Type

[`Task<Models.Complex5>`](/doc/models/complex-5.md)

## Example Usage

```csharp
try
{
    Complex5 result = await errorCodesController.ReceiveGlobalLevelExceptionAsync();
}
catch (ApiException e){};
```


# Date in Exception

```csharp
DateInExceptionAsync()
```

## Response Type

`Task<dynamic>`

## Example Usage

```csharp
try
{
    dynamic result = await errorCodesController.DateInExceptionAsync();
}
catch (ApiException e){};
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 444 | date in exception | [`ExceptionWithDateException`](/doc/models/exception-with-date-exception.md) |


# UUID in Exception

```csharp
UUIDInExceptionAsync()
```

## Response Type

`Task<dynamic>`

## Example Usage

```csharp
try
{
    dynamic result = await errorCodesController.UUIDInExceptionAsync();
}
catch (ApiException e){};
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 444 | uuid in exception | [`ExceptionWithUUIDException`](/doc/models/exception-with-uuid-exception.md) |


# Dynamic in Exception

```csharp
DynamicInExceptionAsync()
```

## Response Type

`Task<dynamic>`

## Example Usage

```csharp
try
{
    dynamic result = await errorCodesController.DynamicInExceptionAsync();
}
catch (ApiException e){};
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 444 | dynamic in Exception | [`ExceptionWithDynamicException`](/doc/models/exception-with-dynamic-exception.md) |


# Precision in Exception

```csharp
PrecisionInExceptionAsync()
```

## Response Type

`Task<dynamic>`

## Example Usage

```csharp
try
{
    dynamic result = await errorCodesController.PrecisionInExceptionAsync();
}
catch (ApiException e){};
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 444 | precision in Exception | [`ExceptionWithPrecisionException`](/doc/models/exception-with-precision-exception.md) |


# Boolean in Exception

```csharp
BooleanInExceptionAsync()
```

## Response Type

`Task<dynamic>`

## Example Usage

```csharp
try
{
    dynamic result = await errorCodesController.BooleanInExceptionAsync();
}
catch (ApiException e){};
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 444 | Boolean in Exception | [`ExceptionWithBooleanException`](/doc/models/exception-with-boolean-exception.md) |


# Long in Exception

```csharp
LongInExceptionAsync()
```

## Response Type

`Task<dynamic>`

## Example Usage

```csharp
try
{
    dynamic result = await errorCodesController.LongInExceptionAsync();
}
catch (ApiException e){};
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 444 | long in exception | [`ExceptionWithLongException`](/doc/models/exception-with-long-exception.md) |


# Number in Exception

```csharp
NumberInExceptionAsync()
```

## Response Type

`Task<dynamic>`

## Example Usage

```csharp
try
{
    dynamic result = await errorCodesController.NumberInExceptionAsync();
}
catch (ApiException e){};
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 444 | number in exception | [`ExceptionWithNumberException`](/doc/models/exception-with-number-exception.md) |


# Get Exception With String

```csharp
GetExceptionWithStringAsync()
```

## Response Type

`Task<dynamic>`

## Example Usage

```csharp
try
{
    dynamic result = await errorCodesController.GetExceptionWithStringAsync();
}
catch (ApiException e){};
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 444 | exception with string | [`ExceptionWithStringException`](/doc/models/exception-with-string-exception.md) |

