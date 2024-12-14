# Gerenciador de Tarefas - Desenvolvimento

Este é o branch de desenvolvimento do **Gerenciador de Tarefas**. Aqui, são realizadas as implementações mais recentes e os testes das novas funcionalidades. O código neste branch pode não estar completamente estável.

## 🚧 Funcionalidades em Desenvolvimento

- **Novo Layout de Tarefas**: Estamos trabalhando em uma nova interface para a exibição das tarefas.
- **Notificações**: Funcionalidade de notificações para lembrar o usuário das tarefas pendentes.
- **Melhorias no Banco de Dados**: Ajustes na estrutura do banco de dados para suportar múltiplos usuários.
- **Filtro de Tarefas**: Adicionando a capacidade de filtrar tarefas por status (pendente, concluída, etc.).

## 🔧 Instalação

1. Clone o repositório:
    ```bash
    git clone https://github.com/marcosviniciussdeveloper/Gerenciadordetarefas.git
    ```

2. Mude para o branch de desenvolvimento:
    ```bash
    git checkout dev
    ```

3. Abra a solução `GerenciadorDeTarefas.sln` no Visual Studio ou outra IDE compatível.

4. Restaure os pacotes NuGet:
    ```bash
    dotnet restore
    ```

5. Compile e execute a aplicação:
    ```bash
    dotnet run
    ```

## 🛠️ Tecnologias Utilizadas

- C#
- .NET 8.0
- Entity Framework Core
- SQL Server (ou outro banco de dados configurado)
- WPF ou Console Application

## 🚀 Testes e Funcionalidades

Este branch pode conter funcionalidades em estágio de desenvolvimento ou testes. Ao testar, fique atento às novas implementações, que podem ter bugs ou instabilidade.

## 💡 Contribuindo

1. Faça um fork deste repositório.
2. Crie uma branch (`git checkout -b feature/nova-feature`).
3. Faça commit das suas mudanças (`git commit -am 'Adiciona nova feature'`).
4. Envie para o branch do seu repositório (`git push origin feature/nova-feature`).
5. Abra um pull request.

### 📢 Atenção

Este branch pode ser instável. Use-o apenas para testar as funcionalidades mais recentes. Se precisar de uma versão estável do projeto, utilize o branch `main`.

## 📝 Licença

Este projeto está sob a licença MIT. Veja o arquivo [LICENSE](LICENSE) para mais detalhes.

