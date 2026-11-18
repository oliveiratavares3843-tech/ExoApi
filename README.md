# ExoApi - API de Gerenciamento de Projetos

API RESTful desenvolvida em C# com ASP.NET Core e Entity Framework Core para gerenciamento de projetos no SQL Server.

## Funcionalidades e Endpoints

| Método | Rota | Descrição |
| :--- | :--- | :--- |
| **GET** | `/api/Projetos` | Lista todos os projetos cadastrados |
| **GET** | `/api/Projetos/{id}` | Busca um projeto específico pelo ID |
| **POST** | `/api/Projetos` | Cadastra um novo projeto |
| **PUT** | `/api/Projetos/{id}` | Atualiza todos os dados de um projeto |
| **PATCH** | `/api/Projetos/{id}` | Atualiza parcialmente um projeto |
| **DELETE** | `/api/Projetos/{id}` | Exclui um projeto pelo ID |

## Tecnologias Utilizadas
* C# / .NET
* ASP.NET Core Web API
* Entity Framework Core
* SQL Server
* Swagger (OpenAPI)

## Como Executar o Projeto
1. Configure a string de conexão com o SQL Server em `Contexts/ExoContext.cs`.
2. Execute `dotnet run` no terminal dentro da pasta do projeto.
3. Acesse a interface do Swagger pelo endereço exibido no terminal (ex: `http://localhost:5014`).
