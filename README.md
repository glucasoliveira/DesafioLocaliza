
<!-- TABLE OF CONTENTS -->
<details open="open">
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#about-the-project">Sobre o projeto</a>
      <ul>
        <li><a href="#built-with">Construído com</a></li>
      </ul>
    </li>
    <li>
      <ul>
        <li><a href="#prerequisites">Pré requisitos</a></li>
      </ul>
    </li>
    <li><a href="#contact">Contato</a></li>
  </ol>
</details>



<!-- ABOUT THE PROJECT -->
## Sobre o Projeto

[![product-screenshot]]

O desafio se consiste em implementar um projeto para suportar uma alta demanda de abertura e manutenção de contratos de aluguel em uma empresa, além de definir a arquitetura para a migração do produto legado composto de uma aplicação integrada com uma base de dados já existente.

### Funcionalidades

O projeto conta com 3 controllers: Contrato, Cliente e Veículo

#### Contrato

* Busca de contratos no Banco de Dados
* Busca de contratos no Banco de Dados baseado no ID
* Busca de contratos no Banco de Dados baseado no CPF
* Criação de contrato
* Atualização de contrato

#### Cliente

* Busca de clientes no Banco de Dados
* Busca de clientes no Banco de Dados baseado no CPF
* Busca de clientes no Banco de Dados baseado na cidade
* Criação de cliente

#### Veículo

* Busca de veículos no Banco de Dados
* Busca de veículos no Banco de Dados baseado no ID
* Busca de veículos no Banco de Dados baseado na placa
* Criação de veículo

### Built With

* [.NET Framework](https://dotnet.microsoft.com/download/dotnet-framework/net472)
* [Swagger](https://swagger.io)


### Pré Requisitos

É necessário a criação um banco de dados chamado EnterpriseDatabase.
* EnterpriseDatabase
  ```sh
  sql/EnterpriseDatabase.sql
  ```

Também é necessário a criação das seguintes tabelas

* Cliente
  ```sh
  sql/Clientes.sql
  ```	

* Contratos
  ```sh
  sql/Contratos.sql
  ```	

* Veiculos
  ```sh
  sql/Veiculos.sql
  ```	

<!-- CONTACT -->
## Contact

Gabriel Lucas - gabriellucasoliveiradealmeida@gmail.com

<!-- MARKDOWN LINKS & IMAGES -->
[product-screenshot]: images/screenshot.png
