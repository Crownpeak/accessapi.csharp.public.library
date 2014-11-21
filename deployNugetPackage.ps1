msbuild CrownPeakPublic.csproj /target:Rebuild /property:Configuration=Release 
nuget pack CrownPeakPublic.csproj -Symbols -Prop Configuration=Release -Version 1.0.0.2
move *.nupkg '\\lafs\Engineering\R&D\Software\NuGetRepository'