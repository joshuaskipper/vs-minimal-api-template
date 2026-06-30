# Visual Studio Minimal API Template

Visual Studio project template for rapid setup and configuration for .NET Minimal APIs. Save time writing the same boilerplate code every time you start a new microservice or backend project.

---

## Features Included

* **Modern .NET Architecture:** Built using the latest lightweight .NET patterns, keeping `Program.cs` completely uncluttered.
* **📂 Enterprise-Ready Folder Layout:** A decoupled, production-ready structure that enforces clean separation of concerns:
  * `Data` - Entity Framework Core context configuration.
  * `EndPoints` - Clean mapping via `IEndpointRouteBuilder` extensions to keep route logic out of your configuration files.
  * `Models` - Separated into `Domain` entities (database-facing) and `Dtos` (data transfer objects for request/response payloads) to prevent over-posting and secure your data layer.
  * `Services` - Pre-structured for Dependency Injection with explicit `Interface` definitions and the `Repository` pattern for decoupled data access layers.
* **Entity Framework Core Integrated:** Fully configured with `AppDbContext` and local SQL Server infrastructure placeholders.
* **Modern API Documentation:** Native `.AddOpenApi()` paired with **Scalar API Reference** (`app.MapScalarApiReference()`) for a beautiful interactive API testing UI right out of the box.
* **Pre-configured** `launchSettings.json` with `launchUrl: "scalar/v1"`, launching you directly into your interactive API documentation the second the application starts.
---

## 🛠️ How to Install and Use

Since this is a custom Visual Studio template, you can add it to your local environment in just a few steps:

### 1. Download the Template
Download the `.zip` archive of this template from the [Releases](../../releases) section (or zip up the project folder yourself).

### 2. Move to Visual Studio Templates Folder
Place the `.zip` file directly into your user templates directory. Do **not** unzip it.
* **Path:** `C:\Users\<Your-Username>\Documents\Visual Studio 2022\Templates\ProjectTemplates`

### 3. Create a New Project
1. Open **Visual Studio 2022**.
2. Click **Create a new project**.
3. Search for `vs-minimal-api-template` (or whatever you named it in the metadata).
4. Name your project, hit **Create**, and start coding!

---

##  License
This project is licensed under the MIT License - feel free to use it for personal or commercial projects!
