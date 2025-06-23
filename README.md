# 🧠 Exemplos de Princípios SOLID em C#

Este repositório tem como objetivo **ensinar e demonstrar na prática os princípios SOLID** da Programação Orientada a Objetos, utilizando a linguagem **C#** com **.NET**.

---

## 📚 O que é SOLID?

**S.O.L.I.D** é um acrônimo que representa cinco princípios de design de software, voltados para a criação de sistemas **mais coesos, desacoplados e fáceis de manter**:

| Letra | Princípio                         | Tradução                                |
|-------|-----------------------------------|------------------------------------------|
| S     | Single Responsibility Principle   | Princípio da Responsabilidade Única     |
| O     | Open/Closed Principle             | Princípio Aberto/Fechado                |
| L     | Liskov Substitution Principle     | Princípio da Substituição de Liskov     |
| I     | Interface Segregation Principle   | Princípio da Segregação de Interfaces   |
| D     | Dependency Inversion Principle    | Princípio da Inversão de Dependência    |

---

## 🗂 Organização do Repositório

Este repositório está organizado por diretórios e branches. Cada diretório representa um princípio, e cada branch mostra uma versão com o código **violando** e outra **corrigindo** o princípio.

### ✅ Padrão de Branches

| Branch                      | Conteúdo                          |
|----------------------------|-----------------------------------|
| `feature/srp-violado`      | Código que **viola** o SRP        |
| `feature/srp-correto`      | Código **corrigido** com SRP      |
| `feature/ocp-violado`      | Código que **viola** o OCP        |
| `feature/ocp-correto`      | Código **corrigido** com OCP      |
| ...                        | E assim por diante para L, I, D   |

### ✅ Padrão de Tags

| Tag            | Significado                                |
|----------------|---------------------------------------------|
| `srp-violado`  | Commit principal com código incorreto (SRP) |
| `srp-correto`  | Commit com refatoração aplicando SRP        |
| `ocp-violado`  | Commit principal com código incorreto (OCP) |
| `ocp-correto`  | Commit com refatoração aplicando OCP        |

---

## 🚀 Como Executar os Exemplos

```bash
git clone https://github.com/seuusuario/solid-csharp-exemplos.git
cd solid-csharp-exemplos

## Alternar entre os  exemplo
git checkout srp-violado
dotnet run

git checkout srp-correto
dotnet run
```

---

## 💻 Tecnologias Utilizadas
.NET 8+

C#

Git e GitHub

---

## 👨‍🏫 Ideal para...
Aulas sobre design de software e boas práticas

Avaliações técnicas

Mentoria de novos desenvolvedores(as)

Estudos individuais

---

## 📄 Licença
Este projeto está sob a licença MIT. Sinta-se à vontade para usar e adaptar em suas aulas ou projetos!

Desenvolvido com 💙 por Jefferson Nogueira de Oliveira