"# Como Executar o Projeto" 

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

2. Acesse o diretório do projeto:
    cd  Gerenciadordetarefas

3. Restaure as depedencias do projeto

    dotnet restore 

4. Compilação (Opcional)
    dotnet build

5. Excute o programa 
    dotnet run 

6. Após a execução projeto será executado no terminal e você já pode interagir com ele.


## Caso haja Erros 

1. Verifique a Versão do .NET instalada se corresponde com a que foi criada o programa , altere a vesão utilizando : 
    global.json 

2. Depedencias não restauradas 
    dotnet restore