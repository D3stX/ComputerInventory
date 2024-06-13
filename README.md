# Descrição

Este projeto é um script em C# que realiza o inventário de hardware e software de um computador com sistema operacional Windows. O script apresenta um menu com três opções:

- Inventário de Hardware
- Inventário de Software
- Inventário de Hardware e Software

O inventário é salvo em arquivos de texto com extensão .dat e pode ser executado no PowerShell.

# Estrutura do Projeto
    ComputerInventory
        Program.cs: Arquivo principal contendo o código do script.
        ComputerInventory.csproj: Arquivo de configuração do projeto.
        bin/: Diretório onde o executável gerado será salvo.
        obj/: Diretório de arquivos temporários de build.

## Como Compilar e Executar
    Pré-requisitos
    .NET SDK: Certifique-se de ter o .NET SDK instalado. Você pode baixá-lo em dotnet.microsoft.com.

# Passos para Compilar e Executar

## 1.Clonar o Repositório ou Criar o Projeto

Se você está começando do zero, pode criar um novo projeto usando o comando:

```bash
dotnet new console -n ComputerInventory
```

Caso contrário, clone o repositório existente (substitua REPO_URL pela URL do seu repositório):

```bash
git clone REPO_URL
cd ComputerInventory
```

## 2.Adicionar o Código

Abra o arquivo Program.cs e adicione o código fornecido.

## 3.Buildar o Projeto

Navegue até o diretório do projeto e execute:

```bash
dotnet build
```

## 4.Executar o Executável no PowerShell

Navegue até o diretório onde o executável foi gerado:

```bash
cd bin/Debug/net6.0
```

Execute o executável no PowerShell:

```bash
.\ComputerInventory.exe
```

## 5.Escolher uma Opção do Menu

Quando o programa estiver em execução, será apresentado um menu com três opções. Digite o número correspondente à opção desejada (1, 2 ou 3) e pressione Enter. O inventário será gerado e salvo em arquivos .dat no diretório de execução do programa.

# Exemplo de Uso
## Inventário de Hardware
Escolha a opção 1 no menu. O inventário de hardware será salvo no arquivo hardware_inventory.dat.

## Inventário de Software
Escolha a opção 2 no menu. O inventário de software será salvo no arquivo software_inventory.dat.

## Inventário de Hardware e Software
Escolha a opção 3 no menu. O inventário de hardware será salvo no arquivo hardware_inventory.dat e o inventário de software será salvo no arquivo software_inventory.dat.

# Compactar o Projeto
Para enviar o projeto, você pode compactá-lo em um arquivo ZIP:

```bash
cd ..
```

Compacte o diretório:
```bash
Compress-Archive -Path ComputerInventory -DestinationPath ComputerInventory.zip
```

# Observações
 - Certifique-se de ter permissões administrativas para executar determinados comandos no PowerShell, caso necessário.
 - Se o comando Get-InstalledSoftware não funcionar, você pode precisar de um script PowerShell personalizado para listar os softwares instalados.
 - Ajuste os comandos e os caminhos conforme necessário para o seu ambiente de desenvolvimento.
