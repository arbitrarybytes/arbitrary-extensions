dotnet test "/p:CollectCoverage=true" "/p:CoverletOutputFormat=\"lcov,cobertura\"" "/p:CoverletOutput=coverage/"

reportgenerator "-reports:coverage/*.info" "-targetdir:coverage/reports" -reporttypes:HtmlInline;Badges -historydir:coverage/reports/history