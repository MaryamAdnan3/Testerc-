
# Custom Error Response Exception

## Structure

`CustomErrorResponseException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ErrorDescription` | `string` | Required | - |
| `Caught` | `string` | Required | - |
| `Exception` | `string` | Required | - |
| `InnerException` | `string` | Required | - |

## Example (as JSON)

```json
{
  "error description": null,
  "caught": "Error in CatchInner caused by calling the ThrowInner method.",
  "Exception": "In catch block of Main method.",
  "Inner Exception": "AppException: Exception in ThrowInner method."
}
```

