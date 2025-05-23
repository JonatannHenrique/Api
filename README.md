API Back-end em C# (.NET 7.0) com MySQL
Este repositório contém a API Back-end desenvolvida em C# usando .NET 7.0, pronta e funcional para gerenciar os dados de um site.

Descrição do Projeto
A API foi construída para receber dados coletados a partir do front-end do site, processar esses dados e armazená-los em um banco de dados MySQL.

O front-end do site, que coleta e envia os dados para esta API, está disponível em outro repositório chamado My.

A comunicação entre o front-end e a API é feita via requisições HTTP, e a API gerencia a persistência dos dados no banco MySQL.

Para o runtime, utilizei o Container IIS Express para facilitar o desenvolvimento e testes locais.

Tecnologias e Pacotes Utilizados
.NET 7.0 (SDK e runtime)

MySQL como banco de dados relacional

Pacotes NuGet usados:

Microsoft.EntityFrameworkCore

Microsoft.EntityFrameworkCore.Design

Microsoft.EntityFrameworkCore.Tools

Esses pacotes foram essenciais para trabalhar com o Entity Framework Core, facilitando o mapeamento objeto-relacional (ORM) e o gerenciamento do banco de dados.

Estrutura
API Back-end: Recebe dados via requisições HTTP, processa e salva no MySQL.

Front-end (repositório My): Site que coleta os dados do usuário e conecta com essa API.

Como Rodar o Projeto
Clone este repositório

Configure a string de conexão para seu banco MySQL no arquivo appsettings.json

Restaure os pacotes NuGet:

bash
Copiar
Editar
dotnet restore
Execute as migrações (se houver):

bash
Copiar
Editar
dotnet ef database update
Rode a API usando o Container IIS Express (normalmente via Visual Studio ou configurações do projeto)

Use o front-end do repositório My para testar a comunicação com a API.
