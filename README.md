# Diacritics.NET
<img src="https://raw.githubusercontent.com/thomasgalliker/Diacritics.NET/master/logo.png" alt="Diacritics.NET" align="right">
Diacritics are used across many languages in order to change the sound-values of the letters to which they are added.
In software development, diacritics often have to be replaced with non-diacritics, e.g. to improve usability of user input.
Diacritics.NET is a basic mapper between diacritic characters an non-diacritic characters.

### Download and Install Diacritics
This library is available on NuGet: https://www.nuget.org/packages/Diacritics/
Use the following command to install Diacritics using NuGet package manager console:

    PM> Install-Package Diacritics

You can use this library in any .Net project which is compatible to PCL (e.g. Xamarin Android, iOS, Windows Phone, Windows Store, Universal Apps, etc.)

### API Usage
#### Detect and remove diacritic characters
The most common use case of this library is to detect and remove diacritic characters from a given string.

HasDiacritics simply tells you if the given string contains any diacritic character. The effort for this check is the same as if you remove the characters using RemoveDiacritics.

```
// Arrange
const string InputString = "Je veux aller à Saint-Étienne";

// Act
bool hasDiacritics = InputString.HasDiacritics();

// Assert
hasDiacritics.Should().BeTrue();
```

RemoveDiacritics returns a string for which all diacritics have been replaced.
```
// Arrange
const string InputString = "Je veux aller à Saint-Étienne";

// Act
string removeDiacritics = InputString.RemoveDiacritics();

// Assert
removeDiacritics.Should().Be("Je veux aller a Saint-Etienne");
```
#### Using Diacritics with IoC
The example shown above uses extension methods which use a default implementation of ```IDiacriticsMapper```, namely type ```DefaultDiacriticsMapper```. If you're using an IoC container, you can register ```IDiacriticsMapper``` either with the provided ```DefaultDiacriticsMapper``` or with your own implementation of ```IDiacriticsMapper```.

#### Add custom diactrics mappings
Diacritics is extensible! You can write your own language accent by implementing ```IAccentMapping``` (or ```AccentMapping``` base class). ```DiacriticsMapper``` accepts any ```IAccentMappin```g type at construction time.
You are highly welcome to contribute to this library. Just create a fork, commit your changes and create a pull request.

TODO: Add/Remove methods for adding/removing accents at runtime.

### License
This project is Copyright &copy; 2015 [Thomas Galliker](https://ch.linkedin.com/in/thomasgalliker). Free for non-commercial use. For commercial use please contact the author.
