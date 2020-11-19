# IntroEFCore
Introdução ao EFCore

# Comandos Utilizados
```
dotnet tool install --global dotnet-ef --version 3.1.5
dotnet ef

[Cria Migration]
dotnet ef migrations add PrimeiraMigracao -p .\Efcore\Efcore.csproj

[Cria script SQL]
dotnet ef migrations script -p .\Efcore\Efcore.csproj -o .\Efcore\Migrations\PrimeiraMigracao.sql

[Executa Script SQL]
dotnet ef database update -p .\Efcore\Efcore.csproj -v
```

# Dependências Necessárias para Migração
```
Microsoft.EntityFrameworkCore.Tools
Microsoft.EntityFrameworkCore.Design

```
