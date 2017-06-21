@echo off

opencover.console.exe -target:"dotnet.exe" -targetargs:"test -f netcoreapp1.1 -c Release C:\Users\NetWeb-MJ\Desktop\CIBERTECWEB\Cibertec.Repositories.Test\Cibertec.Repositories.Tests.csproj" -mergeoutput -hideskipped:File -output:coverage.xml -oldStyle -filter:"+[Cibertec.*]* -[Cibertec.Repositories.Tests*]*" -searchdirs:"C:\Users\NetWeb-MJ\Desktop\CIBERTECWEB\Cibertec.Repositories.Test\bin\Release\netcoreapp1.1" -register:user

reportgenerator.exe -reports:coverage.xml -targetdir:coverage -verbosity:Error