# E-commerce Platform – Backend API

## **Visão Geral**

Este repositório contém o **backend de uma plataforma de e-commerce**, desenvolvido como uma **API REST em .NET**, responsável pelo gerenciamento de produtos e pedidos.

O projeto utiliza o **Dapper** como micro-ORM, priorizando **performance**, **controle direto das consultas SQL** e **simplicidade** na estrutura do backend.

---

## **Arquitetura e Decisões Técnicas**

- Estrutura baseada em **separação de responsabilidades**, organizada em:
  - **Controllers** – responsáveis por receber e tratar as requisições HTTP  
  - **Repositories** – camada de acesso a dados, utilizando **Dapper**  
  - **Models** – definição das entidades de domínio  

- Uso do **Dapper** para:
  - Execução de queries SQL explícitas  
  - Mapeamento leve e performático de dados  
  - Maior previsibilidade no acesso ao banco  

---

## **Escopo da API**

A API oferece suporte às funcionalidades essenciais de um e-commerce, incluindo:

- **Cadastro e consulta de produtos**
- **Criação e gerenciamento de pedidos**
- **Operações CRUD** sobre as entidades do domínio
- **Persistência de dados comerciais**
