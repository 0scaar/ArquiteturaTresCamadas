## VS Code

### Install entity framework package 
```
dotnet tool install --global dotnet-ef --version 7.0.18
```

### Run Migrations
1. Open the terminal pointing to the Data project
2. The Connection string must contain TrustServerCertificate=true
```
"DefaultConnection": "Server=localhost;Database=ApiTresCamadas;User ID=sa;Password=1q2w3e4r@#$;MultipleActiveResultSets=true;TrustServerCertificate=true"
```
4. Execute
```
dotnet ef migrations add InitialCreate --startup-project ../DevIO.Api
```
6. Execute
```
dotnet ef database update --startup-project ../DevIO.Api
```
