# API - ProjetoDBZ

Uma API RESTful desenvolvida em **ASP.NET Core 8.0** para gerenciar personagens de Dragon Ball Z. O projeto utiliza Entity Framework Core para acesso aos dados e MySQL como banco de dados.

## 📋 Requisitos

- **.NET 8.0** ou superior
- **MySQL 5.7** ou superior

## 🚀 Começando

### 1. Clonar/Abrir o Projeto

```bash
cd ProjetoDBZ
```

### 2. Configurar Banco de Dados

Edite o arquivo `appsettings.json` com as credenciais do seu MySQL:

```json
"ConnectionStrings": {
    "AppDbConnectionString": "server=localhost; database=DBZ; User=root; Password=SuaSenha;"
}
```

### 3. Executar Migrações

```bash
dotnet ef database update
```

### 4. Executar a Aplicação

```bash
dotnet run
```

A API estará disponível em `https://localhost:5001`

## 📚 Documentação da API

### Swagger UI

Com a aplicação em execução, acesse a documentação interativa em:
```
https://localhost:5001/swagger
```

### Endpoints

#### POST `/api/personagens`
Criar um novo personagem.

**Request Body:**
```json
{
  "nome": "Goku",
  "tipo": "Saiyajin"
}
```

**Response:** `201 Created`

---

#### GET `/api/personagens`
Obter todos os personagens.

**Response:** `200 OK`
```json
[
  {
    "id": 1,
    "nome": "Goku",
    "tipo": "Saiyajin"
  }
]
```

---

#### GET `/api/personagens/{id}`
Obter um personagem específico.

**Response:** `200 OK`
```json
{
  "id": 1,
  "nome": "Goku",
  "tipo": "Saiyajin"
}
```

---

#### PUT `/api/personagens/{id}`
Atualizar um personagem existente.

**Request Body:**
```json
{
  "nome": "Goku",
  "tipo": "Super Saiyajin"
}
```

**Response:** `201 Created`

---

#### DELETE `/api/personagens/{id}`
Deletar um personagem.

**Response:** `200 OK`

## 📦 Estrutura do Projeto

```
ProjetoDBZ/
├── Controllers/
│   └── PersonagensController.cs    # Endpoints da API
├── Models/
│   └── Personagem.cs               # Modelo de dados
├── Data/
│   └── AppDbContext.cs             # Contexto do Entity Framework
├── Migrations/                       # Migrações do banco de dados
├── Properties/
│   └── launchSettings.json          # Configurações de launch
├── appsettings.json                 # Configurações da aplicação
├── Program.cs                       # Configuração da aplicação
└── ProjetoDBZ.csproj               # Arquivo de projeto
```

## 🔧 Dependências

- **Microsoft.EntityFrameworkCore** v8.0.2
- **Pomelo.EntityFrameworkCore.MySql** v8.0.2
- **Swashbuckle.AspNetCore** v6.6.2

## 📝 Validações

O modelo `Personagem` possui as seguintes validações:

- **Nome**: Obrigatório, máximo 120 caracteres
- **Tipo**: Obrigatório, máximo 50 caracteres

## 🛠️ Desenvolvimento

### Compilar o Projeto

```bash
dotnet build
```

### Criar Nova Migração

```bash
dotnet ef migrations add NomeDaMigracao
```

### Atualizar Banco de Dados

```bash
dotnet ef database update
```

## 📄 Licença

Este projeto é um projeto de estudo.
