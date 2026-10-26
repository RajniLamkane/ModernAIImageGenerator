
<div align="center">

# ✨ Modern AI Image Generator

### 🎨 Turn Your Imagination into Reality with AI!

🚀 An AI-powered image generation web application built using **ASP.NET Core MVC, C# and OpenAI Images API**.

💡 Describe your imagination in words and let AI transform your ideas into stunning visuals!

![ASP.NET Core](https://img.shields.io/badge/ASP.NET_Core-MVC-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![C#](https://img.shields.io/badge/C%23-Development-239120?style=for-the-badge&logo=csharp&logoColor=white)
![OpenAI](https://img.shields.io/badge/OpenAI-Images_API-412991?style=for-the-badge&logo=openai&logoColor=white)
![Bootstrap](https://img.shields.io/badge/Bootstrap-5-7952B3?style=for-the-badge&logo=bootstrap&logoColor=white)

</div>

---

## 🌟 About The Project

**Modern AI Image Generator** is a web-based application that converts text prompts into AI-generated images using the OpenAI Images API.

Users can simply enter a creative description, select predefined prompts or write their own ideas, and generate images through an attractive and responsive interface.

## 🖼️ Application Screenshots

### 🏠 Home Page
<p align="center">
  <img src="https://github.com/user-attachments/assets/152e236f-84f0-4666-8e65-36df04f78e08" alt="AI Image Generator Home Page" width="95%">
</p>


![AI Assistant Welcome Screen](https://github.com/user-attachments/assets/4d251a39-4d09-4721-94b8-ae4febae364e)
### 🎨 AI Generated Image


<p align="center">
  <img src="https://github.com/user-attachments/assets/e8aa9610-558a-4ac3-b13c-a1a738f56c91" alt="Generated AI Image" width="95%">
</p>

---

## 🚀 Key Features

- ✍️ **Text-to-Image Generation** – Generate images using simple text descriptions.
- 🤖 **OpenAI API Integration** – Connect with OpenAI's image generation model.
- 💡 **Predefined Prompts** – Explore creative example prompts.
- ⏳ **Loading Indicator** – Display progress while generating images.
- 🖼️ **Image Preview** – View generated images directly in the application.
- ⚠️ **Input Validation** – Validate empty prompts before submission.
- 🛡️ **Error Handling** – Handle API errors and display meaningful messages.
- 📱 **Responsive Design** – User-friendly interface with Bootstrap 5.

## 🛠️ Technologies Used

| Technology | Purpose |
|---|---|
| 💻 ASP.NET Core MVC | Web application development |
| 🔷 C# | Backend programming |
| 🤖 OpenAI Images API | AI image generation |
| 🌐 HttpClient | HTTP API communication |
| 💉 Dependency Injection | Service management |
| ⚡ Async/Await | Asynchronous programming |
| 📦 System.Text.Json | JSON response processing |
| 🎨 HTML, CSS, JavaScript | Frontend development |
| 🅱️ Bootstrap 5 | Responsive UI |
| 🔐 .NET User Secrets | Secure API key management |

## ⚙️ How It Works

1. 📝 User enters a text prompt.
2. ✅ MVC Controller validates the prompt.
3. 🌐 `OpenAiImageService` sends an HTTP POST request to the OpenAI API.
4. 🤖 OpenAI processes the prompt and generates an image.
5. 📥 The service extracts Base64 image data or an image URL from the response.
6. 🖼️ The Razor View displays the generated image.

## 💻 Getting Started

### 📋 Prerequisites

Before running the project, make sure you have:

- Visual Studio with ASP.NET and web development workload.
- Compatible .NET SDK.
- OpenAI API key with access to the image generation model.
- Git installed.

### 1️⃣ Clone the Repository

```bash
git clone https://github.com/RajniLamkane/ModernAIImageGenerator.git
cd ModernAIImageGenerator
```

### 2️⃣ Configure OpenAI API Key 🔐

⚠️ **Important:** Never store your actual API key in `appsettings.json` or upload it to GitHub.

Navigate to the directory containing your `.csproj` file and execute:

```powershell
dotnet user-secrets init
```

Store your API key securely:

```powershell
dotnet user-secrets set "OpenAI:ApiKey" "YOUR_OPENAI_API_KEY"
```

The application retrieves the key using:

```csharp
_configuration["OpenAI:ApiKey"]
```

For deployment, configure the key using your hosting provider's secure environment variables or secrets manager.

### 3️⃣ Restore Dependencies

```powershell
dotnet restore
```

### 4️⃣ Run the Application ▶️

```powershell
dotnet run
```

Alternatively, open the project in Visual Studio and press **F5** or **Ctrl + F5**.

### 5️⃣ Generate Your First Image 🎉

1. Open the application in your browser.
2. Enter your desired image description.
3. Click **Generate Image**.
4. Wait for AI image generation.
5. Enjoy your generated image! 🎨

---

## 📂 Project Structure

```text
ModernAIImageGenerator/
│
├── Imagegenerator1/
│   ├── Controllers/
│   │   └── AiImageGenController.cs
│   │
│   ├── Services/
│   │   └── OpenAiImageService.cs
│   │
│   ├── Views/
│   │   └── AiImageGen/
│   │       └── Index.cshtml
│   │
│   ├── Program.cs
│   └── appsettings.json
│
├── .gitignore
├── README.md
└── Imagegenerator1.sln
```

## 🔐 Security Best Practices

- 🔑 Never expose API keys or credentials.
- 🛡️ Use .NET User Secrets during local development.
- ☁️ Use secure environment variables or a secrets manager in production.
- 🚫 Never commit sensitive configuration files.
- 🔄 Revoke and replace any API key that has been exposed.
- 🚦 Consider authentication and rate limiting before public deployment.

## 📚 Key Learnings

Through this project, I gained practical experience in:

- 🌐 Integrating third-party REST APIs with ASP.NET Core.
- 💉 Implementing Dependency Injection with typed HttpClient.
- ⚡ Working with asynchronous programming using async/await.
- 📦 Processing JSON responses using System.Text.Json.
- 🛠️ Handling API errors and exceptions.
- 🖼️ Working with Base64 image data.
- 🔐 Managing sensitive configuration using .NET User Secrets.

## 🔮 Future Enhancements

- [ ] 📜 Add generated image history.
- [ ] ⬇️ Implement image download functionality.
- [ ] 🎨 Add more image generation options.
- [ ] 👤 Implement user authentication.
- [ ] 🗄️ Store user prompts and generated images.
- [ ] ☁️ Deploy the application to Microsoft Azure.
- [ ] 🧪 Add automated unit tests.

---

## 👩‍💻 About the Developer

**Rajni Lamkane**

🎯 Aspiring .NET Developer | ASP.NET Core MVC | C# | SQL Server | REST API Integration

🔗 **GitHub:** [RajniLamkane](https://github.com/RajniLamkane)

📌 **Project Repository:** [ModernAIImageGenerator](https://github.com/RajniLamkane/ModernAIImageGenerator)

---

<div align="center">

### ⭐ Thank You for Visiting!

💬 Feedback and suggestions are always welcome.

🚀 **Keep Learning | Keep Building | Keep Growing!**

</div>
