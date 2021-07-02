# Body Params

```csharp
IBodyParamsController bodyParamsController = client.BodyParamsController;
```

## Class Name

`BodyParamsController`

## Methods

* [Send Delete Plain Text](/doc/controllers/body-params.md#send-delete-plain-text)
* [Send Delete Body](/doc/controllers/body-params.md#send-delete-body)
* [Send Date Array](/doc/controllers/body-params.md#send-date-array)
* [Send Date](/doc/controllers/body-params.md#send-date)
* [Send Unix Date Time](/doc/controllers/body-params.md#send-unix-date-time)
* [Send Rfc 1123 Date Time](/doc/controllers/body-params.md#send-rfc-1123-date-time)
* [Send Rfc 3339 Date Time](/doc/controllers/body-params.md#send-rfc-3339-date-time)
* [Send Unix Date Time Array](/doc/controllers/body-params.md#send-unix-date-time-array)
* [Send Rfc 1123 Date Time Array](/doc/controllers/body-params.md#send-rfc-1123-date-time-array)
* [Send Rfc 3339 Date Time Array](/doc/controllers/body-params.md#send-rfc-3339-date-time-array)
* [Send String Array](/doc/controllers/body-params.md#send-string-array)
* [Update String](/doc/controllers/body-params.md#update-string)
* [Send Integer Array](/doc/controllers/body-params.md#send-integer-array)
* [Wrap Body in Object](/doc/controllers/body-params.md#wrap-body-in-object)
* [Additional Model Parameters](/doc/controllers/body-params.md#additional-model-parameters)
* [Validate Required Parameter](/doc/controllers/body-params.md#validate-required-parameter)
* [Additional Model Parameters 1](/doc/controllers/body-params.md#additional-model-parameters-1)
* [Send Model](/doc/controllers/body-params.md#send-model)
* [Send Model Array](/doc/controllers/body-params.md#send-model-array)
* [Send Dynamic](/doc/controllers/body-params.md#send-dynamic)
* [Send String](/doc/controllers/body-params.md#send-string)
* [Send String Enum Array](/doc/controllers/body-params.md#send-string-enum-array)
* [Send Integer Enum Array](/doc/controllers/body-params.md#send-integer-enum-array)
* [Update Model](/doc/controllers/body-params.md#update-model)
* [Send Delete Body With Model](/doc/controllers/body-params.md#send-delete-body-with-model)
* [Send Delete Body With Model Array](/doc/controllers/body-params.md#send-delete-body-with-model-array)
* [Update Model Array](/doc/controllers/body-params.md#update-model-array)
* [Update String 1](/doc/controllers/body-params.md#update-string-1)
* [Update String Array](/doc/controllers/body-params.md#update-string-array)
* [Send String With New Line](/doc/controllers/body-params.md#send-string-with-new-line)
* [Send String With R](/doc/controllers/body-params.md#send-string-with-r)
* [Send String in Body With R N](/doc/controllers/body-params.md#send-string-in-body-with-r-n)
* [Send Optional Unix Date Time in Body](/doc/controllers/body-params.md#send-optional-unix-date-time-in-body)
* [Send Optional Rfc 1123 in Body](/doc/controllers/body-params.md#send-optional-rfc-1123-in-body)
* [Send Datetime Optional in Endpoint](/doc/controllers/body-params.md#send-datetime-optional-in-endpoint)
* [Send Optional Unix Time Stamp in Model Body](/doc/controllers/body-params.md#send-optional-unix-time-stamp-in-model-body)
* [Send Optional Unix Time Stamp in Nested Model Body](/doc/controllers/body-params.md#send-optional-unix-time-stamp-in-nested-model-body)
* [Send Rfc 1123 Date Time in Nested Model](/doc/controllers/body-params.md#send-rfc-1123-date-time-in-nested-model)
* [Send Rfc 1123 Date Time in Model](/doc/controllers/body-params.md#send-rfc-1123-date-time-in-model)
* [Send Optional Datetime in Model](/doc/controllers/body-params.md#send-optional-datetime-in-model)
* [Send Rfc 339 Date Time in Nested Models](/doc/controllers/body-params.md#send-rfc-339-date-time-in-nested-models)
* [Uuid as Optional](/doc/controllers/body-params.md#uuid-as-optional)
* [Boolean as Optional](/doc/controllers/body-params.md#boolean-as-optional)
* [Date as Optional](/doc/controllers/body-params.md#date-as-optional)
* [Dynamic as Optional](/doc/controllers/body-params.md#dynamic-as-optional)
* [String as Optional](/doc/controllers/body-params.md#string-as-optional)
* [Precision as Optional](/doc/controllers/body-params.md#precision-as-optional)
* [Long as Optional](/doc/controllers/body-params.md#long-as-optional)
* [Send Number as Optional](/doc/controllers/body-params.md#send-number-as-optional)


# Send Delete Plain Text

```csharp
SendDeletePlainTextAsync(
    string textString)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `textString` | `string` | Body, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
string textString = "textString2";

try
{
    ServerResponse result = await bodyParamsController.SendDeletePlainTextAsync(textString);
}
catch (ApiException e){};
```


# Send Delete Body

```csharp
SendDeleteBodyAsync(
    Models.DeleteBody body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Models.DeleteBody`](/doc/models/delete-body.md) | Body, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
var body = new DeleteBody();
body.Name = "name6";
body.Field = "field0";

try
{
    ServerResponse result = await bodyParamsController.SendDeleteBodyAsync(body);
}
catch (ApiException e){};
```


# Send Date Array

```csharp
SendDateArrayAsync(
    List<DateTime> dates)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `dates` | `List<DateTime>` | Body, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
var dates = new List<DateTime>();
dates.Add(DateTime.Parse("2016-03-13"));
dates.Add(DateTime.Parse("2016-03-13"));

try
{
    ServerResponse result = await bodyParamsController.SendDateArrayAsync(dates);
}
catch (ApiException e){};
```


# Send Date

```csharp
SendDateAsync(
    DateTime date)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `date` | `DateTime` | Body, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
DateTime date = DateTime.Parse("2016-03-13");

try
{
    ServerResponse result = await bodyParamsController.SendDateAsync(date);
}
catch (ApiException e){};
```


# Send Unix Date Time

```csharp
SendUnixDateTimeAsync(
    DateTime datetime)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `datetime` | `DateTime` | Body, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
DateTime datetime = DateTime.Parse("Liquid error: Object of type 'System.Int64' cannot be converted to type 'System.String'.");

try
{
    ServerResponse result = await bodyParamsController.SendUnixDateTimeAsync(datetime);
}
catch (ApiException e){};
```


# Send Rfc 1123 Date Time

```csharp
SendRfc1123DateTimeAsync(
    DateTime datetime)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `datetime` | `DateTime` | Body, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
DateTime datetime = DateTime.Parse("Mon, 15 Jun 2009 20:45:30 GMT");

try
{
    ServerResponse result = await bodyParamsController.SendRfc1123DateTimeAsync(datetime);
}
catch (ApiException e){};
```


# Send Rfc 3339 Date Time

```csharp
SendRfc3339DateTimeAsync(
    DateTime datetime)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `datetime` | `DateTime` | Body, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
DateTime datetime = DateTime.Parse("2016-03-13T12:52:32.123Z");

try
{
    ServerResponse result = await bodyParamsController.SendRfc3339DateTimeAsync(datetime);
}
catch (ApiException e){};
```


# Send Unix Date Time Array

```csharp
SendUnixDateTimeArrayAsync(
    List<DateTime> datetimes)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `datetimes` | `List<DateTime>` | Body, Required | - |

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
    ServerResponse result = await bodyParamsController.SendUnixDateTimeArrayAsync(datetimes);
}
catch (ApiException e){};
```


# Send Rfc 1123 Date Time Array

```csharp
SendRfc1123DateTimeArrayAsync(
    List<DateTime> datetimes)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `datetimes` | `List<DateTime>` | Body, Required | - |

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
    ServerResponse result = await bodyParamsController.SendRfc1123DateTimeArrayAsync(datetimes);
}
catch (ApiException e){};
```


# Send Rfc 3339 Date Time Array

```csharp
SendRfc3339DateTimeArrayAsync(
    List<DateTime> datetimes)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `datetimes` | `List<DateTime>` | Body, Required | - |

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
    ServerResponse result = await bodyParamsController.SendRfc3339DateTimeArrayAsync(datetimes);
}
catch (ApiException e){};
```


# Send String Array

sends a string body param

```csharp
SendStringArrayAsync(
    List<string> sarray)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `sarray` | `List<string>` | Body, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
var sarray = new List<string>();
sarray.Add("sarray8");
sarray.Add("sarray9");

try
{
    ServerResponse result = await bodyParamsController.SendStringArrayAsync(sarray);
}
catch (ApiException e){};
```


# Update String

```csharp
UpdateStringAsync(
    string mValue)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `mValue` | `string` | Body, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
string mValue = "value2";

try
{
    ServerResponse result = await bodyParamsController.UpdateStringAsync(mValue);
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
| `integers` | `List<int>` | Body, Required | - |

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
    ServerResponse result = await bodyParamsController.SendIntegerArrayAsync(integers);
}
catch (ApiException e){};
```


# Wrap Body in Object

```csharp
WrapBodyInObjectAsync(
    string field,
    string name)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `field` | `string` | Body, Required | - |
| `name` | `string` | Body, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
string field = "field6";
string name = "name0";

try
{
    ServerResponse result = await bodyParamsController.WrapBodyInObjectAsync(field, name);
}
catch (ApiException e){};
```


# Additional Model Parameters

```csharp
AdditionalModelParametersAsync(
    Models.AdditionalModelParameters model)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `model` | [`Models.AdditionalModelParameters`](/doc/models/additional-model-parameters.md) | Body, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
var model = new AdditionalModelParameters();
model.Name = "name2";
model.Field = "field4";
model.Address = "address8";
model.Job = new Job();
model.Job.Company = "company8";

try
{
    ServerResponse result = await bodyParamsController.AdditionalModelParametersAsync(model);
}
catch (ApiException e){};
```


# Validate Required Parameter

```csharp
ValidateRequiredParameterAsync(
    Models.Validate model,
    string option = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `model` | [`Models.Validate`](/doc/models/validate.md) | Body, Required | - |
| `option` | `string` | Query, Optional | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
var model = new Validate();
model.Field = "field4";
model.Name = "name2";

try
{
    ServerResponse result = await bodyParamsController.ValidateRequiredParameterAsync(model, null);
}
catch (ApiException e){};
```


# Additional Model Parameters 1

```csharp
AdditionalModelParameters1Async(
    Models.AdditionalModelParameters model)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `model` | [`Models.AdditionalModelParameters`](/doc/models/additional-model-parameters.md) | Body, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
var model = new AdditionalModelParameters();
model.Name = "name2";
model.Field = "field4";
model.Address = "address8";
model.Job = new Job();
model.Job.Company = "company8";

try
{
    ServerResponse result = await bodyParamsController.AdditionalModelParameters1Async(model);
}
catch (ApiException e){};
```


# Send Model

```csharp
SendModelAsync(
    Models.Employee model)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `model` | [`Models.Employee`](/doc/models/employee.md) | Body, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
var model = new Employee();
model.Address = "address8";
model.Age = 186L;
model.Birthday = DateTime.Parse("2016-03-13");
model.Birthtime = DateTime.Parse("2016-03-13T12:52:32.123Z");
model.Name = "name2";
model.Uid = "uid2";
model.Department = "department8";
model.Dependents = new List<Person>();

var modelDependents0 = new Person();
modelDependents0.Address = "address5";
modelDependents0.Age = 237L;
modelDependents0.Birthday = DateTime.Parse("2016-03-13");
modelDependents0.Birthtime = DateTime.Parse("2016-03-13T12:52:32.123Z");
modelDependents0.Name = "name9";
modelDependents0.Uid = "uid9";
model.Dependents.Add(modelDependents0);

model.HiredAt = DateTime.Parse("Mon, 15 Jun 2009 20:45:30 GMT");
model.JoiningDay = Days.Monday;
model.Salary = 240;
model.WorkingDays = new List<Days>();
model.WorkingDays.Add(Days.Thursday);
model.WorkingDays.Add(Days.Wednesday);
model.WorkingDays.Add(Days.Tuesday);
model.Boss = new Person();
model.Boss.Address = "address6";
model.Boss.Age = 158L;
model.Boss.Birthday = DateTime.Parse("2016-03-13");
model.Boss.Birthtime = DateTime.Parse("2016-03-13T12:52:32.123Z");
model.Boss.Name = "name0";
model.Boss.Uid = "uid0";

try
{
    ServerResponse result = await bodyParamsController.SendModelAsync(model);
}
catch (ApiException e){};
```


# Send Model Array

```csharp
SendModelArrayAsync(
    List<Models.Employee> models)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `models` | [`List<Models.Employee>`](/doc/models/employee.md) | Body, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
var models = new List<Employee>();

var models0 = new Employee();
models0.Address = "address2";
models0.Age = 254L;
models0.Birthday = DateTime.Parse("2016-03-13");
models0.Birthtime = DateTime.Parse("2016-03-13T12:52:32.123Z");
models0.Name = "name6";
models0.Uid = "uid6";
models0.Department = "department6";
models0.Dependents = new List<Person>();

var models0Dependents0 = new Person();
models0Dependents0.Address = "address9";
models0Dependents0.Age = 49L;
models0Dependents0.Birthday = DateTime.Parse("2016-03-13");
models0Dependents0.Birthtime = DateTime.Parse("2016-03-13T12:52:32.123Z");
models0Dependents0.Name = "name3";
models0Dependents0.Uid = "uid3";
models0.Dependents.Add(models0Dependents0);

var models0Dependents1 = new Person();
models0Dependents1.Address = "address0";
models0Dependents1.Age = 50L;
models0Dependents1.Birthday = DateTime.Parse("2016-03-13");
models0Dependents1.Birthtime = DateTime.Parse("2016-03-13T12:52:32.123Z");
models0Dependents1.Name = "name4";
models0Dependents1.Uid = "uid4";
models0.Dependents.Add(models0Dependents1);

var models0Dependents2 = new Person();
models0Dependents2.Address = "address1";
models0Dependents2.Age = 51L;
models0Dependents2.Birthday = DateTime.Parse("2016-03-13");
models0Dependents2.Birthtime = DateTime.Parse("2016-03-13T12:52:32.123Z");
models0Dependents2.Name = "name5";
models0Dependents2.Uid = "uid5";
models0.Dependents.Add(models0Dependents2);

models0.HiredAt = DateTime.Parse("Mon, 15 Jun 2009 20:45:30 GMT");
models0.JoiningDay = Days.Monday;
models0.Salary = 84;
models0.WorkingDays = new List<Days>();
models0.WorkingDays.Add(Days.Sunday);
models0.Boss = new Person();
models0.Boss.Address = "address0";
models0.Boss.Age = 154L;
models0.Boss.Birthday = DateTime.Parse("2016-03-13");
models0.Boss.Birthtime = DateTime.Parse("2016-03-13T12:52:32.123Z");
models0.Boss.Name = "name4";
models0.Boss.Uid = "uid4";
models.Add(models0);

var models1 = new Employee();
models1.Address = "address3";
models1.Age = 255L;
models1.Birthday = DateTime.Parse("2016-03-13");
models1.Birthtime = DateTime.Parse("2016-03-13T12:52:32.123Z");
models1.Name = "name7";
models1.Uid = "uid7";
models1.Department = "department7";
models1.Dependents = new List<Person>();

var models1Dependents0 = new Person();
models1Dependents0.Address = "address0";
models1Dependents0.Age = 50L;
models1Dependents0.Birthday = DateTime.Parse("2016-03-13");
models1Dependents0.Birthtime = DateTime.Parse("2016-03-13T12:52:32.123Z");
models1Dependents0.Name = "name4";
models1Dependents0.Uid = "uid4";
models1.Dependents.Add(models1Dependents0);

models1.HiredAt = DateTime.Parse("Mon, 15 Jun 2009 20:45:30 GMT");
models1.JoiningDay = Days.Monday;
models1.Salary = 85;
models1.WorkingDays = new List<Days>();
models1.WorkingDays.Add(Days.Monday);
models1.WorkingDays.Add(Days.Tuesday);
models1.Boss = new Person();
models1.Boss.Address = "address1";
models1.Boss.Age = 155L;
models1.Boss.Birthday = DateTime.Parse("2016-03-13");
models1.Boss.Birthtime = DateTime.Parse("2016-03-13T12:52:32.123Z");
models1.Boss.Name = "name5";
models1.Boss.Uid = "uid5";
models.Add(models1);


try
{
    ServerResponse result = await bodyParamsController.SendModelArrayAsync(models);
}
catch (ApiException e){};
```


# Send Dynamic

```csharp
SendDynamicAsync(
    object mDynamic)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `mDynamic` | `object` | Body, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
object mDynamic = ApiHelper.JsonDeserialize<Object>("{\"key1\":\"val1\",\"key2\":\"val2\"}");

try
{
    ServerResponse result = await bodyParamsController.SendDynamicAsync(mDynamic);
}
catch (ApiException e){};
```


# Send String

```csharp
SendStringAsync(
    string mValue)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `mValue` | `string` | Body, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
string mValue = "value2";

try
{
    ServerResponse result = await bodyParamsController.SendStringAsync(mValue);
}
catch (ApiException e){};
```


# Send String Enum Array

```csharp
SendStringEnumArrayAsync(
    List<Models.Days> days)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `days` | [`List<Models.Days>`](/doc/models/days.md) | Body, Required | - |

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
    ServerResponse result = await bodyParamsController.SendStringEnumArrayAsync(days);
}
catch (ApiException e){};
```


# Send Integer Enum Array

```csharp
SendIntegerEnumArrayAsync(
    List<Models.SuiteCode> suites)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `suites` | [`List<Models.SuiteCode>`](/doc/models/suite-code.md) | Body, Required | - |

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
    ServerResponse result = await bodyParamsController.SendIntegerEnumArrayAsync(suites);
}
catch (ApiException e){};
```


# Update Model

```csharp
UpdateModelAsync(
    Models.Employee model)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `model` | [`Models.Employee`](/doc/models/employee.md) | Body, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
var model = new Employee();
model.Address = "address8";
model.Age = 186L;
model.Birthday = DateTime.Parse("2016-03-13");
model.Birthtime = DateTime.Parse("2016-03-13T12:52:32.123Z");
model.Name = "name2";
model.Uid = "uid2";
model.Department = "department8";
model.Dependents = new List<Person>();

var modelDependents0 = new Person();
modelDependents0.Address = "address5";
modelDependents0.Age = 237L;
modelDependents0.Birthday = DateTime.Parse("2016-03-13");
modelDependents0.Birthtime = DateTime.Parse("2016-03-13T12:52:32.123Z");
modelDependents0.Name = "name9";
modelDependents0.Uid = "uid9";
model.Dependents.Add(modelDependents0);

model.HiredAt = DateTime.Parse("Mon, 15 Jun 2009 20:45:30 GMT");
model.JoiningDay = Days.Monday;
model.Salary = 240;
model.WorkingDays = new List<Days>();
model.WorkingDays.Add(Days.Thursday);
model.WorkingDays.Add(Days.Wednesday);
model.WorkingDays.Add(Days.Tuesday);
model.Boss = new Person();
model.Boss.Address = "address6";
model.Boss.Age = 158L;
model.Boss.Birthday = DateTime.Parse("2016-03-13");
model.Boss.Birthtime = DateTime.Parse("2016-03-13T12:52:32.123Z");
model.Boss.Name = "name0";
model.Boss.Uid = "uid0";

try
{
    ServerResponse result = await bodyParamsController.UpdateModelAsync(model);
}
catch (ApiException e){};
```


# Send Delete Body With Model

```csharp
SendDeleteBodyWithModelAsync(
    Models.Employee model)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `model` | [`Models.Employee`](/doc/models/employee.md) | Body, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
var model = new Employee();
model.Address = "address8";
model.Age = 186L;
model.Birthday = DateTime.Parse("2016-03-13");
model.Birthtime = DateTime.Parse("2016-03-13T12:52:32.123Z");
model.Name = "name2";
model.Uid = "uid2";
model.Department = "department8";
model.Dependents = new List<Person>();

var modelDependents0 = new Person();
modelDependents0.Address = "address5";
modelDependents0.Age = 237L;
modelDependents0.Birthday = DateTime.Parse("2016-03-13");
modelDependents0.Birthtime = DateTime.Parse("2016-03-13T12:52:32.123Z");
modelDependents0.Name = "name9";
modelDependents0.Uid = "uid9";
model.Dependents.Add(modelDependents0);

model.HiredAt = DateTime.Parse("Mon, 15 Jun 2009 20:45:30 GMT");
model.JoiningDay = Days.Monday;
model.Salary = 240;
model.WorkingDays = new List<Days>();
model.WorkingDays.Add(Days.Thursday);
model.WorkingDays.Add(Days.Wednesday);
model.WorkingDays.Add(Days.Tuesday);
model.Boss = new Person();
model.Boss.Address = "address6";
model.Boss.Age = 158L;
model.Boss.Birthday = DateTime.Parse("2016-03-13");
model.Boss.Birthtime = DateTime.Parse("2016-03-13T12:52:32.123Z");
model.Boss.Name = "name0";
model.Boss.Uid = "uid0";

try
{
    ServerResponse result = await bodyParamsController.SendDeleteBodyWithModelAsync(model);
}
catch (ApiException e){};
```


# Send Delete Body With Model Array

```csharp
SendDeleteBodyWithModelArrayAsync(
    List<Models.Employee> models)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `models` | [`List<Models.Employee>`](/doc/models/employee.md) | Body, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
var models = new List<Employee>();

var models0 = new Employee();
models0.Address = "address2";
models0.Age = 254L;
models0.Birthday = DateTime.Parse("2016-03-13");
models0.Birthtime = DateTime.Parse("2016-03-13T12:52:32.123Z");
models0.Name = "name6";
models0.Uid = "uid6";
models0.Department = "department6";
models0.Dependents = new List<Person>();

var models0Dependents0 = new Person();
models0Dependents0.Address = "address9";
models0Dependents0.Age = 49L;
models0Dependents0.Birthday = DateTime.Parse("2016-03-13");
models0Dependents0.Birthtime = DateTime.Parse("2016-03-13T12:52:32.123Z");
models0Dependents0.Name = "name3";
models0Dependents0.Uid = "uid3";
models0.Dependents.Add(models0Dependents0);

var models0Dependents1 = new Person();
models0Dependents1.Address = "address0";
models0Dependents1.Age = 50L;
models0Dependents1.Birthday = DateTime.Parse("2016-03-13");
models0Dependents1.Birthtime = DateTime.Parse("2016-03-13T12:52:32.123Z");
models0Dependents1.Name = "name4";
models0Dependents1.Uid = "uid4";
models0.Dependents.Add(models0Dependents1);

var models0Dependents2 = new Person();
models0Dependents2.Address = "address1";
models0Dependents2.Age = 51L;
models0Dependents2.Birthday = DateTime.Parse("2016-03-13");
models0Dependents2.Birthtime = DateTime.Parse("2016-03-13T12:52:32.123Z");
models0Dependents2.Name = "name5";
models0Dependents2.Uid = "uid5";
models0.Dependents.Add(models0Dependents2);

models0.HiredAt = DateTime.Parse("Mon, 15 Jun 2009 20:45:30 GMT");
models0.JoiningDay = Days.Monday;
models0.Salary = 84;
models0.WorkingDays = new List<Days>();
models0.WorkingDays.Add(Days.Sunday);
models0.Boss = new Person();
models0.Boss.Address = "address0";
models0.Boss.Age = 154L;
models0.Boss.Birthday = DateTime.Parse("2016-03-13");
models0.Boss.Birthtime = DateTime.Parse("2016-03-13T12:52:32.123Z");
models0.Boss.Name = "name4";
models0.Boss.Uid = "uid4";
models.Add(models0);

var models1 = new Employee();
models1.Address = "address3";
models1.Age = 255L;
models1.Birthday = DateTime.Parse("2016-03-13");
models1.Birthtime = DateTime.Parse("2016-03-13T12:52:32.123Z");
models1.Name = "name7";
models1.Uid = "uid7";
models1.Department = "department7";
models1.Dependents = new List<Person>();

var models1Dependents0 = new Person();
models1Dependents0.Address = "address0";
models1Dependents0.Age = 50L;
models1Dependents0.Birthday = DateTime.Parse("2016-03-13");
models1Dependents0.Birthtime = DateTime.Parse("2016-03-13T12:52:32.123Z");
models1Dependents0.Name = "name4";
models1Dependents0.Uid = "uid4";
models1.Dependents.Add(models1Dependents0);

models1.HiredAt = DateTime.Parse("Mon, 15 Jun 2009 20:45:30 GMT");
models1.JoiningDay = Days.Monday;
models1.Salary = 85;
models1.WorkingDays = new List<Days>();
models1.WorkingDays.Add(Days.Monday);
models1.WorkingDays.Add(Days.Tuesday);
models1.Boss = new Person();
models1.Boss.Address = "address1";
models1.Boss.Age = 155L;
models1.Boss.Birthday = DateTime.Parse("2016-03-13");
models1.Boss.Birthtime = DateTime.Parse("2016-03-13T12:52:32.123Z");
models1.Boss.Name = "name5";
models1.Boss.Uid = "uid5";
models.Add(models1);


try
{
    ServerResponse result = await bodyParamsController.SendDeleteBodyWithModelArrayAsync(models);
}
catch (ApiException e){};
```


# Update Model Array

```csharp
UpdateModelArrayAsync(
    List<Models.Employee> models)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `models` | [`List<Models.Employee>`](/doc/models/employee.md) | Body, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
var models = new List<Employee>();

var models0 = new Employee();
models0.Address = "address2";
models0.Age = 254L;
models0.Birthday = DateTime.Parse("2016-03-13");
models0.Birthtime = DateTime.Parse("2016-03-13T12:52:32.123Z");
models0.Name = "name6";
models0.Uid = "uid6";
models0.Department = "department6";
models0.Dependents = new List<Person>();

var models0Dependents0 = new Person();
models0Dependents0.Address = "address9";
models0Dependents0.Age = 49L;
models0Dependents0.Birthday = DateTime.Parse("2016-03-13");
models0Dependents0.Birthtime = DateTime.Parse("2016-03-13T12:52:32.123Z");
models0Dependents0.Name = "name3";
models0Dependents0.Uid = "uid3";
models0.Dependents.Add(models0Dependents0);

var models0Dependents1 = new Person();
models0Dependents1.Address = "address0";
models0Dependents1.Age = 50L;
models0Dependents1.Birthday = DateTime.Parse("2016-03-13");
models0Dependents1.Birthtime = DateTime.Parse("2016-03-13T12:52:32.123Z");
models0Dependents1.Name = "name4";
models0Dependents1.Uid = "uid4";
models0.Dependents.Add(models0Dependents1);

var models0Dependents2 = new Person();
models0Dependents2.Address = "address1";
models0Dependents2.Age = 51L;
models0Dependents2.Birthday = DateTime.Parse("2016-03-13");
models0Dependents2.Birthtime = DateTime.Parse("2016-03-13T12:52:32.123Z");
models0Dependents2.Name = "name5";
models0Dependents2.Uid = "uid5";
models0.Dependents.Add(models0Dependents2);

models0.HiredAt = DateTime.Parse("Mon, 15 Jun 2009 20:45:30 GMT");
models0.JoiningDay = Days.Monday;
models0.Salary = 84;
models0.WorkingDays = new List<Days>();
models0.WorkingDays.Add(Days.Sunday);
models0.Boss = new Person();
models0.Boss.Address = "address0";
models0.Boss.Age = 154L;
models0.Boss.Birthday = DateTime.Parse("2016-03-13");
models0.Boss.Birthtime = DateTime.Parse("2016-03-13T12:52:32.123Z");
models0.Boss.Name = "name4";
models0.Boss.Uid = "uid4";
models.Add(models0);

var models1 = new Employee();
models1.Address = "address3";
models1.Age = 255L;
models1.Birthday = DateTime.Parse("2016-03-13");
models1.Birthtime = DateTime.Parse("2016-03-13T12:52:32.123Z");
models1.Name = "name7";
models1.Uid = "uid7";
models1.Department = "department7";
models1.Dependents = new List<Person>();

var models1Dependents0 = new Person();
models1Dependents0.Address = "address0";
models1Dependents0.Age = 50L;
models1Dependents0.Birthday = DateTime.Parse("2016-03-13");
models1Dependents0.Birthtime = DateTime.Parse("2016-03-13T12:52:32.123Z");
models1Dependents0.Name = "name4";
models1Dependents0.Uid = "uid4";
models1.Dependents.Add(models1Dependents0);

models1.HiredAt = DateTime.Parse("Mon, 15 Jun 2009 20:45:30 GMT");
models1.JoiningDay = Days.Monday;
models1.Salary = 85;
models1.WorkingDays = new List<Days>();
models1.WorkingDays.Add(Days.Monday);
models1.WorkingDays.Add(Days.Tuesday);
models1.Boss = new Person();
models1.Boss.Address = "address1";
models1.Boss.Age = 155L;
models1.Boss.Birthday = DateTime.Parse("2016-03-13");
models1.Boss.Birthtime = DateTime.Parse("2016-03-13T12:52:32.123Z");
models1.Boss.Name = "name5";
models1.Boss.Uid = "uid5";
models.Add(models1);


try
{
    ServerResponse result = await bodyParamsController.UpdateModelArrayAsync(models);
}
catch (ApiException e){};
```


# Update String 1

```csharp
UpdateString1Async(
    string mValue)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `mValue` | `string` | Body, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
string mValue = "value2";

try
{
    ServerResponse result = await bodyParamsController.UpdateString1Async(mValue);
}
catch (ApiException e){};
```


# Update String Array

```csharp
UpdateStringArrayAsync(
    List<string> strings)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `strings` | `List<string>` | Body, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
var strings = new List<string>();
strings.Add("strings5");

try
{
    ServerResponse result = await bodyParamsController.UpdateStringArrayAsync(strings);
}
catch (ApiException e){};
```


# Send String With New Line

```csharp
SendStringWithNewLineAsync(
    Models.TestNstringEncoding body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Models.TestNstringEncoding`](/doc/models/test-nstring-encoding.md) | Body, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
var body = new TestNstringEncoding();
body.Field = "field0";
body.Name = "name6";

try
{
    ServerResponse result = await bodyParamsController.SendStringWithNewLineAsync(body);
}
catch (ApiException e){};
```


# Send String With R

```csharp
SendStringWithRAsync(
    Models.TestRstringEncoding body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Models.TestRstringEncoding`](/doc/models/test-rstring-encoding.md) | Body, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
var body = new TestRstringEncoding();
body.Field = "field0";
body.Name = "name6";

try
{
    ServerResponse result = await bodyParamsController.SendStringWithRAsync(body);
}
catch (ApiException e){};
```


# Send String in Body With R N

```csharp
SendStringInBodyWithRNAsync(
    Models.TestRNstringEncoding body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Models.TestRNstringEncoding`](/doc/models/test-r-nstring-encoding.md) | Body, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
var body = new TestRNstringEncoding();
body.Field = "field0";
body.Name = "name6";

try
{
    ServerResponse result = await bodyParamsController.SendStringInBodyWithRNAsync(body);
}
catch (ApiException e){};
```


# Send Optional Unix Date Time in Body

```csharp
SendOptionalUnixDateTimeInBodyAsync(
    DateTime? dateTime = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `dateTime` | `DateTime?` | Body, Optional | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
DateTime? dateTime = DateTime.Parse("Liquid error: Object of type 'System.Int64' cannot be converted to type 'System.String'.");

try
{
    ServerResponse result = await bodyParamsController.SendOptionalUnixDateTimeInBodyAsync(dateTime);
}
catch (ApiException e){};
```


# Send Optional Rfc 1123 in Body

```csharp
SendOptionalRfc1123InBodyAsync(
    DateTime body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | `DateTime` | Body, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
DateTime body = DateTime.Parse("Sun, 06 Nov 1994 08:49:37 GMT");

try
{
    ServerResponse result = await bodyParamsController.SendOptionalRfc1123InBodyAsync(body);
}
catch (ApiException e){};
```


# Send Datetime Optional in Endpoint

```csharp
SendDatetimeOptionalInEndpointAsync(
    DateTime? body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | `DateTime?` | Body, Optional | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
try
{
    ServerResponse result = await bodyParamsController.SendDatetimeOptionalInEndpointAsync(null);
}
catch (ApiException e){};
```


# Send Optional Unix Time Stamp in Model Body

```csharp
SendOptionalUnixTimeStampInModelBodyAsync(
    Models.UnixDateTime dateTime)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `dateTime` | [`Models.UnixDateTime`](/doc/models/unix-date-time.md) | Body, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
var dateTime = new UnixDateTime();
dateTime.DateTime = DateTime.Parse("Liquid error: Object of type 'System.Int64' cannot be converted to type 'System.String'.");

try
{
    ServerResponse result = await bodyParamsController.SendOptionalUnixTimeStampInModelBodyAsync(dateTime);
}
catch (ApiException e){};
```


# Send Optional Unix Time Stamp in Nested Model Body

```csharp
SendOptionalUnixTimeStampInNestedModelBodyAsync(
    Models.SendUnixDateTime dateTime)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `dateTime` | [`Models.SendUnixDateTime`](/doc/models/send-unix-date-time.md) | Body, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
var dateTime = new SendUnixDateTime();
dateTime.DateTime = new UnixDateTime();
dateTime.DateTime.DateTime = DateTime.Parse("Liquid error: Object of type 'System.Int64' cannot be converted to type 'System.String'.");

try
{
    ServerResponse result = await bodyParamsController.SendOptionalUnixTimeStampInNestedModelBodyAsync(dateTime);
}
catch (ApiException e){};
```


# Send Rfc 1123 Date Time in Nested Model

```csharp
SendRfc1123DateTimeInNestedModelAsync(
    Models.SendRfc1123DateTime body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Models.SendRfc1123DateTime`](/doc/models/send-rfc-1123-date-time.md) | Body, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
var body = new SendRfc1123DateTime();
body.DateTime = new ModelWithOptionalRfc1123DateTime();
body.DateTime.DateTime = DateTime.Parse("Sun, 06 Nov 1994 08:49:37 GMT");

try
{
    ServerResponse result = await bodyParamsController.SendRfc1123DateTimeInNestedModelAsync(body);
}
catch (ApiException e){};
```


# Send Rfc 1123 Date Time in Model

```csharp
SendRfc1123DateTimeInModelAsync(
    Models.ModelWithOptionalRfc1123DateTime dateTime)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `dateTime` | [`Models.ModelWithOptionalRfc1123DateTime`](/doc/models/model-with-optional-rfc-1123-date-time.md) | Body, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
var dateTime = new ModelWithOptionalRfc1123DateTime();
dateTime.DateTime = DateTime.Parse("Sun, 06 Nov 1994 08:49:37 GMT");

try
{
    ServerResponse result = await bodyParamsController.SendRfc1123DateTimeInModelAsync(dateTime);
}
catch (ApiException e){};
```


# Send Optional Datetime in Model

```csharp
SendOptionalDatetimeInModelAsync(
    Models.ModelWithOptionalRfc3339DateTime body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Models.ModelWithOptionalRfc3339DateTime`](/doc/models/model-with-optional-rfc-3339-date-time.md) | Body, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
var body = new ModelWithOptionalRfc3339DateTime();
body.DateTime = DateTime.Parse("1994-02-13T14:01:54.9571247Z");

try
{
    ServerResponse result = await bodyParamsController.SendOptionalDatetimeInModelAsync(body);
}
catch (ApiException e){};
```


# Send Rfc 339 Date Time in Nested Models

```csharp
SendRfc339DateTimeInNestedModelsAsync(
    Models.SendRfc339DateTime body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Models.SendRfc339DateTime`](/doc/models/send-rfc-339-date-time.md) | Body, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
var body = new SendRfc339DateTime();
body.DateTime = new ModelWithOptionalRfc3339DateTime();
body.DateTime.DateTime = DateTime.Parse("1994-02-13T14:01:54.9571247Z");

try
{
    ServerResponse result = await bodyParamsController.SendRfc339DateTimeInNestedModelsAsync(body);
}
catch (ApiException e){};
```


# Uuid as Optional

```csharp
UuidAsOptionalAsync(
    Models.UuidAsOptional body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Models.UuidAsOptional`](/doc/models/uuid-as-optional.md) | Body, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
var body = new UuidAsOptional();
body.Uuid = new Guid("123e4567-e89b-12d3-a456-426655440000");

try
{
    ServerResponse result = await bodyParamsController.UuidAsOptionalAsync(body);
}
catch (ApiException e){};
```


# Boolean as Optional

```csharp
BooleanAsOptionalAsync(
    Models.BooleanAsOptional body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Models.BooleanAsOptional`](/doc/models/boolean-as-optional.md) | Body, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
var body = new BooleanAsOptional();
body.Boolean = true;

try
{
    ServerResponse result = await bodyParamsController.BooleanAsOptionalAsync(body);
}
catch (ApiException e){};
```


# Date as Optional

```csharp
DateAsOptionalAsync(
    Models.DateAsOptional body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Models.DateAsOptional`](/doc/models/date-as-optional.md) | Body, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
var body = new DateAsOptional();
body.Date = DateTime.Parse("1994-02-13");

try
{
    ServerResponse result = await bodyParamsController.DateAsOptionalAsync(body);
}
catch (ApiException e){};
```


# Dynamic as Optional

```csharp
DynamicAsOptionalAsync(
    Models.DynamicAsOptional body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Models.DynamicAsOptional`](/doc/models/dynamic-as-optional.md) | Body, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
var body = new DynamicAsOptional();
body.MDynamic = ApiHelper.JsonDeserialize<Object>("{\"dynamic\":\"test\"}");

try
{
    ServerResponse result = await bodyParamsController.DynamicAsOptionalAsync(body);
}
catch (ApiException e){};
```


# String as Optional

```csharp
StringAsOptionalAsync(
    Models.StringAsOptional body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Models.StringAsOptional`](/doc/models/string-as-optional.md) | Body, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
var body = new StringAsOptional();
body.MString = "test";

try
{
    ServerResponse result = await bodyParamsController.StringAsOptionalAsync(body);
}
catch (ApiException e){};
```


# Precision as Optional

```csharp
PrecisionAsOptionalAsync(
    Models.PrecisionAsOptional body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Models.PrecisionAsOptional`](/doc/models/precision-as-optional.md) | Body, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
var body = new PrecisionAsOptional();
body.Precision = 1.23;

try
{
    ServerResponse result = await bodyParamsController.PrecisionAsOptionalAsync(body);
}
catch (ApiException e){};
```


# Long as Optional

```csharp
LongAsOptionalAsync(
    Models.LongAsOptional body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Models.LongAsOptional`](/doc/models/long-as-optional.md) | Body, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
var body = new LongAsOptional();
body.MLong = 123123L;

try
{
    ServerResponse result = await bodyParamsController.LongAsOptionalAsync(body);
}
catch (ApiException e){};
```


# Send Number as Optional

```csharp
SendNumberAsOptionalAsync(
    Models.NumberAsOptional body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Models.NumberAsOptional`](/doc/models/number-as-optional.md) | Body, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
var body = new NumberAsOptional();
body.Number = 1;

try
{
    ServerResponse result = await bodyParamsController.SendNumberAsOptionalAsync(body);
}
catch (ApiException e){};
```

