# Diacritics.NET
[![Version](https://img.shields.io/nuget/v/Diacritics.svg)](https://www.nuget.org/packages/Diacritics)  [![Downloads](https://img.shields.io/nuget/dt/Diacritics.svg)](https://www.nuget.org/packages/Diacritics)

Diacritics are used across many languages in order to change the sound-values of the letters to which they are added.
In software development, diacritics often have to be replaced with non-diacritics, e.g. to improve usability of user input.
Diacritics.NET is a basic mapper between diacritic characters an non-diacritic characters.

## Download and Install Diacritics
This library is available on NuGet: https://www.nuget.org/packages/Diacritics/
Use the following command to install Diacritics using NuGet package manager console:

    PM> Install-Package Diacritics

You can use this library in any .Net project which is compatible to PCL (e.g. Xamarin Android, iOS, Windows Phone, Windows Store, Universal Apps, etc.)

## API Usage
### Replace diacritic characters
The most common use case of this library is to find and replace diacritic characters in a given string.
`RemoveDiacritics` is a string extension method which returns a diacritics-free string.

```
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

```
// Arrange
const string InputString = "Je veux aller à Saint-Étienne";

// Act
bool hasDiacritics = InputString.HasDiacritics();

// Assert
hasDiacritics.Should().BeTrue();
```

### Using Diacritics with IoC
The example shown above uses extension methods which use a default implementation of `IDiacriticsMapper`, namely type ```DefaultDiacriticsMapper```. If you're using an IoC container, you can register `IDiacriticsMapper` either with the provided ```DefaultDiacriticsMapper``` or with your own implementation of ```IDiacriticsMapper```.

### Add custom diactrics mappings
Diacritics is extensible. You can write your own language accent by implementing `IAccentMapping` (or `AccentMapping` base class). `DiacriticsMapper` accepts any `IAccentMapping` type at construction time.
You are highly welcome to contribute to this library. Just create a fork, commit your changes and create a pull request.

`TODO: Add/Remove methods for adding/removing accents at runtime.`


### Benchmark Tests

**Tested Version**<br>
https://www.nuget.org/packages/Diacritics/2.1.19291.8-pre

**Benchmark Environment**<br>
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17134.885 (1803/April2018Update/Redstone4)
Intel Core i7-7600U CPU 2.80GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
Frequency=2835933 Hz, Resolution=352.6176 ns, Timer=TSC
.NET Core SDK=3.0.100
  [Host]   : .NET Core 2.2.4 (CoreCLR 4.6.27521.02, CoreFX 4.6.27521.01), 64bit RyuJIT
  ShortRun : .NET Core 2.2.4 (CoreCLR 4.6.27521.02, CoreFX 4.6.27521.01), 64bit RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

**Benchmark Results**

|                                 Method |        Mean |       Error |    StdDev |
|--------------------------------------- |------------:|------------:|----------:|
| RemoveDiacritics (9 latin chars)       |    230.5 ns |    476.2 ns |  26.10 ns |
| RemoveDiacritics (23 diacritic chars)  |    651.5 ns |    843.4 ns |  46.23 ns |
| RemoveDiacritics (408 latin chars)     |  8,697.1 ns |  9,938.1 ns | 544.74 ns |
| RemoveDiacritics (729 diacritic chars) | 15,045.0 ns | 12,893.0 ns | 706.71 ns |

**Legend**<br>
  Mean   : Arithmetic mean of all measurements<br>
  Error  : Half of 99.9% confidence interval<br>
  StdDev : Standard deviation of all measurements<br>
  Rank   : Relative position of current benchmark mean among all benchmarks (Arabic style)<br>
  1 ns   : 1 Nanosecond (0.000000001 sec)<br>

## License
This project is Copyright &copy; 2019 [Thomas Galliker](https://ch.linkedin.com/in/thomasgalliker). Free for non-commercial use. For commercial use please contact the author.
