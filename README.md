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

## How to Install and Use

Since this is a custom Visual Studio template repository, you can generate and install it into your local environment in just a few quick steps:

### 1. Clone this Repository
Clone this repository to your local machine and open the `.slnx` (or `.sln`) file in **Visual Studio**.

### 2. Export the Template
1. In the top menu bar, click on **Project** > **Export Template...**.
2. Leave **Project template** selected and choose your project from the dropdown, then click **Next**.
3. (Optional) Customize your template name, icon, or description, and ensure the checkbox for **"Automatically import the template into Visual Studio"** is checked.
4. Click **Finish**. Visual Studio will automatically build the `.zip` file and drop it straight into your local user templates folder for you!

### 3. Create Your New Project
1. Restart or open a new instance of **Visual Studio**.
2. Click **Create a new project**.
3. Search for `vs-minimal-api-template` (or the custom name you gave it).
4. Name your new API, hit **Create**, and start coding!

---

## License
This project is licensed under the MIT License - feel free to use it for personal or commercial projects!
