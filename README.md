# SLUG - Unity Logger
## What Is This?
A simple Unity3D `Debug.Log` replacement based on [Log Unity](https://github.com/frarf/log.unity). Does nothing extraordinary, except for formatting log output into this:

```
[CLASS NAME] Your lovely debug log message
```

## Benefits
This helps developers to easily read, or even better parse the mighty `Engine.log` for player progression easily.

## Usage
Download `Slug.cs` into `Assets` folder.

You can use it just like `Debug.Log` but instead of `Debug`, you should use `Slug`

- Slug.Log(string message)
- Slug.LogWarning(string message)
- Slug.LogError(string message)

## Parser
You can find a simple parser to export readable markdown file from `Engine.log`: [SLUG - Unity Log Parser](https://github.com/excalith/slug-unity-log-parser)


