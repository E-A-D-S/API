
# WebAPi

Este projeto é uma API da Web desenvolvida usando ASP.NET Core. Ela oferece duas principais funcionalidades e inclui testes para garantir o funcionamento correto.
## Funcionalidades

- Autenticação de Usuários e Geração de Tokens JWT: Esta parte da API permite autenticar usuários e gerar tokens JWT (JSON Web Tokens) para autenticação subsequente. Apesar de a autenticação estar implementada, ocorre um erro ao tentar autenticar usando o token gerado. No entanto, a geração do token está funcionando corretamente.

- CRUD de Pessoas (Persons): A API oferece operações CRUD (Create, Read, Update, Delete) para entidades de pessoa. Os endpoints correspondentes permitem criar, listar, atualizar e excluir registros de pessoas no banco de dados.

## Tecnologias Utilizadas

- ASP.NET Core: Framework para desenvolvimento de aplicativos Web.


- Entity Framework Core: ORM (Object-Relational Mapper) para mapeamento objeto-relacional.


- SQLite: Banco de dados embutido para armazenamento de dados.


- Swagger: Ferramenta para documentação automatizada da API.


- AutoMapper: Biblioteca para mapeamento de objetos.

- JSON Web Tokens (JWT): Método para autenticação de usuários e geração de tokens.

## Pacotes utilizados

- AutoMapper
- Microsoft.AspNetCore.Authentication.JwtBearer
- Microsoft.AspNetCore.Mvc.ApiExplorer
- Microsoft.AspNetCore.Mvc.Versioning.ApiExplorer
- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.Design
- Microsoft.EntityFrameworkCore.SQLite
- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.IdentityModel.Tokens
- Moq
- Swashbuckle.AspNetCore
- System.IdentityModel.Tokens.Jwt


## Rodando localmente

Para executar este projeto localmente, siga as etapas abaixo:

1. __Instalando o DBeaver__: Baixe e instale o DBeaver a partir do site oficial.

```bash
https://dbeaver.io/download/
```

2. __Instalando o SDK.NET__: Você pode instalar o SDK .NET seguindo as instruções aqui.
```bash
https://learn.microsoft.com/pt-br/dotnet/core/install/windows?tabs=net80
```

Alternativamente, você pode usar o seguinte comando no Terminal (por exemplo, PowerShell):

```bash
winget install Microsoft.DotNet.SDK.8
```
3. __Clonando o Projeto__: Clone este repositório usando o seguinte comando:
```bash
git clone https://github.com/E-A-D-S/API
```
4. __Configurando o Banco de Dados no DBeaver__:

- Abra o DBeaver;
- Crie uma nova conexão e selecione o SQLite;
- Abra o arquivo ConnectionContext.db localizado na pasta do projeto;
- Para visualizar as tabelas, vá para "Geral" -> "Conexões" -> ConnectionContext.db.

5. __Abrindo o Projeto__:
Se estiver utilizando o Visual Studio, abra a pasta do projeto e restaure os pacotes necessários com o seguinte comando:
```bash
dotnet restore
```
Em seguida, inicie o servidor pressionando as teclas: 
```bash
Ctrl+F5
``` 
__O servidor estará disponível em__:

https://localhost:7171/swagger/index.html


Se estiver utilizando o Visual Studio Code:

- Abra um novo terminal e navegue até a pasta do projeto;
- Execute o comando abaixo para selecionar o projeto:
```bash
cd WebApi
``` 
- Em seguida, restaure os pacotes e inicie o servidor com os seguintes comandos:
```bash
dotnet restore
dotnet run
``` 
6. __Instalando Pacotes Manualmente__ (se necessário): Se o servidor não iniciar, você pode precisar instalar manualmente os pacotes. Execute os seguintes comandos dentro do terminal:
```bash
dotnet add package AutoMapper --version 13.0.1
dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer --version 8.0.4
dotnet add package Microsoft.AspNetCore.Mvc.ApiExplorer --version 2.2.0
dotnet add package Microsoft.AspNetCore.Mvc.Versioning.ApiExplorer --version 5.1.0
dotnet add package Microsoft.EntityFrameworkCore --version 8.0.4
dotnet add package Microsoft.EntityFrameworkCore.Design --version 8.0.4
dotnet add package Microsoft.EntityFrameworkCore.SQLite --version 8.0.4
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 8.0.4
dotnet add package Microsoft.IdentityModel.Tokens --version 7.5.1
dotnet add package Moq --version 4.20.70
dotnet add package Swashbuckle.AspNetCore --version 6.5.0
dotnet add package System.IdentityModel.Tokens.Jwt --version 7.5.1
``` 
Em seguida, execute novamente o comando para iniciar o servidor:
```bash
dotnet run 
```

7. __Visualizando os Endpoints no Swagger__: Após iniciar o servidor, abra o navegador e digite o seguinte link para visualizar os endpoints no Swagger:
https://localhost:7171/swagger/index.html

Agora você está pronto para explorar e utilizar cada endpoint disponível localmente.