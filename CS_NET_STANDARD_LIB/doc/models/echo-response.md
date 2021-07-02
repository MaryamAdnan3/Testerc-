
# Echo Response

Raw http Request info

## Structure

`EchoResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Body` | `object` | Optional | - |
| `Headers` | `Dictionary<string, string>` | Optional | - |
| `Method` | `string` | Optional | - |
| `Path` | `string` | Optional | relativePath |
| `Query` | [`Dictionary<string, Models.QueryParameter>`](/doc/models/query-parameter.md) | Optional | - |
| `UploadCount` | `int?` | Optional | - |

## Example (as JSON)

```json
{
  "body": null,
  "headers": null,
  "method": null,
  "path": null,
  "query": null,
  "uploadCount": null
}
```

