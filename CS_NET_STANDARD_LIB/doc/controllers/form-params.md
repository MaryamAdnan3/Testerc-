# Form Params

```csharp
IFormParamsController formParamsController = client.FormParamsController;
```

## Class Name

`FormParamsController`

## Methods

* [Send Delete Form](/doc/controllers/form-params.md#send-delete-form)
* [Send Delete Multipart](/doc/controllers/form-params.md#send-delete-multipart)
* [Send Date Array](/doc/controllers/form-params.md#send-date-array)
* [Send Date](/doc/controllers/form-params.md#send-date)
* [Send Unix Date Time](/doc/controllers/form-params.md#send-unix-date-time)
* [Send Rfc 1123 Date Time](/doc/controllers/form-params.md#send-rfc-1123-date-time)
* [Send Rfc 3339 Date Time](/doc/controllers/form-params.md#send-rfc-3339-date-time)
* [Send Unix Date Time Array](/doc/controllers/form-params.md#send-unix-date-time-array)
* [Send Rfc 1123 Date Time Array](/doc/controllers/form-params.md#send-rfc-1123-date-time-array)
* [Send Long](/doc/controllers/form-params.md#send-long)
* [Send Integer Array](/doc/controllers/form-params.md#send-integer-array)
* [Send String Array](/doc/controllers/form-params.md#send-string-array)
* [Allow Dynamic Form Fields](/doc/controllers/form-params.md#allow-dynamic-form-fields)
* [Send Model](/doc/controllers/form-params.md#send-model)
* [Send Model Array](/doc/controllers/form-params.md#send-model-array)
* [Send File](/doc/controllers/form-params.md#send-file)
* [Send Multiple Files](/doc/controllers/form-params.md#send-multiple-files)
* [Send String](/doc/controllers/form-params.md#send-string)
* [Send Rfc 3339 Date Time Array](/doc/controllers/form-params.md#send-rfc-3339-date-time-array)
* [Send Mixed Array](/doc/controllers/form-params.md#send-mixed-array)
* [Update Model With Form](/doc/controllers/form-params.md#update-model-with-form)
* [Send Delete Form 1](/doc/controllers/form-params.md#send-delete-form-1)
* [Send Delete Form With Model Array](/doc/controllers/form-params.md#send-delete-form-with-model-array)
* [Update Model Array With Form](/doc/controllers/form-params.md#update-model-array-with-form)
* [Update String With Form](/doc/controllers/form-params.md#update-string-with-form)
* [Update String Array With Form](/doc/controllers/form-params.md#update-string-array-with-form)
* [Send Integer Enum Array](/doc/controllers/form-params.md#send-integer-enum-array)
* [Send String Enum Array](/doc/controllers/form-params.md#send-string-enum-array)
* [Send String in Form With New Line](/doc/controllers/form-params.md#send-string-in-form-with-new-line)
* [Send String in Form With R](/doc/controllers/form-params.md#send-string-in-form-with-r)
* [Send String in Form With R N](/doc/controllers/form-params.md#send-string-in-form-with-r-n)
* [Send Optional Unix Date Time in Body](/doc/controllers/form-params.md#send-optional-unix-date-time-in-body)
* [Send Optional Rfc 1123 in Body](/doc/controllers/form-params.md#send-optional-rfc-1123-in-body)
* [Send Datetime Optional in Endpoint](/doc/controllers/form-params.md#send-datetime-optional-in-endpoint)
* [Send Optional Unix Time Stamp in Model Body](/doc/controllers/form-params.md#send-optional-unix-time-stamp-in-model-body)
* [Send Optional Unix Time Stamp in Nested Model Body](/doc/controllers/form-params.md#send-optional-unix-time-stamp-in-nested-model-body)
* [Send Rfc 1123 Date Time in Nested Model](/doc/controllers/form-params.md#send-rfc-1123-date-time-in-nested-model)
* [Send Rfc 1123 Date Time in Model](/doc/controllers/form-params.md#send-rfc-1123-date-time-in-model)
* [Send Optional Datetime in Model](/doc/controllers/form-params.md#send-optional-datetime-in-model)
* [Send Rfc 339 Date Time in Nested Models](/doc/controllers/form-params.md#send-rfc-339-date-time-in-nested-models)
* [Uuid as Optional](/doc/controllers/form-params.md#uuid-as-optional)
* [Boolean as Optional](/doc/controllers/form-params.md#boolean-as-optional)
* [Date as Optional](/doc/controllers/form-params.md#date-as-optional)
* [Dynamic as Optional](/doc/controllers/form-params.md#dynamic-as-optional)
* [String as Optional](/doc/controllers/form-params.md#string-as-optional)
* [Precision as Optional](/doc/controllers/form-params.md#precision-as-optional)
* [Long as Optional](/doc/controllers/form-params.md#long-as-optional)
* [Send Number as Optional](/doc/controllers/form-params.md#send-number-as-optional)


# Send Delete Form

```csharp
SendDeleteFormAsync(
    Models.DeleteBody body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Models.DeleteBody`](/doc/models/delete-body.md) | Form, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
var body = new DeleteBody();
body.Name = "name6";
body.Field = "field0";

try
{
    ServerResponse result = await formParamsController.SendDeleteFormAsync(body);
}
catch (ApiException e){};
```


# Send Delete Multipart

```csharp
SendDeleteMultipartAsync(
    FileStreamInfo file)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `file` | `FileStreamInfo` | Form, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
FileStreamInfo file = new FileStreamInfo(new FileStream("dummy_file",FileMode.Open));

try
{
    ServerResponse result = await formParamsController.SendDeleteMultipartAsync(file);
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
| `dates` | `List<DateTime>` | Form, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
var dates = new List<DateTime>();
dates.Add(DateTime.Parse("2016-03-13"));
dates.Add(DateTime.Parse("2016-03-13"));

try
{
    ServerResponse result = await formParamsController.SendDateArrayAsync(dates);
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
| `date` | `DateTime` | Form, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
DateTime date = DateTime.Parse("2016-03-13");

try
{
    ServerResponse result = await formParamsController.SendDateAsync(date);
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
| `datetime` | `DateTime` | Form, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
DateTime datetime = DateTime.Parse("Liquid error: Object of type 'System.Int64' cannot be converted to type 'System.String'.");

try
{
    ServerResponse result = await formParamsController.SendUnixDateTimeAsync(datetime);
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
| `datetime` | `DateTime` | Form, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
DateTime datetime = DateTime.Parse("Mon, 15 Jun 2009 20:45:30 GMT");

try
{
    ServerResponse result = await formParamsController.SendRfc1123DateTimeAsync(datetime);
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
| `datetime` | `DateTime` | Form, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
DateTime datetime = DateTime.Parse("2016-03-13T12:52:32.123Z");

try
{
    ServerResponse result = await formParamsController.SendRfc3339DateTimeAsync(datetime);
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
| `datetimes` | `List<DateTime>` | Form, Required | - |

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
    ServerResponse result = await formParamsController.SendUnixDateTimeArrayAsync(datetimes);
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
| `datetimes` | `List<DateTime>` | Form, Required | - |

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
    ServerResponse result = await formParamsController.SendRfc1123DateTimeArrayAsync(datetimes);
}
catch (ApiException e){};
```


# Send Long

```csharp
SendLongAsync(
    long mValue)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `mValue` | `long` | Form, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
long mValue = 64L;

try
{
    ServerResponse result = await formParamsController.SendLongAsync(mValue);
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
| `integers` | `List<int>` | Form, Required | - |

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
    ServerResponse result = await formParamsController.SendIntegerArrayAsync(integers);
}
catch (ApiException e){};
```


# Send String Array

```csharp
SendStringArrayAsync(
    List<string> strings)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `strings` | `List<string>` | Form, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
var strings = new List<string>();
strings.Add("strings5");

try
{
    ServerResponse result = await formParamsController.SendStringArrayAsync(strings);
}
catch (ApiException e){};
```


# Allow Dynamic Form Fields

```csharp
AllowDynamicFormFieldsAsync(
    string name,
    Dictionary<string, object> fieldParameters = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `name` | `string` | Form, Required | - |
| `fieldParameters` | `Dictionary<string, object>` | Optional | Pass additional field parameters. |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
string name = "name0";
var fieldParameters = new Dictionary<string, Object>();
fieldParameters.Add("key0", "additionalFieldParams9");

try
{
    ServerResponse result = await formParamsController.AllowDynamicFormFieldsAsync(name, fieldParameters);
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
| `model` | [`Models.Employee`](/doc/models/employee.md) | Form, Required | - |

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
    ServerResponse result = await formParamsController.SendModelAsync(model);
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
| `models` | [`List<Models.Employee>`](/doc/models/employee.md) | Form, Required | - |

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
    ServerResponse result = await formParamsController.SendModelArrayAsync(models);
}
catch (ApiException e){};
```


# Send File

```csharp
SendFileAsync(
    FileStreamInfo file)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `file` | `FileStreamInfo` | Form, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
FileStreamInfo file = new FileStreamInfo(new FileStream("dummy_file",FileMode.Open));

try
{
    ServerResponse result = await formParamsController.SendFileAsync(file);
}
catch (ApiException e){};
```


# Send Multiple Files

```csharp
SendMultipleFilesAsync(
    FileStreamInfo file,
    FileStreamInfo file1)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `file` | `FileStreamInfo` | Form, Required | - |
| `file1` | `FileStreamInfo` | Form, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
FileStreamInfo file = new FileStreamInfo(new FileStream("dummy_file",FileMode.Open));
FileStreamInfo file1 = new FileStreamInfo(new FileStream("dummy_file",FileMode.Open));

try
{
    ServerResponse result = await formParamsController.SendMultipleFilesAsync(file, file1);
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
| `mValue` | `string` | Form, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
string mValue = "value2";

try
{
    ServerResponse result = await formParamsController.SendStringAsync(mValue);
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
| `datetimes` | `List<DateTime>` | Form, Required | - |

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
    ServerResponse result = await formParamsController.SendRfc3339DateTimeArrayAsync(datetimes);
}
catch (ApiException e){};
```


# Send Mixed Array

Send a variety for form params. Returns file count and body params

```csharp
SendMixedArrayAsync(
    Models.SendMixedArrayInput input)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `file` | `FileStreamInfo` | Form, Required | - |
| `integers` | `List<int>` | Form, Required | - |
| `models` | [`List<Models.Employee>`](/doc/models/employee.md) | Form, Required | - |
| `strings` | `List<string>` | Form, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
var sendMixedArrayInput = new SendMixedArrayInput();

sendMixedArrayInput.File = new FileStreamInfo(new FileStream("dummy_file",FileMode.Open));
sendMixedArrayInput.Integers = new List<int>();
sendMixedArrayInput.Integers.Add(45);
sendMixedArrayInput.Integers.Add(46);
sendMixedArrayInput.Integers.Add(47);
sendMixedArrayInput.Models = new List<Employee>();

var sendMixedArrayInputModels0 = new Employee();
sendMixedArrayInputModels0.Address = "address2";
sendMixedArrayInputModels0.Age = 254L;
sendMixedArrayInputModels0.Birthday = DateTime.Parse("2016-03-13");
sendMixedArrayInputModels0.Birthtime = DateTime.Parse("2016-03-13T12:52:32.123Z");
sendMixedArrayInputModels0.Name = "name6";
sendMixedArrayInputModels0.Uid = "uid6";
sendMixedArrayInputModels0.Department = "department6";
sendMixedArrayInputModels0.Dependents = new List<Person>();

var sendMixedArrayInputModels0Dependents0 = new Person();
sendMixedArrayInputModels0Dependents0.Address = "address9";
sendMixedArrayInputModels0Dependents0.Age = 49L;
sendMixedArrayInputModels0Dependents0.Birthday = DateTime.Parse("2016-03-13");
sendMixedArrayInputModels0Dependents0.Birthtime = DateTime.Parse("2016-03-13T12:52:32.123Z");
sendMixedArrayInputModels0Dependents0.Name = "name3";
sendMixedArrayInputModels0Dependents0.Uid = "uid3";
sendMixedArrayInputModels0.Dependents.Add(sendMixedArrayInputModels0Dependents0);

var sendMixedArrayInputModels0Dependents1 = new Person();
sendMixedArrayInputModels0Dependents1.Address = "address0";
sendMixedArrayInputModels0Dependents1.Age = 50L;
sendMixedArrayInputModels0Dependents1.Birthday = DateTime.Parse("2016-03-13");
sendMixedArrayInputModels0Dependents1.Birthtime = DateTime.Parse("2016-03-13T12:52:32.123Z");
sendMixedArrayInputModels0Dependents1.Name = "name4";
sendMixedArrayInputModels0Dependents1.Uid = "uid4";
sendMixedArrayInputModels0.Dependents.Add(sendMixedArrayInputModels0Dependents1);

var sendMixedArrayInputModels0Dependents2 = new Person();
sendMixedArrayInputModels0Dependents2.Address = "address1";
sendMixedArrayInputModels0Dependents2.Age = 51L;
sendMixedArrayInputModels0Dependents2.Birthday = DateTime.Parse("2016-03-13");
sendMixedArrayInputModels0Dependents2.Birthtime = DateTime.Parse("2016-03-13T12:52:32.123Z");
sendMixedArrayInputModels0Dependents2.Name = "name5";
sendMixedArrayInputModels0Dependents2.Uid = "uid5";
sendMixedArrayInputModels0.Dependents.Add(sendMixedArrayInputModels0Dependents2);

sendMixedArrayInputModels0.HiredAt = DateTime.Parse("Mon, 15 Jun 2009 20:45:30 GMT");
sendMixedArrayInputModels0.JoiningDay = Days.Monday;
sendMixedArrayInputModels0.Salary = 84;
sendMixedArrayInputModels0.WorkingDays = new List<Days>();
sendMixedArrayInputModels0.WorkingDays.Add(Days.Sunday);
sendMixedArrayInputModels0.Boss = new Person();
sendMixedArrayInputModels0.Boss.Address = "address0";
sendMixedArrayInputModels0.Boss.Age = 154L;
sendMixedArrayInputModels0.Boss.Birthday = DateTime.Parse("2016-03-13");
sendMixedArrayInputModels0.Boss.Birthtime = DateTime.Parse("2016-03-13T12:52:32.123Z");
sendMixedArrayInputModels0.Boss.Name = "name4";
sendMixedArrayInputModels0.Boss.Uid = "uid4";
sendMixedArrayInput.Models.Add(sendMixedArrayInputModels0);

var sendMixedArrayInputModels1 = new Employee();
sendMixedArrayInputModels1.Address = "address3";
sendMixedArrayInputModels1.Age = 255L;
sendMixedArrayInputModels1.Birthday = DateTime.Parse("2016-03-13");
sendMixedArrayInputModels1.Birthtime = DateTime.Parse("2016-03-13T12:52:32.123Z");
sendMixedArrayInputModels1.Name = "name7";
sendMixedArrayInputModels1.Uid = "uid7";
sendMixedArrayInputModels1.Department = "department7";
sendMixedArrayInputModels1.Dependents = new List<Person>();

var sendMixedArrayInputModels1Dependents0 = new Person();
sendMixedArrayInputModels1Dependents0.Address = "address0";
sendMixedArrayInputModels1Dependents0.Age = 50L;
sendMixedArrayInputModels1Dependents0.Birthday = DateTime.Parse("2016-03-13");
sendMixedArrayInputModels1Dependents0.Birthtime = DateTime.Parse("2016-03-13T12:52:32.123Z");
sendMixedArrayInputModels1Dependents0.Name = "name4";
sendMixedArrayInputModels1Dependents0.Uid = "uid4";
sendMixedArrayInputModels1.Dependents.Add(sendMixedArrayInputModels1Dependents0);

sendMixedArrayInputModels1.HiredAt = DateTime.Parse("Mon, 15 Jun 2009 20:45:30 GMT");
sendMixedArrayInputModels1.JoiningDay = Days.Monday;
sendMixedArrayInputModels1.Salary = 85;
sendMixedArrayInputModels1.WorkingDays = new List<Days>();
sendMixedArrayInputModels1.WorkingDays.Add(Days.Monday);
sendMixedArrayInputModels1.WorkingDays.Add(Days.Tuesday);
sendMixedArrayInputModels1.Boss = new Person();
sendMixedArrayInputModels1.Boss.Address = "address1";
sendMixedArrayInputModels1.Boss.Age = 155L;
sendMixedArrayInputModels1.Boss.Birthday = DateTime.Parse("2016-03-13");
sendMixedArrayInputModels1.Boss.Birthtime = DateTime.Parse("2016-03-13T12:52:32.123Z");
sendMixedArrayInputModels1.Boss.Name = "name5";
sendMixedArrayInputModels1.Boss.Uid = "uid5";
sendMixedArrayInput.Models.Add(sendMixedArrayInputModels1);

sendMixedArrayInput.Strings = new List<string>();
sendMixedArrayInput.Strings.Add("strings5");

try
{
    ServerResponse result = await formParamsController.SendMixedArrayAsync(sendMixedArrayInput);
}
catch (ApiException e){};
```


# Update Model With Form

```csharp
UpdateModelWithFormAsync(
    Models.Employee model)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `model` | [`Models.Employee`](/doc/models/employee.md) | Form, Required | - |

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
    ServerResponse result = await formParamsController.UpdateModelWithFormAsync(model);
}
catch (ApiException e){};
```


# Send Delete Form 1

```csharp
SendDeleteForm1Async(
    Models.Employee model)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `model` | [`Models.Employee`](/doc/models/employee.md) | Form, Required | - |

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
    ServerResponse result = await formParamsController.SendDeleteForm1Async(model);
}
catch (ApiException e){};
```


# Send Delete Form With Model Array

```csharp
SendDeleteFormWithModelArrayAsync(
    List<Models.Employee> models)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `models` | [`List<Models.Employee>`](/doc/models/employee.md) | Form, Required | - |

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
    ServerResponse result = await formParamsController.SendDeleteFormWithModelArrayAsync(models);
}
catch (ApiException e){};
```


# Update Model Array With Form

```csharp
UpdateModelArrayWithFormAsync(
    List<Models.Employee> models)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `models` | [`List<Models.Employee>`](/doc/models/employee.md) | Form, Required | - |

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
    ServerResponse result = await formParamsController.UpdateModelArrayWithFormAsync(models);
}
catch (ApiException e){};
```


# Update String With Form

```csharp
UpdateStringWithFormAsync(
    string mValue)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `mValue` | `string` | Form, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
string mValue = "value2";

try
{
    ServerResponse result = await formParamsController.UpdateStringWithFormAsync(mValue);
}
catch (ApiException e){};
```


# Update String Array With Form

```csharp
UpdateStringArrayWithFormAsync(
    List<string> strings)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `strings` | `List<string>` | Form, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
var strings = new List<string>();
strings.Add("strings5");

try
{
    ServerResponse result = await formParamsController.UpdateStringArrayWithFormAsync(strings);
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
| `suites` | [`List<Models.SuiteCode>`](/doc/models/suite-code.md) | Form, Required | - |

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
    ServerResponse result = await formParamsController.SendIntegerEnumArrayAsync(suites);
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
| `days` | [`List<Models.Days>`](/doc/models/days.md) | Form, Required | - |

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
    ServerResponse result = await formParamsController.SendStringEnumArrayAsync(days);
}
catch (ApiException e){};
```


# Send String in Form With New Line

```csharp
SendStringInFormWithNewLineAsync(
    Models.TestNstringEncoding body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Models.TestNstringEncoding`](/doc/models/test-nstring-encoding.md) | Form, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
var body = new TestNstringEncoding();
body.Field = "field0";
body.Name = "name6";

try
{
    ServerResponse result = await formParamsController.SendStringInFormWithNewLineAsync(body);
}
catch (ApiException e){};
```


# Send String in Form With R

```csharp
SendStringInFormWithRAsync(
    Models.TestRstringEncoding body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Models.TestRstringEncoding`](/doc/models/test-rstring-encoding.md) | Form, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
var body = new TestRstringEncoding();
body.Field = "field0";
body.Name = "name6";

try
{
    ServerResponse result = await formParamsController.SendStringInFormWithRAsync(body);
}
catch (ApiException e){};
```


# Send String in Form With R N

```csharp
SendStringInFormWithRNAsync(
    Models.TestRNstringEncoding body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Models.TestRNstringEncoding`](/doc/models/test-r-nstring-encoding.md) | Form, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
var body = new TestRNstringEncoding();
body.Field = "field0";
body.Name = "name6";

try
{
    ServerResponse result = await formParamsController.SendStringInFormWithRNAsync(body);
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
| `dateTime` | `DateTime?` | Form, Optional | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
DateTime? dateTime = DateTime.Parse("Liquid error: Object of type 'System.Int64' cannot be converted to type 'System.String'.");

try
{
    ServerResponse result = await formParamsController.SendOptionalUnixDateTimeInBodyAsync(dateTime);
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
| `body` | `DateTime` | Form, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
DateTime body = DateTime.Parse("Sun, 06 Nov 1994 08:49:37 GMT");

try
{
    ServerResponse result = await formParamsController.SendOptionalRfc1123InBodyAsync(body);
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
| `body` | `DateTime?` | Form, Optional | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
try
{
    ServerResponse result = await formParamsController.SendDatetimeOptionalInEndpointAsync(null);
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
| `dateTime` | [`Models.UnixDateTime`](/doc/models/unix-date-time.md) | Form, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
var dateTime = new UnixDateTime();
dateTime.DateTime = DateTime.Parse("Liquid error: Object of type 'System.Int64' cannot be converted to type 'System.String'.");

try
{
    ServerResponse result = await formParamsController.SendOptionalUnixTimeStampInModelBodyAsync(dateTime);
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
| `dateTime` | [`Models.SendUnixDateTime`](/doc/models/send-unix-date-time.md) | Form, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
var dateTime = new SendUnixDateTime();
dateTime.DateTime = new UnixDateTime();
dateTime.DateTime.DateTime = DateTime.Parse("Liquid error: Object of type 'System.Int64' cannot be converted to type 'System.String'.");

try
{
    ServerResponse result = await formParamsController.SendOptionalUnixTimeStampInNestedModelBodyAsync(dateTime);
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
| `body` | [`Models.SendRfc1123DateTime`](/doc/models/send-rfc-1123-date-time.md) | Form, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
var body = new SendRfc1123DateTime();
body.DateTime = new ModelWithOptionalRfc1123DateTime();
body.DateTime.DateTime = DateTime.Parse("Sun, 06 Nov 1994 08:49:37 GMT");

try
{
    ServerResponse result = await formParamsController.SendRfc1123DateTimeInNestedModelAsync(body);
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
| `dateTime` | [`Models.ModelWithOptionalRfc1123DateTime`](/doc/models/model-with-optional-rfc-1123-date-time.md) | Form, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
var dateTime = new ModelWithOptionalRfc1123DateTime();
dateTime.DateTime = DateTime.Parse("Sun, 06 Nov 1994 08:49:37 GMT");

try
{
    ServerResponse result = await formParamsController.SendRfc1123DateTimeInModelAsync(dateTime);
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
| `body` | [`Models.ModelWithOptionalRfc3339DateTime`](/doc/models/model-with-optional-rfc-3339-date-time.md) | Form, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
var body = new ModelWithOptionalRfc3339DateTime();
body.DateTime = DateTime.Parse("1994-02-13T14:01:54.9571247Z");

try
{
    ServerResponse result = await formParamsController.SendOptionalDatetimeInModelAsync(body);
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
| `body` | [`Models.SendRfc339DateTime`](/doc/models/send-rfc-339-date-time.md) | Form, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
var body = new SendRfc339DateTime();
body.DateTime = new ModelWithOptionalRfc3339DateTime();
body.DateTime.DateTime = DateTime.Parse("1994-02-13T14:01:54.9571247Z");

try
{
    ServerResponse result = await formParamsController.SendRfc339DateTimeInNestedModelsAsync(body);
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
| `body` | [`Models.UuidAsOptional`](/doc/models/uuid-as-optional.md) | Form, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
var body = new UuidAsOptional();
body.Uuid = new Guid("123e4567-e89b-12d3-a456-426655440000");

try
{
    ServerResponse result = await formParamsController.UuidAsOptionalAsync(body);
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
| `body` | [`Models.BooleanAsOptional`](/doc/models/boolean-as-optional.md) | Form, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
var body = new BooleanAsOptional();
body.Boolean = true;

try
{
    ServerResponse result = await formParamsController.BooleanAsOptionalAsync(body);
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
| `body` | [`Models.DateAsOptional`](/doc/models/date-as-optional.md) | Form, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
var body = new DateAsOptional();
body.Date = DateTime.Parse("1994-02-13");

try
{
    ServerResponse result = await formParamsController.DateAsOptionalAsync(body);
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
| `body` | [`Models.DynamicAsOptional`](/doc/models/dynamic-as-optional.md) | Form, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
var body = new DynamicAsOptional();
body.MDynamic = ApiHelper.JsonDeserialize<Object>("{\"dynamic\":\"test\"}");

try
{
    ServerResponse result = await formParamsController.DynamicAsOptionalAsync(body);
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
| `body` | [`Models.StringAsOptional`](/doc/models/string-as-optional.md) | Form, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
var body = new StringAsOptional();
body.MString = "test";

try
{
    ServerResponse result = await formParamsController.StringAsOptionalAsync(body);
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
| `body` | [`Models.PrecisionAsOptional`](/doc/models/precision-as-optional.md) | Form, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
var body = new PrecisionAsOptional();
body.Precision = 1.23;

try
{
    ServerResponse result = await formParamsController.PrecisionAsOptionalAsync(body);
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
| `body` | [`Models.LongAsOptional`](/doc/models/long-as-optional.md) | Form, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
var body = new LongAsOptional();
body.MLong = 123123L;

try
{
    ServerResponse result = await formParamsController.LongAsOptionalAsync(body);
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
| `body` | [`Models.NumberAsOptional`](/doc/models/number-as-optional.md) | Form, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](/doc/models/server-response.md)

## Example Usage

```csharp
var body = new NumberAsOptional();
body.Number = 1;

try
{
    ServerResponse result = await formParamsController.SendNumberAsOptionalAsync(body);
}
catch (ApiException e){};
```

