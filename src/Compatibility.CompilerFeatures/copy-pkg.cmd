set src=C:\nuget_local
set nuget=C:\Users\mohha\.nuget\packages
set pkg=Compatibility.CompilerFeatures
set version=1.0.0
set pkg_path=..\..\build\%pkg%.%version%.nupkg
copy %pkg_path%  %src%
rmdir %nuget%\%pkg% /s /q
pause