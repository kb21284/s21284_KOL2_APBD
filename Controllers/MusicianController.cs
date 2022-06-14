using Microsoft.AspNetCore.Mvc;
using s21284_KOL2_APBD.Services;

namespace s21284_KOL2_APBD.Controllers
{
    public class MusicianController : Controller
    {
        //[HttpDelete]
        /*public Task<IActionResult> RemoveMusician(int idMusician)
        {
            return View();
        }*/
        private readonly IRepoService _service;

        public MusicianController(IRepoService service)
        {
            _service = service;
        }

        [HttpDelete]
        public IActionResult DeleteMusician(int idMusician)
        {
            //_service.DeleteMusician(idMusician);
            return Created("", "");
        }
    }
}
