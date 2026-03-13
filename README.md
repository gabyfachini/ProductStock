# 📦 Stock Manager

---

## [🇧🇷] Português

### Sobre o projeto

Sistema de gerenciamento de estoque desenvolvido em **C# (.NET)** como projeto de aprendizado de Programação Orientada a Objetos (POO). O programa roda no terminal e permite cadastrar produtos, controlar quantidades e acompanhar o valor total do inventário.

### Funcionalidades

- ✅ Cadastrar produto com nome, fornecedor, categoria, quantidade e preço
- ✅ Adicionar unidades ao estoque de um produto existente
- ✅ Sobrescrever a quantidade em estoque de um produto
- ✅ Remover produto da lista
- ✅ Listar todos os produtos com valor total por item e valor total do inventário
- ✅ Validação de entradas do usuário

### Estrutura do projeto

```
StockManager/
├── Program.cs          # Ponto de entrada — menu principal e loop de interação
├── Stock.cs            # Classe abstrata Stock e implementação concreta Store
├── ProductList.cs      # Gerenciamento da lista de produtos (adicionar, listar, atualizar, remover)
```

### Conceitos de POO aplicados

| Conceito | Onde é usado |
|---|---|
| **Abstração** | Classe abstrata `Stock` define o contrato comum |
| **Herança** | `Store` herda de `Stock` |
| **Polimorfismo** | `AddProducts()`, `UpdateStock()` e `AddToStock()` sobrescritos em `Store` |
| **Encapsulamento** | Propriedades com `get/set`, lista privada em `ProductList` |

### Como executar

**Pré-requisito:** .NET SDK instalado ([download](https://dotnet.microsoft.com/download))

```bash
# Clone o repositório
git clone https://github.com/seu-usuario/stock-manager.git
cd stock-manager

# Execute o projeto
dotnet run
```

---

## [🇺🇸] English

### About

A terminal-based **inventory management system** built in **C# (.NET)** as a learning project focused on Object-Oriented Programming (OOP) concepts. It allows users to register products, manage stock quantities, and track total inventory value.

### Features

- ✅ Register a product with name, supplier, category, quantity, and unit price
- ✅ Add units to an existing product's stock
- ✅ Overwrite the current stock quantity of a product
- ✅ Remove a product from the list
- ✅ List all products with per-item total value and overall inventory value
- ✅ Input validation throughout

### Project structure

```
StockManager/
├── Program.cs          # Entry point — main menu and interaction loop
├── Stock.cs            # Abstract class Stock and concrete implementation Store
├── ProductList.cs      # Product list management (add, list, update, remove)
```

### OOP concepts applied

| Concept | Where it's used |
|---|---|
| **Abstraction** | Abstract class `Stock` defines the shared contract |
| **Inheritance** | `Store` inherits from `Stock` |
| **Polymorphism** | `AddProducts()`, `UpdateStock()` and `AddToStock()` overridden in `Store` |
| **Encapsulation** | Properties with `get/set`, private list inside `ProductList` |

### How to run

**Prerequisite:** .NET SDK installed ([download](https://dotnet.microsoft.com/download))

```bash
# Clone the repository
git clone https://github.com/your-username/stock-manager.git
cd stock-manager

# Run the project
dotnet run
```

---

*Developed as a C# / OOP learning project.*
