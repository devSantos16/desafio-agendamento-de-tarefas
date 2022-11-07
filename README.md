# desafio-agendamento-de-tarefas
Desafio de agendamento de tarefas usando ASP.NET e Entity Framework

Para usar você deve ter instalado: 

Entity Framework
.NET 
SQL Server

Para rodar o programa você deve rodar as migrations e upar no banco de dados SQL Server

Comandos:

// Add pacote do Entity
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.SqlServer

// Adiciona um commit do entity framework no codigo
dotnet-ef migrations add CriacaoTabelaContato
// Push
dotnet-ef database update

// Para rodar
dotnet watch run
