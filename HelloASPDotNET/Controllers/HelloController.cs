using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloASPDotNET.Controllers
{
    [Route("/helloworld")]
    public class HelloController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            //string html = "<h1>Hello World!</h1>";
            string html = "<form method='post' action='/helloworld/'>" +
                "<input type='text' name='name' />" +
                "<select name = 'language' id = 'language-select' ><option value='Hello '>English</option><option value='Hola '>Spanish</option><option value='Bonjour '>French</option><option value='Ciao '>Italian</option><option value='Hallo '>German</option></select><input type='submit' value='Greet Me!'/></form>";
            return Content(html, "text/html");
        }

        // GET: /hello/welcome
        //[HttpGet]
        //[Route("/helloworld/welcome/{name?}")]

        [HttpGet("welcome/{name?}")]
        [HttpPost]
        public IActionResult Welcome(string language = "English", string name = "World")
        {
            return Content(language + name + "!</h1>", "text/html");
        }
    }
}
