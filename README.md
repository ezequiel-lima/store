# API de Store: Refatoração e Testes com MSTests

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://github.com/ezequiel-lima/store/blob/master/LICENSE.txt)

A aplicação atual tem como foco a refatoração do código para permitir testes utilizando o MSTest. O projeto em si serve como um estudo para implementação de testes unitários, a Api foi reestruturada visando a facilitar a criação e execução de testes unitários.

A refatoração incluiu a separação das responsabilidades, a criação de interfaces para abstrair a lógica de negócio e a utilização de injeção de dependência para facilitar a substituição de implementações durante os testes.

Para facilitar a criação de testes, foram utilizados repositórios falsos (FakeRepositories) que simulam o acesso aos dados. Esses repositórios fornecem dados predefinidos para permitir a execução dos testes de forma controlada.

## Demonstração 

Testes

![Tests](https://github.com/ezequiel-lima/store/assets/81567476/4f063208-061d-48d6-bd9c-0e309d60ad68)

FakeRepositories

![FakeRepositories](https://github.com/ezequiel-lima/store/assets/81567476/7c7e24d4-4c89-4f10-a436-bec2769627bd)

## Como executar o projeto
Para executar o projeto, siga as seguintes etapas:

1. Clone este repositório em sua máquina local usando o comando git clone `https://github.com/ezequiel-lima/store.git`
2. Abra o projeto no Visual Studio ou em outra IDE de sua preferência.
3. Compile o projeto e execute a aplicação.

## Conclusão
Em suma, a refatoração e implementação de testes com MSTests aprimoraram a API de Store, promovendo uma melhor organização do código e assegurando a qualidade dos testes unitários, resultando em uma aplicação mais robusta e confiável.
