# Consulta de CEP com Blazor WebAssembly

Aplicação desenvolvida em **C# e Blazor WebAssembly** para consultar endereços por CEP utilizando a **BrasilAPI**.

## Funcionalidades

- Consulta de CEPs brasileiros com oito dígitos (com ou sem hífen).
- Exibição de CEP, logradouro, bairro, cidade, estado e serviço utilizado.
- Exibição dos códigos de cidade e estado do IBGE, quando disponíveis.
- Validação do CEP e mensagens em caso de endereço não encontrado ou falha na consulta.

## Tecnologias

- .NET 10
- C#
- Blazor WebAssembly
- Bootstrap 5
- BrasilAPI

## Como executar

É necessário ter o **SDK do .NET 10** instalado. No terminal, dentro da pasta do projeto, execute:

    dotnet restore
    dotnet run

Em seguida, abra o endereço informado no terminal (normalmente `http://localhost:5062`).

## Estrutura principal

- `Models/Cep.cs` e `Models/Ibge.cs`: representam os dados retornados pela BrasilAPI.
- `Pages/Home.razor`: formulário de consulta e resultado do CEP.
- `Program.cs`: registra o `HttpClient` apontando para a BrasilAPI.
- `Layout/`: estrutura visual e menu de navegação.

## API

Endpoint utilizado: `GET https://brasilapi.com.br/api/cep/v1/{cep}`

Documentação: https://brasilapi.com.br/docs#tag/CEP

Projeto baseado na atividade prática de consumo de APIs com Blazor WebAssembly.
