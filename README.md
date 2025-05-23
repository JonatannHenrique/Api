🚀 API BACK-END EM C#

Este repositório contém uma API back-end desenvolvida em C#, utilizando ASP.NET Core Web API, conectada a um banco de dados MySQL, com estrutura pronta para comunicação com um front-end via requisições HTTP.

📌 SOBRE O PROJETO

🔹 Projeto criado no Visual Studio usando o template de API Web do ASP.NET Core

🔹 A API recebe dados do front-end (repositório com nome (My))

🔹 Utiliza Entity Framework Core para gerenciamento do banco de dados

🔹 A tabela Usuarios é criada automaticamente e usa o campo Email como chave primária

🔹 A API roda em IIS Express (Container Runtime)

🔹 Comunicação entre o site e a API feita por meio de chamadas HTTP REST

🛠️ TECNOLOGIAS E PACOTES USADOS

✅ C# / .NET 7.0

✅ MySQL

✅ Visual Studio 2022

✅ IIS Express (runtime)

✅ Pacotes NuGet:

Microsoft.EntityFrameworkCore

Microsoft.EntityFrameworkCore.Design

Microsoft.EntityFrameworkCore.Tools

🔧 CONFIGURAÇÃO DO BANCO (appsettings.json)

json
Copiar
Editar
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;port=3300;user=root;password=SuaSenhaAqui;database=bancoteste;"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Debug",
      "Microsoft": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*"
}
⚠️ Importante: Substitua "SuaSenhaAqui" pela sua senha real do MySQL.

