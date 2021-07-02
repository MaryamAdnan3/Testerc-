
# Boss

Testing circular reference.

## Structure

`Boss`

## Inherits From

[`Employee`](/doc/models/employee.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PromotedAt` | `DateTime` | Required | - |
| `Assistant` | [`Models.Employee`](/doc/models/employee.md) | Required | - |

## Example (as JSON)

```json
{
  "department": null,
  "dependents": null,
  "hiredAt": null,
  "joiningDay": "Monday",
  "salary": null,
  "workingDays": null,
  "boss": null,
  "promotedAt": null,
  "assistant": {
    "department": null,
    "dependents": null,
    "hiredAt": null,
    "joiningDay": "Monday",
    "salary": null,
    "workingDays": null,
    "boss": null
  }
}
```

