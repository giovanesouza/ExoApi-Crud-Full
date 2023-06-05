# Desenvolvimento de APIs

<p>Curso Programador Back-end | Entrega da atividade 04 - Senai</p>

* Implementar os métodos POST, PUT e DELETE, além de realizar a busca de registro por ID. 

>> Por meio deste projeto é possível realizar um CRUD completo: CREATE, READ, UPDATE e DELETE. <br/>
>> Para realizar as requisições foi utilizado o POSTMAN.


## Código para criação do BD, Tabela e Inserts (SQL Server)

```sql

CREATE DATABASE ExoApi
GO

USE ExoApi
GO

CREATE TABLE Projetos (
    Id INT PRIMARY KEY IDENTITY,
    NomeDoProjeto VARCHAR(150) NOT NULL,
    Area VARCHAR(150) NOT NULL,
    Status BIT
)
GO

INSERT INTO Projetos (NomeDoProjeto, Area, Status) 
VALUES ('Projeto A - Obras BR', 'Construção Civil', 1)
GO

INSERT INTO Projetos (NomeDoProjeto, Area, Status) 
VALUES ('Projeto B - SENAI Fest', 'Eventos', 0)
GO

INSERT INTO Projetos (NomeDoProjeto, Area, Status) 
VALUES ('Projeto C - Hackathon Fest', 'Eventos', 1)
GO

-- UPDATE Projetos SET NomeDoProjeto = 'NomeDoProjeto A1' Where Id = 1;

 -- DELETE FROM Projetos WHERE Id = 1;

SELECT Id, NomeDoProjeto, Area, Status FROM Projetos
GO

CREATE TABLE Usuarios (
    Id INT PRIMARY KEY IDENTITY,
    Email VARCHAR(255) NOT NULL UNIQUE,
    Senha VARCHAR(120) NOT NULL
)
GO

INSERT INTO Usuarios VALUES ('email@sp.br', '1234')
GO

INSERT INTO Usuarios VALUES ('email_dois@sp.br', '1234')
GO

SELECT * FROM Usuarios
GO

```


## Resultado obtido

### Método GET - https://localhost:7154/api/projetos
>> Lista todos os registros
![GetAll - Lista todos os registros](screenshots/GetAll.jpg)

### Método POST - https://localhost:7154/api/projetos
>> Realiza cadastro
![Post - Cadastra](screenshots/Post.jpg)

### Método GET - https://localhost:7154/api/projetos/id
>> Exibe um registro
![GetOne - Pega um registro](screenshots/GetOne.jpg)

### Método PUT - https://localhost:7154/api/projetos/id
>> Atualiza um registro
![Put - Atualiza registro](screenshots/Put.jpg)

### Método DELETE - https://localhost:7154/api/projetos/id
>> Exclui um registro
![Delete - Exclui um registro](screenshots/Delete.jpg)
