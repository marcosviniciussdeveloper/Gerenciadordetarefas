# Tutorial de Execução do Gerenciador de Tarefas

Bem-vindo ao tutorial de execução do **Gerenciador de Tarefas**, um projeto em console desenvolvido com C# e .NET 8.0.403.

---

## Pré-requisitos

Certifique-se de que você tem os seguintes itens configurados antes de executar o projeto:

1. **SDK .NET 8.0.403** instalado.  
   - Faça o download do SDK no site oficial da Microsoft: [Download do .NET](https://dotnet.microsoft.com/).
   - Para verificar se está instalado corretamente, execute:
     ```bash
     dotnet --version
     ```
     Esse comando deve retornar `8.0.403`.

2. **Git** para clonar o repositório.  
   - Baixe e instale pelo [site oficial do Git](https://git-scm.com/).

3. Um editor de texto ou IDE. Recomenda-se o **Visual Studio Code** ou **Visual Studio 2022**.

---

## Como Executar

Siga os passos abaixo para executar o projeto no seu ambiente local:

1. **Clone o repositório do projeto:**
   ```bash
   git clone [https://github.com/marcosviniciussdeveloper/Gerenciadordetarefas.git]

2. Acesse o projeto 
    cd GerenciadorDeTarefas

3. Restaure as dependecias 
    dotnet restore

4. Compile o projeto (Opcional)
    dotnet build 

5. Execute o programa 
    dotnet run 

## Intereja com o programa 

Em casos de erros : 
 
 1. Verifique se a versão do .NET é a mesma na qual o programa foi desenvolvido. 
    (global.json) Altera a versão do .NET

 2. Verifique se as dependencias foram restauradas 
    dotnet restore