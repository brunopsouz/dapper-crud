# 📦 OrderManagement - Projeto Pessoal com Dapper

Projeto pessoal desenvolvido para fins de prática com o micro ORM **Dapper**, utilizando **.NET 8** para criação de uma API simples de gerenciamento de pedidos (orders).

A aplicação conecta-se a um banco de dados **SQL Server**, executando comandos SQL diretamente com alta performance e controle total sobre as queries.

---

## Tecnologias Utilizadas

### Backend

- **.NET 8.0**
- **Dapper 2.1.35** 
- **SQL Server**
- **Microsoft.Data.SqlClient 5.2.2** 
- **Microsoft.Extensions.Configuration 8.0.0**

---

## Funcionalidades Implementadas

- Cadastro de pedidos
- Atualização e remoção de pedidos
- Listagem geral e por ID
- Conexão direta com banco de dados via SQL puro
- Estrutura organizada por camada (Models, Repositories, Controllers)

---

## Arquitetura

A solução é separada em quatro projetos, seguindo princípios de separação de responsabilidades:
- /OrderManagement.sln
- ├── OrderManagement.API → Camada de apresentação (controllers, endpoints)
- ├── OrderManagement.Application → Casos de uso (services, DTOs, lógica de aplicação)
- ├── OrderManagement.Domain → Entidades, interfaces e regras de negócio puras
- └── OrderManagement.Infrastructure→ Implementações (Dapper, repositórios, contextos)

---

### Passos

```bash
# Clonar o repositório
git clone https://github.com/brunopsouz/dapper-crud.git

# Acessar a pasta do projeto
cd dapper-crud

# Abrir a solution no Visual Studio ou executar via CLI
dotnet run --project OrderManagement.API
```

---

### Objetivo do Projeto
- Explorar e aplicar o uso de Dapper em um projeto real
- Aplicar princípios de arquitetura limpa com múltiplas camadas
- Desenvolver um backend performático com controle total sobre SQL
- Praticar boas práticas com separação de responsabilidades

---
