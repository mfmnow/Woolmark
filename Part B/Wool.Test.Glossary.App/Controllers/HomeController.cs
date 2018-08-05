using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Wool.Test.Glossary.Data.Contracts;
using Microsoft.Extensions.DependencyInjection;

namespace Wool.Test.Glossary.App.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
