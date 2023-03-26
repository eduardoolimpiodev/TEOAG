# TEOAG - Test Eduardo Olimpio Auto Glass


-Add : global.json
(Command Line Interface - CLI 
-dotnet new globaljson)

Limpar certificado digital:
dotnet dev-certs https --clear

Criar certificado digital:
dotnet dev-certs https --trust

Contrato Swagger:
https://localhost:[port]/swagger/v1/swagger.json

Criação das migrations dentro da pasta Data:
dotnet ef migrations add Initial -o Data/Migrations

