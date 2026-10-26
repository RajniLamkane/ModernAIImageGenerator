<img width="1920" height="1020" alt="Screenshot 2026-08-12 105641" src="https://github.com/user-attachments/assets/e8aa9610-558a-4ac3-b13c-a1a738f56c91" />Modern AI Image Generator
An AI-powered image generation web application built with ASP.NET Core
MVC and the OpenAI Images API. Enter a text prompt and generate an
image from your description through a simple, responsive web interface.
Screenshots
Add your application screenshots to the docs/screenshots/ folder in
this repository, using the filenames below. The images will then appear
in this section on GitHub.
  Application home page             
  Generated image



  
If you prefer, add a third screenshot showing the prompt examples or
loading indicator.

Features
- Generate images from user-provided text prompts.
- Integrate with the OpenAI image generation API.
- Display generated images returned as Base64 image data.
- Provide predefined example prompts.
- Show a loading indicator while an image is being generated.
- Validate empty prompts and display API or application errors.
- Use dependency injection and HttpClient for API communication.
- Responsive interface styled with Bootstrap 5.
Technology Stack
- Backend: ASP.NET Core MVC, C#
- AI integration: OpenAI Images API (gpt-image-1 in the current
  implementation)
- HTTP and asynchronous programming: HttpClient, async /
  await
- Configuration: ASP.NET Core configuration and .NET User Secrets
- Frontend: HTML, CSS, JavaScript, Bootstrap 5
- Tools: Visual Studio, Git, GitHub
How It Works
1. The user enters a description in the prompt text area.
2. The MVC controller validates the prompt.
3. OpenAiImageService sends an HTTP POST request to the OpenAI Images
   API.
4. The service reads the API response and extracts the Base64 image
   data (or an image URL when provided).
5. The controller passes the result to the Razor view.
6. The view displays the generated image to the user.
Getting Started
Prerequisites
- Visual Studio with the ASP.NET and web development workload, or the
  .NET SDK compatible with the project.
- An OpenAI API key with access to the image generation model used by
  the application.
- Git (optional, for cloning the repository).
1. Clone the repository
git clone https://github.com/RajniLamkane/ModernAIImageGenerator.git
cd ModernAIImageGenerator
Open the solution in Visual Studio. Locate the project directory
containing the .csproj file and open a terminal in that directory.
2. Configure the OpenAI API key securely
Do not put your real API key in appsettings.json or commit it to
GitHub.

Initialize User Secrets from the directory containing the project
.csproj file:
dotnet user-secrets init
Store your key:
dotnet user-secrets set "OpenAI:ApiKey" "YOUR_OPENAI_API_KEY"
The application reads the value using:
_configuration["OpenAI:ApiKey"]
Keep the OpenAI:ApiKey setting in User Secrets for local development.
If you deploy the application, configure the same setting using your
hosting provider's secure environment-variable or secrets configuration.
3. Restore dependencies and run
From the project directory, run:
dotnet restore
dotnet run
Alternatively, set the MVC project as the startup project in Visual
Studio and press F5 or Ctrl+F5.

Open the local URL printed in the terminal or shown by Visual Studio.
4. Generate an image
1. Open the application.
2. Enter a descriptive prompt, such as
   A futuristic city at sunset, cinematic lighting.
3. Select Generate Image.
4. Wait for the request to finish and view the generated image.
Project Structure
The main application components include:
ModernAIImageGenerator/
│
├── Imagegenerator1/
│   ├── Controllers/
│   ├── Services/
│   ├── Views/
│   ├── Program.cs
│   └── appsettings.json
│
├── docs/
│   └── screenshots/
│
├── .gitignore
├── README.md
└── Imagegenerator1.sln
Folder and file names may differ slightly depending on the final
project structure.

Security Notes
- Never commit API keys, passwords, or other secrets.
- Use .NET User Secrets for local development.
- Use your deployment platform's secret manager or environment
  variables in production.
- If an API key was ever committed or exposed, revoke it and create a
  replacement. Removing it from the latest file alone does not remove
  it from earlier Git history.
Learning Outcomes
This project provided practical experience with:
- Consuming a third-party REST API from ASP.NET Core.
- Registering and injecting a typed HttpClient.
- Writing asynchronous service methods with async and await.
- Reading JSON responses with System.Text.Json.
- Handling HTTP errors and displaying useful messages.
- Returning and displaying Base64-encoded image data in a Razor view.
- Managing application secrets securely.
Future Improvements
- Add image history and prompt management.
- Allow users to download generated images.
- Add configurable image sizes and generation options supported by the
  API.
- Add authentication and per-user generation history.
- Add automated tests for the controller and image service.
Author
Rajni Lamkane
- GitHub: RajniLamkane
If you find this project useful, feel free to explore the repository and
share your feedback.
