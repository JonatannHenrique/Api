🚀 API BACK-END EM C#
Este repositório contém uma API back-end desenvolvida em C#, utilizando ASP.NET Core Web API, conectada a um banco de dados MySQL, com estrutura pronta para comunicação com um front-end via requisições HTTP.

⚙️ SOBRE O PROJETO
1️⃣ Projeto criado no Visual Studio usando o template de API Web do ASP.NET Core
2️⃣ A API recebe dados do front-end (repositório com nome My)
3️⃣ Utiliza Entity Framework Core para gerenciamento do banco de dados
4️⃣ A tabela Usuarios é criada automaticamente e usa o campo Email como chave primária
5️⃣ A API roda em IIS Express (Container Runtime)
6️⃣ Comunicação entre o site e a API feita por meio de chamadas HTTP REST

🛠️ TECNOLOGIAS E PACOTES USADOS
✅ C# / .NET 7.0

✅ MySQL

✅ Visual Studio 2022

✅ IIS Express (runtime)

✅ Pacotes NuGet:

Microsoft.EntityFrameworkCore

Microsoft.EntityFrameworkCore.Design

Microsoft.EntityFrameworkCore.Tools

🔥 FUNCIONALIDADES
Recebe dados do usuário via POST

Lista todos os usuários cadastrados via GET

Criação automática da tabela Usuarios no banco de dados

⚙️ CONFIGURAÇÃO DO BANCO (appsettings.json)
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
⚠️ Substitua SuaSenhaAqui pela senha real do seu MySQL.

🔗 EXEMPLOS DE ENDPOINTS
📤 POST /api/usuarios
Envia um novo usuário:

json
Copiar
Editar
{
  "name": "",
  "age": 0,
  "email": "",
  "number": 0,
  "password": ""
}
📥 GET /api/usuarios
Retorna a lista de usuários cadastrados:

json
Copiar
Editar
[
  {
    "name": "",
    "age": 0,
    "email": "",
    "number": 0,
    "password": ""
  }
]
