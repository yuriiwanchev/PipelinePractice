SETLOCAL
SET TestUrl=https://ivanchev-webcalculator.azurewebsites.net
dotnet test --filter FullyQualifiedName=WebCalculator.Tests.CalculatorControllerFunctionalTests --logger "trx;logfilename=test-results.trx" --results-directory TestResults/