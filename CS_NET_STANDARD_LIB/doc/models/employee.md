
# Employee

## Structure

`Employee`

## Inherits From

[`Person`](/doc/models/person.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Department` | `string` | Required | - |
| `Dependents` | [`List<Models.Person>`](/doc/models/person.md) | Required | - |
| `HiredAt` | `DateTime` | Required | - |
| `JoiningDay` | [`Models.Days`](/doc/models/days.md) | Required | **Default**: `Days.Monday`<br>*Default: `Days.Monday`* |
| `Salary` | `int` | Required | - |
| `WorkingDays` | [`List<Models.Days>`](/doc/models/days.md) | Required | - |
| `Boss` | [`Models.Person`](/doc/models/person.md) | Required | - |

## Example (as JSON)

```json
{
  "department": null,
  "dependents": null,
  "hiredAt": null,
  "joiningDay": "Monday",
  "salary": null,
  "workingDays": null,
  "boss": null
}
```

