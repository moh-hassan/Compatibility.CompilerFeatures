# Compatibility.CompilerFeatures 

[![Nuget](https://img.shields.io/nuget/v/Compatibility.CompilerFeatures)](https://www.nuget.org/packages/Compatibility.CompilerFeatures)

[![Nuget](https://img.shields.io/myget/compilerfeatures/v/Compatibility.CompilerFeatures?label=Develop%20MyGet)](https://www.myget.org/feed/compilerfeatures/package/nuget/Compatibility.CompilerFeatures)

[![Build status](https://ci.appveyor.com/api/projects/status/v0ch1ghwrje12o0x/branch/main?svg=true)](https://ci.appveyor.com/project/moh-hassan/compatibility-compilerfeatures/branch/main)


Source only package to support C# 11 `required` feature and c#9 `init and record` features in older target frameworks.

<hr/>

C# 11 in net7 added a new feature to support the `required` keywords as described in [required modifier ](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/required). 

When using C# 11 with target frameworks <= NET 7.0, these new features are not possible because the compiler is missing some attribute classes which is used by Roslyn compiler at compile time.

So developers can't use this feature for any target framework prior to NET 7.

This problem can be fixed  by referencing  `Compatibility.CompilerFeatures` package. The package is Source code only without binaries.

After the package is installed in the c# project, the missing source code is linked to the project and used by Roslyn compiler during build stage.

The compiled code has no dependency on the package.

These files are used only during build and are not included in your final compiled code.

This means that the resulting project **does not have an explicit dependency** on the this package.
The package also support `init and record` feature of c# 9.

## Supported Framework
The package Compatibility.CompilerFeatures is currently compatible with the following target frameworks:
* .NET Framework net4x: net472..net45
* NET 6


## c# language feature supported
- `required` in c# 11.
- `init-only and record` in c# 9.

## Note
Other c# language feature in c#8+ may be added in a future releases.

## Quickstart


1. set  LangVersion
```xml
<LangVersion>latest</LangVersion>
--or--
<LangVersion>preview</LangVersion>

```
2. **Reference the package** <br/>

   Add the package `Compatibility.CompilerFeatures` to c# project:

   ```
   dotnet add package Compatibility.CompilerFeatures
   --or--
   Install-Package Compatibility.CompilerFeatures   
   ```
3. **Ensure that the package has been added as a development dependency** <br/>
   Open your `.csproj` file and modify the new package reference to be PrivateAssets:

   ```xml 
   
   <PackageReference Include="Compatibility.CompilerFeatures" Version="<pkg_version>">
     <PrivateAssets>all</PrivateAssets>
     <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
   </PackageReference>
   ```

   With this package declaration your project will have  **NO explicit dependency** on the `Compatibility.CompilerFeatures` package.

4. Build the project 
   
   **Note:**
   - If there is a build error occurs, insure that you use langVersion 11 or preview.
   - Check the sample project included in the repository  that support net472, net45 and net6.0.
   - The package is tested with the new c# sdk project format.

## Building
Building works in the same way in net7 no more or no less.

## Contributing

If something is not working for you, feel free to create an issue and welcome to Pull Request.
Contributers can add new features of c# to support the old frameworks.

## License
MIT.

See the [LICENSE](./LICENSE) file for details.
