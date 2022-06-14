using Microsoft.AspNetCore.Mvc;

namespace s21284_KOL2_APBD.Controllers
{
    public class MusicianController : Controller
    {
        [HttpDelete]
        public IActionResult Index(int idMusician)
        {
            return View();
        }
    }
}
