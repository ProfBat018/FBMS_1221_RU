# Azure Cosmos DB for NoSQL Tutorial - ASP.NET project template

Sample ASP.NET web application to use with API for NoSQL. This sample is used in the [API for NOSQL web application tutorial](https://learn.microsoft.com/azure/cosmos-db/nosql/tutorial-dotnet-web-app). This sample is built using [.NET 6 (LTS)](https://learn.microsoft.com/dotnet/core/whats-new/dotnet-6).

## Features

This project framework provides the following features:

* ASP.NET Razor Pages
* Dependency injection of a singleton CosmosClient (per [best practices](https://learn.microsoft.com/azure/cosmos-db/nosql/best-practice-dotnet)).
* CDN-based [Bootstrap 5.2](https://getbootstrap.com/docs/5.2/), [Bootstrap Icons 1.9](https://icons.getbootstrap.com/), and [Masonry 4.2](https://masonry.desandro.com/).
* Sample data from [azurecosmosdb/cosmicworks](https://github.com/azurecosmosdb/cosmicworks). on GitHub

## Getting Started

### Prerequisites

(ideally very short, if any)

- .NET 6 or later
- Shell (Bash/PowerShell)

### Installation

- Install the [CosmicWorks.Template.Web package](https://www.nuget.org/packages/CosmicWorks.Template.Web) from NuGet:

    ```
    dotnet install CosmicWorks.Template.Web
    ```

- In an empty directory, create a new ASP.NET web application project using the project template:

    ```
    dotnet new cosmosdbnosql-webapp
    ```

    > **🗈 Note**: The name of the project will be the same as the empty folder's name. To influence this, use the `--name` and `-output` options.

### Quickstart

1. Build the project:

    ```
    dotnet build
    ```

1. Optionally, open the project in [Visual Studio Code](https://code.visualstudio.com/).

    ```
    code .
    ```

1. Run the project leaving the option to refresh on code changes:

    ```
    dotnet watch
    ```

    > **🗈 Note**: Under normal circumstances, the web application should be hosted at port **5000** and the URL `http://localhost:5000`.

1. Open a web browser and navigate to the running web application.

## Resources

- Want to update this template to use Azure Cosmos DB for NoSQL? See the [corresponding tutorial](https://learn.microsoft.com/azure/cosmos-db/nosql/tutorial-dotnet-web-app).
- Want to learn more about NoSQL in Azure Cosmos DB? Check out our [documentation](https://learn.microsoft.com/azure/cosmos-db/nosql/).
