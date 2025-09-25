# 📚 Projeto Final POO - Integração C# e DB

Neste projeto, foi desenvolvido um **sistema de venda de componentes** desenvolvido em **C#** utilizando **Programação Orientada a Objetos (POO)** e integrado a um **banco de dados**. O sistema foi criado para **registrar clientes, componentes e vendas**, permitindo gerenciar de forma organizada todo o processo de comercialização de componentes para os clientes.  

A aplicação aplica conceitos fundamentais de POO, como **encapsulamento**, **herança** e **polimorfismo**, garantindo um código estruturado e de fácil manutenção. A integração com o banco de dados possibilita que todas as informações sejam armazenadas de forma segura, permitindo consultas rápidas e geração de relatórios confiáveis.  

Este projeto demonstra como construir uma aplicação C# robusta, organizada e capaz de gerenciar de forma eficiente operações de venda em um cenário realista.

---

## 🚀 Funcionalidades

- ✅ Registro de clientes
- ✅ Registro de Componentes
- ✅ Registro de Vendas (Componentes para clientes)
- ✅ Interface responsiva e amigável com Windows Forms
  
---

## 🛠️ Tecnologias Utilizadas

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![PostgreSQL](https://img.shields.io/badge/PostgreSQL-336791?style=for-the-badge&logo=postgresql&logoColor=white)
![Visual Studio](https://img.shields.io/badge/Visual_Studio-5C2D91?style=for-the-badge&logo=visual-studio&logoColor=white)

| 📌 Interface | ⚙️ Backend | 🗄️ Banco de Dados |
|---|---|---|
| Windows Forms - Microsoft Visual Studio | C# | PostgreSQL |

---

## 📂 Estrutura do Repositório

```bash
📁 .vs/
📁 wfaProjetoVendaComponente/
│  ├─ components/
│  └─ pages/
├─ 📁 uploads/
├─ 📄 server.js
├─ 📄 users.db
└─ 📄 README.md
```

---

## 🧑🏽‍💻 Criação do Projeto

1. Criamos o projeto React:
```bash
npx create-react-app vestlink
cd vestlink
npm start
```
2. Instalamos as bibliotecas necessárias:
```bash
npm install react-bootstrap bootstrap
npm install react-router-dom
npm install express
...
```

---

## 🗂️ Banco de Dados

O projeto utiliza SQLite no desenvolvimento local, por ser leve e não exigir configuração de servidor.

Ele armazena dados como usuários, postagens, perfis e materiais.

### 📌 Estrutura de Dados

As principais informações armazenadas localmente incluem:

- **Usuários:** dados de cadastro, login e perfil
- **Postagens:** resumos, materiais e comentários
- **Perfis:** informações adicionais de cada estudante (nome, biografia, foto)
- **Materiais:** arquivos e conteúdos vinculados às áreas de estudo

### ⚙️ Configuração

1. Instalação do pacote SQLite3:
   ```bash
   npm install sqlite3
   ```
2. Criação do arquivo server.js para inicializar o banco:
```javascript
// Importando os módulos necessários:

const express = require(\'express\');
const sqlite3 = require(\'sqlite3\').verbose();
...

// Cria a aplicação Express e define porta de conexão:

const app = express();
const PORT = 3001;
...

// Cria a tabela \


"users" caso ainda não exista:

const db = new sqlite3.Database(\'./users.db\', (err) => {
  if (err) {
    console.error(\'Erro ao abrir o banco de dados:\', err.message);
  } else {
    console.log(\'Conectado ao banco de dados SQLite.\');
    db.run(`CREATE TABLE IF NOT EXISTS users (
      id INTEGER PRIMARY KEY AUTOINCREMENT,
      nome TEXT NOT NULL,
      email TEXT UNIQUE NOT NULL,
      senha TEXT NOT NULL,
      profilePicturePath TEXT,
      bio TEXT 
    )`, (err) => {
      if (err) {
        console.error(\'Erro ao criar a tabela de usuários:\', err.message);
      }
    });

...
```

---

## 💻 Desenvolvimento Front-end

O front-end do **VestLink** foi desenvolvido utilizando **React**, com estilização via **Bootstrap/React-Bootstrap** e CSS customizado.
---
---
### ⚛️ React

- React é uma **biblioteca JavaScript** para criar interfaces de usuário de forma **reativa e componentizada**.
- Cada parte da página (botões, formulários, cards de post, navbar) é construída como um **componente reutilizável**.
- Exemplo de criação de componente:

```javascript
function CardPost({ title, description }) {
  return (
    <div className="card p-3 m-2">
      <h3>{title}</h3>
      <p>{description}</p>
    </div>
  );
}
```
...
---
### 🟦 Bootstrap / React-Bootstrap

- **Bootstrap** é um framework CSS que fornece **estilos prontos e componentes responsivos**, como grids, botões, formulários, cards e navbar.
- **React-Bootstrap** adapta esses componentes para serem usados **como componentes React**, mantendo a reatividade da aplicação.
- Benefícios:
  - Layout responsivo automaticamente (desktop, tablet, mobile)
  - Componentes prontos que aceleram o desenvolvimento
  - Integração fácil com React

**Exemplo de Card com React-Bootstrap:**
```jsx
import Card from \'react-bootstrap/Card\';

function CardPost({ title, description }) {
  return (
    <Card className="mb-3 shadow-sm">
      <Card.Body>
        <Card.Title>{title}</Card.Title>
        <Card.Text>{description}</Card.Text>
      </Card.Body>
    </Card>
  );
}
```

---

## ⚙️ Desenvolvimento Back-end

O back-end do **VestLink** foi desenvolvido com **Node.js** e **Express**, oferecendo uma API REST que se comunica com o banco de dados **SQLite** no ambiente local.

---

### 🟢 Tecnologias e Funções

- **Node.js**: ambiente de execução JavaScript no servidor
- **Express**: framework para criar rotas e APIs de forma rápida e organizada
- **SQLite**: banco de dados local para armazenamento de usuários, posts, favoritos e avaliações
- **Multer**: middleware para upload de arquivos (materiais, imagens de capa e foto de perfil)
- **CORS**: permite que o front-end acesse o back-end mesmo estando em portas diferentes
---
### 🔄 Funcionalidades do Back-end

1. **Cadastro e login de usuários**
   - Senhas armazenadas de forma segura usando `bcrypt`
   - Validação de campos obrigatórios e verificação de email único

2. **Gestão de posts**
   - Criação, listagem e exclusão de posts
   - Upload de arquivos e imagens (materiais de estudo e capa)

3. **Favoritos e avaliações**
   - Usuários podem favoritar/desfavoritar posts
   - Avaliações positivas ou negativas em cada post

4. **Perfis de usuário**
   - Visualização e atualização de biografia
   - Upload de foto de perfil

5. **Serviço de arquivos estáticos**
   - Arquivos enviados são armazenados em `uploads/`
   - Podem ser acessados via URL, ex.: `http://localhost:3001/uploads/nome-do-arquivo`
---
### 📂 Estrutura do Back-end

- `server.js` → arquivo principal do servidor Express
- `uploads/` → pasta onde arquivos enviados são salvos
- `users.db` → banco de dados SQLite local
- Possíveis futuras pastas para melhor organização:
  - `routes/` → rotas separadas por recurso (users, posts)
  - `controllers/` → funções que implementam a lógica de cada rota
  - `database/` → inicialização e configuração do SQLite

---
### 🔄 Fluxo de Comunicação

1. **Front-end React** envia requisições HTTP (GET, POST, PUT, DELETE) para o **Express**
2. **Express** processa a requisição, executa queries no **SQLite** e retorna dados em JSON
3. **Front-end** consome a resposta e atualiza a interface do usuário
---
### ⚡ Exemplos de Rotas

- `POST /register` → cadastrar usuário
- `POST /login` → autenticar usuário
- `POST /posts` → criar um novo post
... 

---

## 📊 Resultados Obtidos

Aqui estão algumas telas do projeto **VestLink**:

**Tela de Login**
![Tela de Login](./demo/imagens/tela_login.png)

**Feed de Postagens**
![Feed de Postagens](./demo/imagens/tela_post.png)

**Perfil do Usuário**
![Página de Perfil](./demo/imagens/tela_perfil.png)

**Para assistir uma demonstração do sistema, clique no link:**
[Demonstração - VestLink](https://drive.google.com/file/d/1dILKk8BLbPsa_TGaGSdYresE0osS31Ms/view?usp=sharing)

---

## 🙏 Agradecimentos

Gostaria de agradecer aos meus colegas que contribuíram para este projeto!  
Seus esforços, ideias e dedicação tornaram este projeto possível.  

### Contribuidores
- [Vitor Henrique](https://github.com/Vhcmorais)  
- [Adilson José](https://github.com/OutroContribuidor)  
- [Bianca Marques](https://github.com/MaisUm)
- [Gabriel Alves](https://github.com/gabriel-a-f)

<div align="center">
  <img src="./demo/imagens/foto_readme.jpg" width="300" />
</div>
