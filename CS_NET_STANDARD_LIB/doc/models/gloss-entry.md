
# Gloss Entry

## Structure

`GlossEntry`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ID` | `string` | Required | - |
| `SortAs` | `string` | Required | - |
| `GlossTerm` | `string` | Required | - |
| `Acronym` | `string` | Required | - |
| `Abbrev` | `string` | Required | - |
| `GlossDef` | [`Models.GlossDef`](/doc/models/gloss-def.md) | Required | - |
| `GlossSee` | `string` | Required | - |

## Example (as JSON)

```json
{
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
```

