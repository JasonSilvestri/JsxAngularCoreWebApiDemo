# Official jSX Angular Asp.NET Core Web API Demo Project
### jSilvestri.com BETA v 2025 Web API Demo Collection
### Phase 1

The `JsxAngularCoreWebApiDemo` application (i.e., _jSilvestri.com BETA v 2025 JSX Angular Asp.NET Core Web API Demo_) in specific, is a FREE, open-source, custom, reusable, jSilvestri.com 2025 Web API Demo Collections ASP.NET Core Project, which accesses the `JsxWebApi` Web API, demonstrating the usage of Web APIs, JWT authentication, client-side and server-side frameworks for user authentication, using Blazor Technologies. This project ensures consistency and simplifies the management of these resources.

 **⚠ Important:** 
  This application is still In-Work and currently in Phase 1 of Development (e.g., _Basic MVP example_). Conversely, Phase 2 and beyond will have most (if not all) functionality fully integrated. Stay tuned!

## Overview

The [jSilvestri.com BETA v 2025](https://www.jsilvestri.com/) mobile and web applications, developed for most smart phones, tablets and desktop computers, were created to showcase a wide range of skills to potential clients and employers, to support existing clients, while providing helpful information to fellow developers, demos for interview talks, access to resumes, etc.

The `JsxAngularCoreWebApiDemo` application (i.e., _jSilvestri.com BETA v 2025 JSX Angular Asp.NET Core Web API Demo_) in specific, is a FREE, open-source, custom, reusable, jSilvestri.com 2025 Web API Demo Collections ASP.NET Core Project, which accesses the `JsxWebApi` Web API, demonstrating the usage of Web APIs, JWT authentication, client-side and server-side frameworks for user authentication, using Blazor Technologies. This project ensures consistency and simplifies the management of these resources.

## VS Project & Solution Structure

**The solution includes the following projects:**

- **[Official jSilvestri 2025 Web API Demo Collection Project](https://github.com/JasonSilvestri/jSilvestri2024WebApiDemoCollection)**: The main `jSilvestri2024WebApiDemoCollection` solution. This soluton includes all projects described below, but doesn't have any major function outside having a place where all projects can be consumed at once. In fact, all projects below were also designed to have their own, independent repositories, which can be downloaded and/or run alone (respectfully).

**The Shared Projects:**

The following Projects are used to share common resources and information across all other projects.

1. **[Jsx Web API Project](https://github.com/JasonSilvestri/JsxWebApi)**: The `JsxWebAPI` Project, is an ASP.NET Core Web API project with JWT authentication and generic CRUD operations.
2. **[Jsx Class Library Project](https://github.com/JasonSilvestri/JsxClassLibrary)**: The `JsxClassLibrary` class library, is a shared library, containing constants, DTOs, and helper classes. 
3. **[Jsx Shared Resources Project](https://github.com/JasonSilvestri/JsxSharedResources)**: The `JsxSharedResources` shared recources library, containing common HTML, CSS, JS, Images and other reuseable theming objects.

**The Web API Demo Projects:**

The following Projects are different front-end technologies, such as Angular, Angular & Vue, and backed by Asp.NET Core back-end (for security purposes). Nonetheless, these different Web API Demos & technology access the same primary Web API for CRUD operations. I consider myself still in Discovery with the latest versions of these technologies, but that is all part of the game.

- **[Jsx Angular & Asp.NET Core Web API Demo Project](https://github.com/JasonSilvestri/JsxAngularCoreWebApiDemo)**:
  - **JsxAngularCoreWebApiDemo.Server**: The server-side .NET Core Web API project.
  - **jsxangularcorewebapidemo.client**: The client-side Angular project.
- **[Jsx Angular & Asp.NET Core Web API Demo Project](https://github.com/JasonSilvestri/JsxAngularCoreWebApiDemo)**:
  - **JsxAngularCoreWebApiDemo.Server**: The server-side .NET Core Web API project.
  - **jsxAngularcorewebapidemo.client**: The client-side Angular project.
- **[Jsx Vue & Asp.NET Core Web API Demo Project](https://github.com/JasonSilvestri/JsxVueCoreWebApiDemo)**:
  - **JsxVueCoreWebApiDemo.Server**: The server-side .NET Core Web API project.
  - **jsxvuecorewebapidemo.client**: The client-side Vue project.
- **[Jsx Blazor Asp.NET Core Web API Demo Project](https://github.com/JasonSilvestri/JsxBlazorServerCoreWebApiDemo)**: The Blazor Server project.

## Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Visual Studio or Visual Studio Code 2022 or higher](https://visualstudio.microsoft.com/)
- [Visit jSilvestri.com BETA v 2025 Demos for More Details](https://jsilvestri.com/home/demo)
  
### Corequisites

- Install Node.js, npm and/or ng (for Angular, Angular, and Vue projects)
- Swagger (used to automatically manufacture docs on Web API endpoints)
  

### Installation

1. **Clone the repository**:

    ```bash
    git clone https://github.com/JasonSilvestri/JsxAngularCoreWebApiDemo.git
    ```

2. **Open the solution in Visual Studio**:

    - Open `JsxAngularCoreWebApiDemo.sln` in Visual Studio.

3. **Restore NuGet packages**:

    - Right-click on the solution in Solution Explorer and select `Restore NuGet Packages`.

4. **Build the solution**:

    - Right-click on the solution in Solution Explorer and select `Build Solution`.

## Using JsxSharedResources Project in jSilvestri.com BETA v 2025 Web API Demo Collection Projects

### Reference the Shared Resources Project

1. **Add a project reference** to `JsxSharedResources` in each client project:
    - Right-click on the client project (e.g., `JsxAngularCoreWebApiDemo`, `JsxAngularCoreWebApiDemo`, `JsxVueCoreWebApiDemo`, `JsxBlazorServerCoreWebApiDemo`).
    - Select **Add** > **Project Reference**.
    - Check `JsxSharedResources` and click **OK**.

### Example: jSilvestri.com 2025 Blazor Server Asp.NET Core Web API Demo Project

**In `JsxBlazorServerCoreWebApiDemo`**:

1. **Reference the Shared Resources Project**:
    - Add a reference to `JsxSharedResources` in `JsxBlazorServerCoreWebApiDemo`.

2. **Use Static Files in Razor Components**:
    - Create a Razor component that uses the shared static files.

    ```razor
    @page "/example"
    @inject IWebHostEnvironment env

    <h3>Example Page</h3>

    <img src="@($"{env.WebRootPath}/images/logo.png")" alt="Logo">
    <script src="@($"{env.WebRootPath}/JavaScript/script.js")"></script>
    <link rel="stylesheet" href="@($"{env.WebRootPath}/CSS/style.css")">
    ```

### Example: jSilvestri.com 2025 Angular Asp.NET Core Web API Demo Project

**In `JsxAngularCoreWebApiDemo`**:

1. **Copy Files Using a Build Script**:
    - Create a script to copy the shared resources from `JsxSharedResources` to the `assets` folder of the Angular project during the build process.

    ```json
   
    "scripts": {
        "postinstall": "npm run copy-shared-resources",
        "copy-shared-resources": "cp -r ../JsxSharedResources/* ./src/assets/"
    }
    ```

2. **Use Static Files in Angular Components**:
    - Reference the static files in your Angular components.

    ```html
    <!-- app.component.html -->
    <img src="assets/images/logo.png" alt="Logo">
    <script src="assets/JavaScript/script.js"></script>
    <link rel="stylesheet" href="assets/CSS/style.css">
    ```

### Example:  jSilvestri.com 2025 Vue Asp.NET Core Web API Demo Project

**In `JsxVueCoreWebApiDemo`**:

1. **Copy Files Using a Build Script**:
    - Create a script to copy the shared resources from `JsxSharedResources` to the `assets` folder of the Vue project during the build process.

    ```json
    
    "scripts": {
        "postinstall": "npm run copy-shared-resources",
        "copy-shared-resources": "cp -r ../JsxSharedResources/* ./public/assets/"
    }
    ```

2. **Use Static Files in Vue Components**:
    - Reference the static files in your Vue components.

    ```html
    <!-- App.vue -->
    <template>
        <div>
            <img src="assets/images/logo.png" alt="Logo">
            <script src="assets/JavaScript/script.js"></script>
            <link rel="stylesheet" href="assets/CSS/style.css">
        </div>
    </template>
    ```

### Example: jSilvestri.com 2025 Angular Asp.NET Core Web API Demo Project

**In `JsxAngularCoreWebApiDemo`**:

1. **Copy Files Using a Build Script**:
    - Create a script to copy the shared resources from `JsxSharedResources` to the `public` folder of the Angular project during the build process.

    ```json
    
    "scripts": {
        "postinstall": "npm run copy-shared-resources",
        "copy-shared-resources": "cp -r ../JsxSharedResources/* ./public/assets/"
    }
    ```

2. **Use Static Files in Angular Components**:
    - Reference the static files in your Angular components.

    ```javascript
    // App.js
    import Angular from 'Angular';

    function App() {
        return (
            <div>
                <img src="assets/images/logo.png" alt="Logo" />
                <script src="assets/JavaScript/script.js"></script>
                <link rel="stylesheet" href="assets/CSS/style.css" />
            </div>
        );
    }

    export default App;
    ```

### Conclusion

This area of the guide provides a basic overview of setting up the `JsxSharedResources` project to manage shared static resources and using these resources in various client projects (`JsxAngularCoreWebApiDemo`, `JsxAngularCoreWebApiDemo`, `JsxVueCoreWebApiDemo`, and `JsxAngularCoreWebApiDemo`). Follow the instructions to ensure your projects can consistently and efficiently utilize shared resources.

## Planned Evolution of jSilvestri.com BETA v2025 Web API Demo Collection Projects

Depending on when you visit this demo application, it may look very different from your previous visit. I am not talking about common checkins to improve the applications. I am talking about noticable, planned, development that will shape each application in accordance to the grand design. In other words, the variability is intentional. 

The purpose of this project, and its associated projects, is to showcase my basic skills in the technologies I am currently exploring in 2025 (e.g., technologies I consider still in Discovery). By leveraging my 20 years of experience in full stack .NET development and solution architecting, I also aim to address areas often overlooked in typical online examples, such as security, object-oriented coding, and the transformation of existing assets, templates, and projects into custom creative designs that support specific objectives.

The target technologies and project structures include **AngularJS**, **Vue**, **AngularJS**, and **Blazor**, all of which access the same Web API project using ASP.NET Core 8 and Visual Studio 2022 or Visual Studio Code (or higher).

### Source Control Strategies

There are typically two primary ways to handle source control for multiple projects:

1. **Monorepo**: Storing all projects within a single GitHub repository. This approach simplifies managing dependencies and integrations between projects and ensures consistency across the solution.
2. **Multi-repo**: Creating separate GitHub repositories for each project. This approach provides greater modularity and allows each project to evolve independently, which can be beneficial if projects have different development cycles or teams.

We will use a **combination of both** approaches. This hybrid method allows potential clients, employers, and fellow developers to download and run the applications they are most interested in as standalone projects (i.e., _AngularJS_, _Vue_, _AngularJS_, or _Blazor_), all accessing the same Web API project using ASP.NET Core 8 and Visual Studio 2022 (_or higher_), each with their own project and solution. Additionally, this approach ensures we can also create a project and solution that includes all applications, facilitating easy transitions between tiers for various needs (i.e., the _jSilvestri.com BETA v 2025 Web API Demo Collection Project_).


### Project Development Steps - Phase 1 (Current Phase):

While this workflow may change, the steps I am taking to conclude all aspects of this phase of the project development are as follows:

1. **Add a Class Library**: Add a new ASP.NET Core Class Library project and solution. This project will serve as the common place where we share the most common class and interface parts we want to use across all applications, such as Constants, Enums, Helpers, etc.
   
2. **Add a Web API Project**: Add a new ASP.NET Core Web API project and solution. This project will serve as the backend API that the frontend projects will communicate with.

3. **Add a Shared Resources Project**: Add a new ASP.NET Core project and solution that will handle common, static, assets and resources, shared across all applications. This project will serve as the resource project with all HTML, CSS, JS, Images and other creative all projects will use to carry the same theme, look and feel across applications. For now, all projects will use the basic, out-of-the-box vanilla assets.

4. **Add Frontend & Backend Web API Demo Projects**:
   - Add separate projects and solutions for AngularJS, Vue, AngularJS, and Blazor. We will initially choose the appropriate project templates provided by Visual Studio.
   - For AngularJS, Vue, and AngularJS, we will consider creating separate ASP.NET Core Web Application projects and choosing the respective frontend frameworks (i.e., _Angular_, _Vue.js_, _Angular.js_) during project creation.
   - For Blazor, we will create a Blazor WebAssembly or Angular project, depending on time. If I have bandwidth, I may also create a MAUI Hybrid Project, which is relatively new to the scene.

5. **Add Common Projects to Frontend & Backend Web API Demo Projects**:
   - Each frontend and backend project (_AngularJS_, _Vue_, _AngularJS_, _Blazor_, etc.) will make HTTP requests to the Web API project to fetch data or perform data operations, will use the Class Library containing constants, DTOs, and helper classes to perform other common operations, and will use the Shared Resources Library to share common themes, such as common CSS, JS, HTML. etc...).
   - Each frontend and backend project (_AngularJS_, _Vue_, _AngularJS_, _Blazor_, etc.) will use the Class Library containing constants, DTOs, and helper classes to perform other common operations. 
   - Each frontend and backend project (_AngularJS_, _Vue_, _AngularJS_, _Blazor_, etc.) will use the Shared Resources Library to share common themes, such as common CSS, JS, HTML. etc...).
   **These projects will be added to each project in Phase 1, but configured for full use in later phases. **

6. **Testing and Debugging**:
   - Test the communication between the frontend projects and the Web API project.
   - Debug any issues that arise during development.

7. **Deployment**:
    - Deploy the Web API project and frontend projects to the desired hosting environment. Ensure that all projects are configured correctly for production.

### Project Development Steps - Phase 2:

While this workflow may change, the steps I am taking to conclude all aspects of the project development are as follows:

1. **Add All Frontend Projects, Assets Projects & Web API to jSilvestri.com BETA v2025 Web API Demo Collection Solutions**:
   - Clone all projects and add them to the jSilvestri.com BETA v2025 Web API Demo Collection project for full access and testing of all projects in one, unified, location.

2. **Update Class Library**: Update ASP.NET Core Class Library project and solution parts we want to use across all applications, such as Constants, Enums, Helpers, etc.
   
3. **Update Web API Project**: Update ASP.NET Core Web API project and solution. This project will serve as the backend API that the frontend projects will communicate with.

4. **Update Shared Assets Project**: Update new ASP.NET Core project and solution that will handle common, static, assets and resources, shared across all applications. This project will serve as the resource project with all HTML, CSS, JS, Images and other creative all projects will use to carry the same theme, look and feel across applications.

5. **Setup Communication**:
   - Each frontend and backend project (_AngularJS_, _Vue_, _AngularJS_, _Blazor_, etc.) will make HTTP requests to the Web API project to fetch data or perform operations. For the first iteration of data, we will use some static weather data. 

6. **Configure Routes**:
   - We will define appropriate routes in our Web API project to handle incoming requests from the frontend projects.
   - We will implement controllers and actions to handle these routes and interact with our data layer.

7. **Web API Shared Models and Services**:
   - We will consider creating shared models and services that can be used across both the Web API project and the frontend projects. This will help in maintaining consistency and reducing duplication of code.

8. **Authentication and Authorization (Optional)**:
   - Implement authentication and authorization mechanisms in Web API project if required (final version should).

9. **Testing and Debugging**:
   - Test the communication between the frontend projects and the Web API project.
   - Debug any issues that arise during development.

10. **Deployment**:
    - Deploy the Web API project and frontend projects to the desired hosting environment. Ensure that all projects are configured correctly for production.

11. **Continuous Integration and Continuous Deployment (CI/CD)**:
    - Set up CI/CD pipelines to automate the build and deployment process for your solution.


### Project Development Steps - Phase 3:

While this workflow may change, the steps I am taking to conclude all aspects of the project development are as follows:

1. **Update Class Library**: Update ASP.NET Core Class Library project and solution parts we want to use across all applications, such as Constants, Enums, Helpers, etc.
   
2. **Update Web API Project**: Update ASP.NET Core Web API project and solution. This project will serve as the backend API that the frontend projects will communicate with.

3. **Update Final Shared Resources Project**: Update new ASP.NET Core project and solution that will handle common, static, assets and resources, shared across all applications. This project will serve as the resource project with all HTML, CSS, JS, Images and other creative all projects will use to carry the same theme, look and feel across applications.

4. **Setup Communication**:
   - Each frontend project (_AngularJS_, _Vue_, _AngularJS_, _Blazor_, etc.) will make HTTP requests to the Web API project to fetch data or perform operations. The final version will access real-time weather data from one or more weather APIs available today.
   - Ensure that CORS (_Cross-Origin Resource Sharing_) is properly configured in the Web API project to allow requests from the frontend projects.

5. **Configure Routes**:
   - We will define appropriate routes in our Web API project to handle incoming requests from the frontend projects.
   - We will implement controllers and actions to handle these routes and interact with our data layer.

6. **Shared Models and Services**:
   - We will consider creating shared models and services in their own project, as opposed to housing them in the Web API project that can be used across both the Web API project and the frontend projects. This will help in maintaining consistency and reducing duplication of code.
   - An eventual version of this approach will leverage a structure where we have specific repositories for each service along with a generic repository to handle common CRUD operations, following a design pattern like the Repository Pattern.

7. **Authentication and Authorization (Optional)**:
   - We will use JWT (_JSON Web Tokens_) for authentication and role-based authorization.

8. **Testing and Debugging**:
   - Test the communication between the frontend projects and the Web API project.
   - Debug any issues that arise during development.

9. **Deployment**:
    - Deploy the Web API project and frontend projects to the desired hosting environment. Ensure that all projects are configured correctly for production.

10. **Continuous Integration and Continuous Deployment (CI/CD)**:
    - Set up CI/CD pipelines to automate the build and deployment process for your solution.


### Project Development Steps - Phase 4:

While this workflow may change, the steps I am taking to conclude all aspects of the project development are as follows:

1. **Update Final Class Library**: Update Final ASP.NET Core Class Library project and solution parts we want to use across all applications, such as Constants, Enums, Helpers, etc.
   
2. **Update Final Web API Project**: Update ASP.NET Core Web API project and solution. This project will serve as the backend API that the frontend projects will communicate with.

3. **Update Final Shared Resources Project**: Update new ASP.NET Core project and solution that will handle common, static, assets and resources, shared across all applications. This project will serve as the resource project with all HTML, CSS, JS, Images and other creative all projects will use to carry the same theme, look and feel across applications.

4. **Implement Final Security Protocols**:
   - Each frontend project (_AngularJS_, _Vue_, _AngularJS_, _Blazor_, etc.) will need several security protocols implemented before final release. 
   -- Add custom validation client-side logic
   -- Add custom validation side-side logic
   -- Add custom validators to models
   -- Secure binding objects
   -- Update any shared objects of a sensitive nature to utilized sealed and internal objects over public defaults.
   
5. **Configure Routes**:
   - We will define appropriate routes in our Web API project to handle incoming requests from the frontend projects.
   - We will implement controllers and actions to handle these routes and interact with our data layer.

6. **Shared Models and Services**:
   - We will consider creating shared models and services in their own project, as opposed to housing them in the Web API project that can be used across both the Web API project and the frontend projects. This will help in maintaining consistency and reducing duplication of code.
   - An eventual version of this approach will leverage a structure where we have specific repositories for each service along with a generic repository to handle common CRUD operations, following a design pattern like the Repository Pattern.

7. **Authentication and Authorization (Optional)**:
   - We will use JWT (_JSON Web Tokens_) for authentication and role-based authorization.

8. **Testing and Debugging**:
   - Test the communication between the frontend projects and the Web API project.
   - Debug any issues that arise during development.

9. **Deployment**:
    - Deploy the Web API project and frontend projects to the desired hosting environment. Ensure that all projects are configured correctly for production.

10. **Continuous Integration and Continuous Deployment (CI/CD)**:
    - Set up CI/CD pipelines to automate the build and deployment process for your solution.



**Copyright © 2024 - All Rights Reserved by Jason Silvestri**
