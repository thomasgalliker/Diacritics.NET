# Diacritics.NET

[![Version](https://img.shields.io/nuget/v/Diacritics.svg)](https://www.nuget.org/packages/Diacritics) [![Downloads](https://img.shields.io/nuget/dt/Diacritics.svg)](https://www.nuget.org/packages/Diacritics) [![Buy Me a Coffee](https://img.shields.io/badge/support-buy%20me%20a%20coffee-FFDD00)](https://buymeacoffee.com/thomasgalliker)

Diacritics are used across many languages in order to change the sound-values of the letters to which they are added.
In software development, diacritics often have to be replaced with non-diacritics, e.g. to improve usability of user
input.
Diacritics.NET is a basic mapper between diacritic characters an non-diacritic characters.

## Download and Install Diacritics

This library is available on NuGet: https://www.nuget.org/packages/Diacritics/
Use the following command to install Diacritics using NuGet package manager console:

    PM> Install-Package Diacritics

You can use this library in any .Net project which is compatible to PCL (e.g. Xamarin Android, iOS, Windows Phone,
Windows Store, Universal Apps, etc.)

## API Usage

### Replace diacritic characters

The most common use case of this library is to find and replace diacritic characters in a given string.
`RemoveDiacritics` is a string extension method which returns a diacritics-free string.

```csharp
// Arrange
const string InputString = "Je veux aller à Saint-Étienne";

// Act
string removeDiacritics = InputString.RemoveDiacritics();

// Assert
removeDiacritics.Should().Be("Je veux aller a Saint-Etienne");
```

### Find diacritic characters

The most common use case of this library is to detect and remove diacritic characters from a given string.
If you just want to check whether a string contains diacritics, use the string extensions method `HasDiacritics`.

```csharp
// Arrange
const string InputString = "Je veux aller à Saint-Étienne";

// Act
bool hasDiacritics = InputString.HasDiacritics();

// Assert
hasDiacritics.Should().BeTrue();
```

### Using IDiacriticsMapper with IoC

The example shown above uses extension methods which use a default implementation of `IDiacriticsMapper`, namely type
`DefaultDiacriticsMapper`. If you're using an IoC container, you can register `IDiacriticsMapper` either with the
provided `DefaultDiacriticsMapper` or with your own implementation of `IDiacriticsMapper`.

### Add custom diactrics mappings

Diacritics is extensible. You can write your own language accent by implementing `IAccentMapping` (or `AccentMapping`
base class). `DiacriticsMapper` accepts any `IAccentMapping` type at construction time.
You are highly welcome to contribute to this library. Just create a fork, commit your changes and create a pull request.

```
TODO: Add/Remove methods for adding/removing accents at runtime.
```

### Options

You can pass `DiacriticsOptions` into methods like `RemoveDiacritics` or `HasDiacritics`. Following properties can be
set:

| Property    | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   |
|-------------|-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| `Decompose` | `IAccentMapping` provides a property `IDictionary<char, MappingReplacement> Mapping` which defines the actual mappings between a character and a `MappingReplacement`. The `MappingReplacement` can be setup with the properties `Base`, `Decompose` and `DecomposeTitle`. In most languages, there is no need to set `Decompose` and `DecomposeTitle` properties. Decomposition is needed e.g. in German language to decompose the eszett character `ß` to `ss`. If the option is set to `Decompose = true`, the diacritics mapper uses the `Decompose` and `DecomposeTitle` values instead of the `Base` value for diacritics replacements. |

### Benchmark Tests

#### Testversion

[4.0.10-pre](https://www.nuget.org/packages/Diacritics/4.0.10-pre)

#### Benchmark Environment

```
BenchmarkDotNet v0.15.2, macOS Sequoia 15.5 (24F74) [Darwin 24.5.0]
Apple M3 Max, 1 CPU, 14 logical and 14 physical cores
.NET SDK 9.0.301
[Host]   : .NET 9.0.6 (9.0.625.26613), Arm64 RyuJIT AdvSIMD
ShortRun : .NET 9.0.6 (9.0.625.26613), Arm64 RyuJIT AdvSIMD

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3
```

#### Benchmark Results

| Method                     |     Mean |     Error |   StdDev |    Gen0 |    Gen1 |    Gen2 | Allocated |
|----------------------------|---------:|----------:|---------:|--------:|--------:|--------:|----------:|
| RemoveDiacritics_100kWords | 389.8 us |  15.25 us |  0.84 us | 83.0078 | 83.0078 | 83.0078 | 265.13 KB |
| RemoveDiacritics_1mWords   | 409.8 us | 229.40 us | 12.57 us | 83.0078 | 83.0078 | 83.0078 | 264.46 KB |

**_Legend_**

- Mean   : Arithmetic mean of all measurements.
- Error  : Half of 99.9% confidence interval.
- StdDev : Standard deviation of all measurements.
- Rank   : Relative position of current benchmark mean among all benchmarks (Arabic style).
- 1 ns   : 1 Nanosecond (0.000000001 sec).

## License

This project is offered under a dual license:

- **Free for non-commercial use**, including private and educational purposes.
- **Commercial use requires a license**, please support the project by making a one-time donation of $50+
  via https://buymeacoffee.com/thomasgalliker.

Recurring or more generous sponsorships are sincerely appreciated and help sustain ongoing development. Thank you for
your support!
If you have any questions about licensing, feel free to
contact [Thomas Galliker](https://ch.linkedin.com/in/thomasgalliker).

## Links

- https://en.wikipedia.org/wiki/Diacritic
- https://www.unicode.org/cldr/charts/47/by_type/core_data.alphabetic_information.main.html
- https://github.com/diacritics/database