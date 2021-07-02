
# Nested Model Exception

## Structure

`NestedModelException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ServerMessage` | `string` | Required | - |
| `ServerCode` | `string` | Required | - |
| `Model` | [`Models.Validate`](/doc/models/validate.md) | Required | - |

## Example (as JSON)

```json
{
  "ServerMessage": "ServerMessage6",
  "ServerCode": "ServerCode0",
  "model": {
    "field": "field4",
    "name": "name2",
    "address": null
  }
}
```

