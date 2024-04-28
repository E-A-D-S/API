
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

## Testes

Para garantir o funcionamento correto da API, foram desenvolvidos testes unitários utilizando o framework NUnit com o pacote Moq. Esses testes são essenciais para validar a funcionalidade e a integridade das operações da API.

Os testes foram organizados em um projeto separado chamado "TestProject1" e referenciados diretamente no projeto da Web API. Isso permite executar os testes diretamente do Visual Studio, proporcionando uma abordagem eficiente para validar a lógica de negócios, as operações CRUD e outras funcionalidades que futuramente serão implementadas na API.

#### Para a Execução do teste:

1. Abra o projeto da API no Visual Studio.
2. Navegue até o Explorer de Testes (Test Explorer)
3. Execute os testes e verifique se todos são aprovados corretamente. Atualmente, estão implementados quatro testes, cada um representando uma operação CRUD (Create, Read, Update, Delete).

Agora você está pronto para explorar e utilizar cada endpoint disponível localmente.


# Documentação Automática da minha API em C#

Para essa documentação automática, escolhi utilizar a ferramenta Swagger. Essa decisão foi baseada na familiaridade adquirida durante o curso e nos benefícios identificados durante minha pesquisa, conforme detalhado abaixo:

1. **Especificação da API**: Com o Swagger, é possível definir os modelos de dados e as funcionalidades da API de forma clara e organizada, usando o OpenAPI Specification.

2. **Facilidade na Implementação**: A ferramenta Swagger Codegen automatiza a geração do código inicial em diversas linguagens de programação, simplificando o processo de implementação da API.

3. **Testes de API**: O Swagger oferece ferramentas para realizar testes manuais, automatizados e de desempenho, garantindo o funcionamento, desempenho e confiabilidade da aplicação.

4. **Visualização Intuitiva**: O Swagger disponibiliza ferramentas para tornar a visualização da API mais intuitiva, permitindo a interação com a API de forma amigável.

## Formas de Criar a Documentação

O Swagger permite criar a documentação da API de três formas:

1. **Automaticamente**: A documentação é gerada simultaneamente ao desenvolvimento da API.

2. **Manualmente**: Os desenvolvedores podem escrever livremente as especificações da API e publicá-las posteriormente em seu próprio servidor.

3. **Codegen**: Converte as anotações contidas no código fonte das APIs REST em documentação. O Swagger Editor é uma ferramenta online que facilita a criação manual da documentação, permitindo utilizar YAML para descrever os serviços e fornecendo templates de documentos como base.

## Swagger UI

Com o Swagger UI, é possível criar documentações elegantes e acessíveis ao usuário, permitindo uma compreensão maior da API. Os usuários podem interagir intuitivamente com a API usando uma sandbox, onde podem realizar testes sem interferir no ambiente de produção.

## Versionamento de Projeto no Swagger

No contexto do desenvolvimento de APIs, o versionamento é essencial para gerenciar alterações e evoluções na estrutura e funcionalidades da API. Mesmo que seu projeto inicialmente possua apenas uma versão, é importante entender como realizar o versionamento para futuras atualizações.

### Necessidade do Versionamento

O versionamento se faz necessário em qualquer caso de alteração da API. Isso pode incluir a remoção de atributos do sistema, adição de novidades ou modificações para melhorar o desempenho ou adicionar funcionalidades. 

### Demonstração de Versionamento

Para ilustrar a importância e a prática do versionamento, no contexto do Swagger, foi criada uma segunda versão da API. Esta segunda versão contém apenas o CRUD de pessoas, demonstrando como é possível evoluir a API de forma incremental, mantendo o controle e a compatibilidade com versões anteriores.

O versionamento no Swagger permite que diferentes versões da API coexistam harmoniosamente, facilitando a transição e garantindo a compatibilidade com clientes existentes.

## Referências

- **Documentando sua API REST com Swagger**: Este artigo fornece uma visão geral das ferramentas disponíveis para documentação de APIs, incluindo o Swagger, e explica como utilizar o Swagger para documentar APIs REST. [Link](https://www2.decom.ufop.br/terralab/documentando-sua-api-rest-com-swagger/#:~:text=Existem%20v%C3%A1rias%20ferramentas%20que%20ajudam,API%20Blueprint%2C%20RAML%20e%20Swagger.)

- **Versionamento de API**: Este artigo discute a importância do versionamento de API, os desafios que ele enfrenta e as melhores práticas associadas a ele. Ele destaca como o versionamento pode evitar quebras de contrato e manter a compatibilidade com versões anteriores. [Link](https://br.hubspot.com/blog/marketing/versionamento-de-api#:~:text=J%C3%A1%20o%20versionamento%20de%20API,ser%20uma%20quebra%20de%20contrato.)

- **O que é versionamento de API e as melhores práticas**: Este artigo explora a definição de versionamento de API, seu propósito e as melhores práticas associadas a ele. Ele enfatiza a importância do versionamento para garantir a estabilidade e a evolução das APIs ao longo do tempo. [Link](https://www.sensedia.com.br/post/o-que-e-versionamento-de-api-e-as-melhores-praticas#:~:text=As%20APIs%20s%C3%A3o%20consumidas%20a,(e%20possivelmente%20as%20integra%C3%A7%C3%B5es).)

## Screenshots
- Nova Conexão Banco de dados SqlLite no Dbeaver
  
![Dbeaver](https://github.com/E-A-D-S/API/blob/main/Imagens/Nova%20Conex%C3%A3o%20Dbeaver.png)

- Selecionando novo Banco de dados SqlLite
  
![Selecionando novo Banco de dados SqlLite](https://github.com/E-A-D-S/API/blob/main/Imagens/Selecione%20o%20Sql.Lite.png)

- Adicionando arquivo do banco de dados
  
![Adicionando arquivo do banco de dados](https://github.com/E-A-D-S/API/blob/main/Imagens/Abrindo%20Arquivo%20do%20banco%20de%20dados.png)

- Visualizando as tabelas de dados
  
![Visualizando as tabelas de dados](https://github.com/E-A-D-S/API/blob/main/Imagens/Abrindo%20Tabelas%20para%20ver%20o%20banco%20de%20dados.png)

- Projeto No Visual Studio
  
![Pastas do projeto Visual Studio](https://github.com/E-A-D-S/API/blob/main/Imagens/Pastas%20projeto.png)

- Versão 1 do Projeto
  
![Versão 1 do Projeto](https://github.com/E-A-D-S/API/blob/main/Imagens/Pagina1%20versao1.png)

- Versão 2 do Projeto
  
![Versão 2 do projeto](https://github.com/E-A-D-S/API/blob/main/Imagens/Pagina%202%20Vers%C3%A3o%202.png)

- Abrindo o teste
  
![Abrindo o teste](https://github.com/E-A-D-S/API/blob/main/Imagens/Executar%20teste.png)

- Executando o teste
  
![Executando o teste](https://github.com/E-A-D-S/API/blob/main/Imagens/Teste%20Em%20Andamento.png)

