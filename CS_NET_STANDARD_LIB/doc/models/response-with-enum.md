
# Response With Enum

## Structure

`ResponseWithEnum`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ParamFormat` | [`Models.ParamFormat`](/doc/models/param-format.md) | Required | - |
| `Optional` | `bool` | Required | - |
| `Type` | [`Models.Type`](/doc/models/type.md) | Required | - |
| `Constant` | `bool` | Required | - |
| `IsArray` | `bool` | Required | - |
| `IsStream` | `bool` | Required | - |
| `IsAttribute` | `bool` | Required | - |
| `IsMap` | `bool` | Required | - |
| `Attributes` | [`Models.Attributes`](/doc/models/attributes.md) | Required | - |
| `Nullable` | `bool` | Required | - |
| `Id` | `string` | Required | - |
| `Name` | `string` | Required | - |
| `Description` | `string` | Required | - |

## Example (as JSON)

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

