# IntroEFCore
Introdução ao EFCore

# Dependências Necessárias para Migração
```
Microsoft.EntityFrameworkCore.Tools
Microsoft.EntityFrameworkCore.Design

```

# Comandos Utilizados
```
dotnet tool install --global dotnet-ef --version 3.1.5
dotnet ef

[Cria Migration]
dotnet ef migrations add PrimeiraMigracao -p .\Efcore\Efcore.csproj

[Cria script SQL]
dotnet ef migrations script -p .\Efcore\Efcore.csproj -o .\Efcore\Migrations\PrimeiraMigracao.sql

[Criar script SQL Idempotente]
dotnet ef migrations script -p .\Efcore\Efcore.csproj -o .\Efcore\Migrations\Idempotente.sql -i

[Executa Script SQL]
dotnet ef database update -p .\Efcore\Efcore.csproj -v

[RoolBack Migrations]
dotnet ef database update PrimeiraMigracao -p .\Efcore\Efcore.csproj -v

[Remover Migrations]
dotnet ef migrations remove -p .\Efcore\Efcore.csproj
```

#Operações CRUD
```
[ADICIONAR]
1º - db.Produto.Add(produto);
2º - db.Set<Produto>().Add(produto);
3º - db.Entry(produto).State = EntityState.Added;
4º - db.Add(produto);

[ADICIONAR EM MASSA]
db.AddRange(cliente,produto);

[CONSULTA]
var consultaPorSintaxe = (from c in db.Clientes where c.Id>0 select c).ToList();
var consultaPorMetodo = db.Clientes.Where(p => p.Id > 0).ToList();

[NoTracking]
var consultaPorMetodo = db.Clientes.AsNoTracking().Where(p => p.Id > 0).ToList();

Obs: O método "Find" quando não se utiliza "AsNoTracking()" ele retorna dados em memoria.


```
