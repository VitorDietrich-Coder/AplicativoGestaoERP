dotnet tool install –global dotnet-sonarscanner
dotnet sonarscanner begin /C:”AplicativoGestaoErp”/d:sonar.cs.opencover.reportsPaths=”%CD%\opencover.xml”
dotnet build C:\Users\vitor\Source\Repos\AplicativoGestaoERP\Aplicativo Gestão ERP.sln 