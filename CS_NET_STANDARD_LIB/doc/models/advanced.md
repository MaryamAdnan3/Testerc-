
# Advanced

## Structure

`Advanced`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Tags` | `List<string>` | Required | - |
| `Attachments` | `int` | Required | - |
| `RequiredSignatures` | `int` | Required | - |
| `GetSocialSecurityNumber` | `bool` | Required | - |
| `TimeToLive` | [`Models.TimeToLive`](/doc/models/time-to-live.md) | Required | - |

## Example (as JSON)

```json
{
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
```

