# Response Types

```csharp
IResponseTypesController responseTypesController = client.ResponseTypesController;
```

## Class Name

`ResponseTypesController`

## Methods

* [Get Date Array](/doc/controllers/response-types.md#get-date-array)
* [Get Date](/doc/controllers/response-types.md#get-date)
* [Return Company Model](/doc/controllers/response-types.md#return-company-model)
* [Return Boss Model](/doc/controllers/response-types.md#return-boss-model)
* [Return Employee Model](/doc/controllers/response-types.md#return-employee-model)
* [Return Developer Model](/doc/controllers/response-types.md#return-developer-model)
* [Return Tester Model](/doc/controllers/response-types.md#return-tester-model)
* [Return Complex 1 Object](/doc/controllers/response-types.md#return-complex-1-object)
* [Return Response With Enums](/doc/controllers/response-types.md#return-response-with-enums)
* [Return Complex 2 Object](/doc/controllers/response-types.md#return-complex-2-object)
* [Return Complex 3 Object](/doc/controllers/response-types.md#return-complex-3-object)
* [Get Long](/doc/controllers/response-types.md#get-long)
* [Get Model](/doc/controllers/response-types.md#get-model)
* [Get String Enum Array](/doc/controllers/response-types.md#get-string-enum-array)
* [Get String Enum](/doc/controllers/response-types.md#get-string-enum)
* [Get Model Array](/doc/controllers/response-types.md#get-model-array)
* [Get Int Enum](/doc/controllers/response-types.md#get-int-enum)
* [Get Int Enum Array](/doc/controllers/response-types.md#get-int-enum-array)
* [Get Precision](/doc/controllers/response-types.md#get-precision)
* [Get Binary](/doc/controllers/response-types.md#get-binary)
* [Get Integer](/doc/controllers/response-types.md#get-integer)
* [Get Integer Array](/doc/controllers/response-types.md#get-integer-array)
* [Get Dynamic](/doc/controllers/response-types.md#get-dynamic)
* [Get Dynamic Array](/doc/controllers/response-types.md#get-dynamic-array)
* [Get 3339 Datetime](/doc/controllers/response-types.md#get-3339-datetime)
* [Get 3339 Datetime Array](/doc/controllers/response-types.md#get-3339-datetime-array)
* [Get Boolean](/doc/controllers/response-types.md#get-boolean)
* [Get Boolean Array](/doc/controllers/response-types.md#get-boolean-array)
* [Get Headers](/doc/controllers/response-types.md#get-headers)
* [Get 1123 Date Time](/doc/controllers/response-types.md#get-1123-date-time)
* [Get Unix Date Time](/doc/controllers/response-types.md#get-unix-date-time)
* [Get 1123 Date Time Array](/doc/controllers/response-types.md#get-1123-date-time-array)
* [Get Unix Date Time Array](/doc/controllers/response-types.md#get-unix-date-time-array)
* [Get Content Type Headers](/doc/controllers/response-types.md#get-content-type-headers)


# Get Date Array

```csharp
GetDateArrayAsync()
```

## Response Type

`Task<List<DateTime>>`

## Example Usage

```csharp
try
{
    List<DateTime> result = await responseTypesController.GetDateArrayAsync();
}
catch (ApiException e){};
```


# Get Date

```csharp
GetDateAsync()
```

## Response Type

`Task<DateTime?>`

## Example Usage

```csharp
try
{
    DateTime? result = await responseTypesController.GetDateAsync();
}
catch (ApiException e){};
```


# Return Company Model

```csharp
ReturnCompanyModelAsync()
```

## Response Type

[`Task<Models.Company>`](/doc/models/company.md)

## Example Usage

```csharp
try
{
    Company result = await responseTypesController.ReturnCompanyModelAsync();
}
catch (ApiException e){};
```

## Example Response *(as JSON)*

```json
{
  "company name": "APIMatic",
  "address": "nust",
  "cell number": "090078601"
}
```


# Return Boss Model

```csharp
ReturnBossModelAsync()
```

## Response Type

[`Task<Models.BossCompany>`](/doc/models/boss-company.md)

## Example Usage

```csharp
try
{
    BossCompany result = await responseTypesController.ReturnBossModelAsync();
}
catch (ApiException e){};
```

## Example Response *(as JSON)*

```json
{
  "company name": "APIMatic",
  "address": "nust",
  "cell number": "090078601",
  "first name": "Adeel",
  "last name": "Ali",
  "address_boss": "nust"
}
```


# Return Employee Model

```csharp
ReturnEmployeeModelAsync()
```

## Response Type

[`Task<Models.EmployeeComp>`](/doc/models/employee-comp.md)

## Example Usage

```csharp
try
{
    EmployeeComp result = await responseTypesController.ReturnEmployeeModelAsync();
}
catch (ApiException e){};
```

## Example Response *(as JSON)*

```json
{
  "company name": "APIMatic",
  "address": "nust",
  "cell number": "090078601",
  "first name": "Nauman",
  "last name": "Ali",
  "id": "123456"
}
```


# Return Developer Model

```csharp
ReturnDeveloperModelAsync()
```

## Response Type

[`Task<Models.Developer>`](/doc/models/developer.md)

## Example Usage

```csharp
try
{
    Developer result = await responseTypesController.ReturnDeveloperModelAsync();
}
catch (ApiException e){};
```

## Example Response *(as JSON)*

```json
{
  "company name": "APIMatic",
  "address": "nust",
  "cell number": "090078601",
  "first name": "Nauman",
  "last name": "Ali",
  "id": "123456",
  "team": "CORE",
  "designation": "Manager",
  "role": "Team Lead"
}
```


# Return Tester Model

```csharp
ReturnTesterModelAsync()
```

## Response Type

[`Task<Models.SoftwareTester>`](/doc/models/software-tester.md)

## Example Usage

```csharp
try
{
    SoftwareTester result = await responseTypesController.ReturnTesterModelAsync();
}
catch (ApiException e){};
```

## Example Response *(as JSON)*

```json
{
  "company name": "APIMatic",
  "address": "nust",
  "cell number": "090078601",
  "first name": "Muhammad",
  "last name": "Farhan",
  "id": "123456",
  "team": "Testing",
  "designation": "Tester",
  "role": "Testing"
}
```


# Return Complex 1 Object

```csharp
ReturnComplex1ObjectAsync()
```

## Response Type

[`Task<Models.Complex1>`](/doc/models/complex-1.md)

## Example Usage

```csharp
try
{
    Complex1 result = await responseTypesController.ReturnComplex1ObjectAsync();
}
catch (ApiException e){};
```

## Example Response *(as JSON)*

```json
{
  "medications": [
    {
      "aceInhibitors": [
        {
          "name": "lisinopril",
          "strength": "10 mg Tab",
          "dose": "1 tab",
          "route": "PO",
          "sig": "daily",
          "pillCount": "#90",
          "refills": "Refill 3"
        }
      ],
      "antianginal": [
        {
          "name": "nitroglycerin",
          "strength": "0.4 mg Sublingual Tab",
          "dose": "1 tab",
          "route": "SL",
          "sig": "q15min PRN",
          "pillCount": "#30",
          "refills": "Refill 1"
        }
      ],
      "anticoagulants": [
        {
          "name": "warfarin sodium",
          "strength": "3 mg Tab",
          "dose": "1 tab",
          "route": "PO",
          "sig": "daily",
          "pillCount": "#90",
          "refills": "Refill 3"
        }
      ],
      "betaBlocker": [
        {
          "name": "metoprolol tartrate",
          "strength": "25 mg Tab",
          "dose": "1 tab",
          "route": "PO",
          "sig": "daily",
          "pillCount": "#90",
          "refills": "Refill 3"
        }
      ],
      "diuretic": [
        {
          "name": "furosemide",
          "strength": "40 mg Tab",
          "dose": "1 tab",
          "route": "PO",
          "sig": "daily",
          "pillCount": "#90",
          "refills": "Refill 3"
        }
      ],
      "mineral": [
        {
          "name": "potassium chloride ER",
          "strength": "10 mEq Tab",
          "dose": "1 tab",
          "route": "PO",
          "sig": "daily",
          "pillCount": "#90",
          "refills": "Refill 3"
        }
      ]
    }
  ],
  "labs": [
    {
      "name": "Arterial Blood Gas",
      "time": "Today",
      "location": "Main Hospital Lab"
    },
    {
      "name": "BMP",
      "time": "Today",
      "location": "Primary Care Clinic"
    },
    {
      "name": "BNP",
      "time": "3 Weeks",
      "location": "Primary Care Clinic"
    },
    {
      "name": "BUN",
      "time": "1 Year",
      "location": "Primary Care Clinic"
    },
    {
      "name": "Cardiac Enzymes",
      "time": "Today",
      "location": "Primary Care Clinic"
    },
    {
      "name": "CBC",
      "time": "1 Year",
      "location": "Primary Care Clinic"
    },
    {
      "name": "Creatinine",
      "time": "1 Year",
      "location": "Main Hospital Lab"
    },
    {
      "name": "Electrolyte Panel",
      "time": "1 Year",
      "location": "Primary Care Clinic"
    },
    {
      "name": "Glucose",
      "time": "1 Year",
      "location": "Main Hospital Lab"
    },
    {
      "name": "PT/INR",
      "time": "3 Weeks",
      "location": "Primary Care Clinic"
    },
    {
      "name": "PTT",
      "time": "3 Weeks",
      "location": "Coumadin Clinic"
    },
    {
      "name": "TSH",
      "time": "1 Year",
      "location": "Primary Care Clinic"
    }
  ],
  "imaging": [
    {
      "name": "Chest X-Ray",
      "time": "Today",
      "location": "Main Hospital Radiology"
    },
    {
      "name": "Chest X-Ray",
      "time": "Today",
      "location": "Main Hospital Radiology"
    },
    {
      "name": "Chest X-Ray",
      "time": "Today",
      "location": "Main Hospital Radiology"
    }
  ]
}
```


# Return Response With Enums

```csharp
ReturnResponseWithEnumsAsync()
```

## Response Type

[`Task<Models.ResponseWithEnum>`](/doc/models/response-with-enum.md)

## Example Usage

```csharp
try
{
    ResponseWithEnum result = await responseTypesController.ReturnResponseWithEnumsAsync();
}
catch (ApiException e){};
```

## Example Response *(as JSON)*

```json
{
  "paramFormat": "Template",
  "optional": false,
  "type": "Long",
  "constant": false,
  "isArray": false,
  "isStream": false,
  "isAttribute": false,
  "isMap": false,
  "attributes": {
    "exclusiveMaximum": false,
    "exclusiveMinimum": false,
    "id": "5a9fcb01caacc310dc6bab51"
  },
  "nullable": false,
  "id": "5a9fcb01caacc310dc6bab50",
  "name": "petId",
  "description": "ID of pet to update"
}
```


# Return Complex 2 Object

```csharp
ReturnComplex2ObjectAsync()
```

## Response Type

[`Task<Models.Complex2>`](/doc/models/complex-2.md)

## Example Usage

```csharp
try
{
    Complex2 result = await responseTypesController.ReturnComplex2ObjectAsync();
}
catch (ApiException e){};
```

## Example Response *(as JSON)*

```json
{
  "glossary": {
    "title": "example glossary",
    "GlossDiv": {
      "title": "S",
      "GlossList": {
        "GlossEntry": {
          "ID": "SGML",
          "SortAs": "SGML",
          "GlossTerm": "Standard Generalized Markup Language",
          "Acronym": "SGML",
          "Abbrev": "ISO 8879:1986",
          "GlossDef": {
            "para": "A meta-markup language, used to create markup languages such as DocBook.",
            "GlossSeeAlso": [
              "GML",
              "XML"
            ]
          },
          "GlossSee": "markup"
        }
      }
    }
  }
}
```


# Return Complex 3 Object

```csharp
ReturnComplex3ObjectAsync()
```

## Response Type

[`Task<Models.Complex3>`](/doc/models/complex-3.md)

## Example Usage

```csharp
try
{
    Complex3 result = await responseTypesController.ReturnComplex3ObjectAsync();
}
catch (ApiException e){};
```

## Example Response *(as JSON)*

```json
{
  "documentId": "099cceda-38a8-4b01-87b9-a8f2007675d6",
  "signers": [
    {
      "id": "1bef97d1-0704-4eb2-a490-a8f2007675db",
      "url": "https://sign-test.idfy.io/start?jwt=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzM4NCJ9.eyJrdmVyc2lvbiI6IjdmNzhjNzNkMmQ1MjQzZWRiYjdiNDI0MmI2MDE1MWU4IiwiZG9jaWQiOiIwOTljY2VkYS0zOGE4LTRiMDEtODdiOS1hOGYyMDA3Njc1ZDYiLCJhaWQiOiJjMGNlMTQ2OC1hYzk0LTRiMzQtODc2ZS1hODg1MDBjMmI5YTEiLCJsZyI6ImVuIiwiZXJyIjpudWxsLCJpZnIiOmZhbHNlLCJ3Ym1zZyI6ZmFsc2UsInNmaWQiOiIxYmVmOTdkMS0wNzA0LTRlYjItYTQ5MC1hOGYyMDA3Njc1ZGIiLCJ1cmxleHAiOm51bGwsImF0aCI6bnVsbCwiZHQiOiJUZXN0IGRvY3VtZW50IiwidmYiOmZhbHNlLCJhbiI6IklkZnkgU0RLIGRlbW8iLCJ0aCI6IlBpbmsiLCJzcCI6IkN1YmVzIiwiZG9tIjpudWxsLCJyZGlyIjpmYWxzZSwidXQiOiJ3ZWIiLCJ1dHYiOm51bGwsInNtIjoidGVzdEB0ZXN0LmNvbSJ9.Dyy2RSeR6dmU8qxOEi-2gEX3Gg7wry6JhkZIWOuADDdu5jJWidQLcxfJn_qAHNpb",
      "links": [],
      "externalSignerId": "uoiahsd321982983jhrmnec2wsadm32",
      "redirectSettings": {
        "redirectMode": "donot_redirect"
      },
      "signatureType": {
        "mechanism": "pkisignature",
        "onEacceptUseHandWrittenSignature": false
      },
      "ui": {
        "dialogs": {
          "before": {
            "useCheckBox": false,
            "title": "Info",
            "message": "Please read the contract on the next pages carefully. Pay some extra attention to paragraph 5."
          }
        },
        "language": "EN",
        "styling": {
          "colorTheme": "Pink",
          "spinner": "Cubes"
        }
      },
      "tags": [],
      "order": 0,
      "required": false
    }
  ],
  "status": {
    "documentStatus": "unsigned",
    "completedPackages": [],
    "attachmentPackages": {}
  },
  "title": "Test document",
  "description": "This is an important document",
  "externalId": "ae7b9ca7-3839-4e0d-a070-9f14bffbbf55",
  "dataToSign": {
    "fileName": "sample.txt",
    "convertToPDF": false
  },
  "contactDetails": {
    "email": "test@test.com",
    "url": "https://idfy.io"
  },
  "advanced": {
    "tags": [
      "develop",
      "fun_with_documents"
    ],
    "attachments": 0,
    "requiredSignatures": 0,
    "getSocialSecurityNumber": false,
    "timeToLive": {
      "deadline": "2018-06-29T14:57:25Z",
      "deleteAfterHours": 1
    }
  }
}
```


# Get Long

```csharp
GetLongAsync()
```

## Response Type

`Task<long?>`

## Example Usage

```csharp
try
{
    long? result = await responseTypesController.GetLongAsync();
}
catch (ApiException e){};
```


# Get Model

```csharp
GetModelAsync()
```

## Response Type

[`Task<Models.Person>`](/doc/models/person.md)

## Example Usage

```csharp
try
{
    Person result = await responseTypesController.GetModelAsync();
}
catch (ApiException e){};
```


# Get String Enum Array

```csharp
GetStringEnumArrayAsync()
```

## Response Type

[`Task<List<Models.Days>>`](/doc/models/days.md)

## Example Usage

```csharp
try
{
    List<Days> result = await responseTypesController.GetStringEnumArrayAsync();
}
catch (ApiException e){};
```


# Get String Enum

```csharp
GetStringEnumAsync()
```

## Response Type

[`Task<Models.Days?>`](/doc/models/days.md)

## Example Usage

```csharp
try
{
    Days? result = await responseTypesController.GetStringEnumAsync();
}
catch (ApiException e){};
```


# Get Model Array

```csharp
GetModelArrayAsync()
```

## Response Type

[`Task<List<Models.Person>>`](/doc/models/person.md)

## Example Usage

```csharp
try
{
    List<Person> result = await responseTypesController.GetModelArrayAsync();
}
catch (ApiException e){};
```


# Get Int Enum

```csharp
GetIntEnumAsync()
```

## Response Type

[`Task<Models.SuiteCode?>`](/doc/models/suite-code.md)

## Example Usage

```csharp
try
{
    SuiteCode? result = await responseTypesController.GetIntEnumAsync();
}
catch (ApiException e){};
```


# Get Int Enum Array

```csharp
GetIntEnumArrayAsync()
```

## Response Type

[`Task<List<Models.SuiteCode>>`](/doc/models/suite-code.md)

## Example Usage

```csharp
try
{
    List<SuiteCode> result = await responseTypesController.GetIntEnumArrayAsync();
}
catch (ApiException e){};
```


# Get Precision

```csharp
GetPrecisionAsync()
```

## Response Type

`Task<double?>`

## Example Usage

```csharp
try
{
    double? result = await responseTypesController.GetPrecisionAsync();
}
catch (ApiException e){};
```


# Get Binary

gets a binary object

```csharp
GetBinaryAsync()
```

## Response Type

`Task<Stream>`

## Example Usage

```csharp
try
{
    Stream result = await responseTypesController.GetBinaryAsync();
}
catch (ApiException e){};
```


# Get Integer

Gets a integer response

```csharp
GetIntegerAsync()
```

## Response Type

`Task<int?>`

## Example Usage

```csharp
try
{
    int? result = await responseTypesController.GetIntegerAsync();
}
catch (ApiException e){};
```


# Get Integer Array

Get an array of integers.

```csharp
GetIntegerArrayAsync()
```

## Response Type

`Task<List<int>>`

## Example Usage

```csharp
try
{
    List<int> result = await responseTypesController.GetIntegerArrayAsync();
}
catch (ApiException e){};
```


# Get Dynamic

```csharp
GetDynamicAsync()
```

## Response Type

`Task<dynamic>`

## Example Usage

```csharp
try
{
    dynamic result = await responseTypesController.GetDynamicAsync();
}
catch (ApiException e){};
```


# Get Dynamic Array

```csharp
GetDynamicArrayAsync()
```

## Response Type

`Task<dynamic>`

## Example Usage

```csharp
try
{
    dynamic result = await responseTypesController.GetDynamicArrayAsync();
}
catch (ApiException e){};
```


# Get 3339 Datetime

```csharp
Get3339DatetimeAsync()
```

## Response Type

`Task<DateTime?>`

## Example Usage

```csharp
try
{
    DateTime? result = await responseTypesController.Get3339DatetimeAsync();
}
catch (ApiException e){};
```


# Get 3339 Datetime Array

```csharp
Get3339DatetimeArrayAsync()
```

## Response Type

`Task<List<DateTime>>`

## Example Usage

```csharp
try
{
    List<DateTime> result = await responseTypesController.Get3339DatetimeArrayAsync();
}
catch (ApiException e){};
```


# Get Boolean

```csharp
GetBooleanAsync()
```

## Response Type

`Task<bool?>`

## Example Usage

```csharp
try
{
    bool? result = await responseTypesController.GetBooleanAsync();
}
catch (ApiException e){};
```


# Get Boolean Array

```csharp
GetBooleanArrayAsync()
```

## Response Type

`Task<List<bool>>`

## Example Usage

```csharp
try
{
    List<bool> result = await responseTypesController.GetBooleanArrayAsync();
}
catch (ApiException e){};
```


# Get Headers

```csharp
GetHeadersAsync()
```

## Response Type

`Task`

## Example Usage

```csharp
try
{
    await responseTypesController.GetHeadersAsync();
}
catch (ApiException e){};
```


# Get 1123 Date Time

```csharp
Get1123DateTimeAsync()
```

## Response Type

`Task<DateTime?>`

## Example Usage

```csharp
try
{
    DateTime? result = await responseTypesController.Get1123DateTimeAsync();
}
catch (ApiException e){};
```


# Get Unix Date Time

```csharp
GetUnixDateTimeAsync()
```

## Response Type

`Task<DateTime?>`

## Example Usage

```csharp
try
{
    DateTime? result = await responseTypesController.GetUnixDateTimeAsync();
}
catch (ApiException e){};
```


# Get 1123 Date Time Array

```csharp
Get1123DateTimeArrayAsync()
```

## Response Type

`Task<List<DateTime>>`

## Example Usage

```csharp
try
{
    List<DateTime> result = await responseTypesController.Get1123DateTimeArrayAsync();
}
catch (ApiException e){};
```


# Get Unix Date Time Array

```csharp
GetUnixDateTimeArrayAsync()
```

## Response Type

`Task<List<DateTime>>`

## Example Usage

```csharp
try
{
    List<DateTime> result = await responseTypesController.GetUnixDateTimeArrayAsync();
}
catch (ApiException e){};
```


# Get Content Type Headers

```csharp
GetContentTypeHeadersAsync()
```

## Response Type

`Task`

## Example Usage

```csharp
try
{
    await responseTypesController.GetContentTypeHeadersAsync();
}
catch (ApiException e){};
```

