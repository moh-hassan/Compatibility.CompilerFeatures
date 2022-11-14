# Compatibility.CompilerFeatures [![Nuget](https://img.shields.io/nuget/v/Compatibility.CompilerFeatures)](https://www.nuget.org/packages/Compatibility.CompilerFeatures)

Use C# 11,9's required, init and record features in older target frameworks.

[:package: NuGet](https://www.nuget.org/packages/Compatibility.CompilerFeatures)

<hr/>

C# 11 in net7 added a new feature to support the `required` keywords as described in [required modifier ](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/required). 
When using C# 11 with target frameworks <= NET 7.0, these new features are not possible because the compiler is missing some attribute classes which is used by Roslyn compiler at compile time, so developers can't use this feature for any target framework prior to NET 7.
This problem can be fixed  by referencing  `Compatibility.CompilerFeatures` package.
The missing source code is copied from the original Roslyn repository and declared as public classes (not internal), so you can reference the package as private then roslyn compiler can use it.
**You need not to copy these files into your project.**
These files are used only during build and are not included in your final compiled code.
This means that the resulting project **does not have an explicit dependency** on the this package.
Also, the package support `init and record` of c# 9.

## Compatibility
Compatibility.CompilerFeatures is currently compatible with the following target frameworks:

* .NET Standard >= 1.0
* .NET Framework >= 2.0
* NET 5 and NET 6

## c# language supported
- required in c# 11.
- init-only and record in c# 9.

## Note
Other c# language feature in c#8 and above may be added in a future releases.

## Quickstart

> :warning: **Important:** <br/>
> You **must** use a C# version >= 11.0 with the `Compatibility.CompilerFeatures` package - otherwise, your project won't compile.
1. declare language c# 11
```xml
<LangVersion>11.0</LangVersion>

--or using vs 2022 --
<LangVersion>preview</LangVersion>
```
2. **Reference the package** <br/>
   Add the package to your project:

   ```sh
   dotnet add package Compatibility.CompilerFeatures
   --or--
   Install-Package Compatibility.CompilerFeatures   
   ```
3. **Ensure that the package has been added as a development dependency** <br/>
   Open your `.csproj` file and modify the new package reference to be private:

   ```xml 
   
   <PackageReference Include="Compatibility.CompilerFeatures" Version="<pkg_version>">
     <PrivateAssets>all</PrivateAssets>
     <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
   </PackageReference>
   ```

   With this package declaration your project will have an **explicit dependency** on the `Compatibility.CompilerFeatures` package.
3. **Build the project** <br/>
   
   **Note:**
   - If there are a build error occurs, insure that you use langVersion 11 or preview.
   - Check the sample project included in the repository  that support net4x, net6.0 and net5.0.




## Building

Building works in the same way in net7 no more or no less.

## Contributing

If something is not working for you, feel free to create an issue or Pull Request.

## License

See the [LICENSE](./LICENSE) file for details.
