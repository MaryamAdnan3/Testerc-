
# Ui

## Structure

`Ui`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Dialogs` | [`Models.Dialogs`](/doc/models/dialogs.md) | Required | - |
| `Language` | [`Models.LanguageEnum`](/doc/models/language-enum.md) | Required | - |
| `Styling` | [`Models.Styling`](/doc/models/styling.md) | Required | - |

## Example (as JSON)

```json
{
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
}
```

