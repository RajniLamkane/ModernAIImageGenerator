using Imagegenerator1.Services;
using Microsoft.AspNetCore.Mvc;

namespace Imagegenerator1.Controllers
{
    public class AiImageGenController : Controller
    {
        private readonly OpenAiImageService _openAiService;

        public AiImageGenController(OpenAiImageService openAiService)
        {
            _openAiService = openAiService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Generate(string prompt)
        {
            ViewBag.Prompt = prompt;

            if (string.IsNullOrWhiteSpace(prompt))
            {
                ViewBag.Error = "Please enter a prompt.";
                return View("Index");
            }

            try
            {
                ViewBag.ImageUrl = await _openAiService.GenerateImageAsync(prompt);
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;

                Console.WriteLine("CONTROLLER ERROR:");
                Console.WriteLine(ex.ToString());
            }

            return View("Index");
        }
    }
}
