::dotnet pack logger\logger.nuspec
dotnet pack --no-build 
::dotnet pack 
::nuget pack logger.nuspec 
::-Suffix $suffix -OutputDirectory artifacts

pause