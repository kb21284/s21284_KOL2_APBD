using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using s21284_KOL2_APBD.Entities.Models;
using s21284_KOL2_APBD.Services;
using System.Transactions;

namespace s21284_KOL2_APBD.Controllers
{
    
        [Route("api/[controller]")]
        [ApiController]
        public class AlbumController : ControllerBase
        {

            private readonly IRepoService _service;

            public AlbumController(IRepoService service)
            {
                _service = service;
            }

            [HttpPost("{albumId}/album")]
            public async Task<IActionResult> Create(int albumId)
            {

                if (!ModelState.IsValid)
                    return BadRequest("Niepoprawne ciało żądania!");

                if (await _service.GetAlbumById(albumId).FirstOrDefaultAsync() is null)
                    return NotFound("Nie znaleziono albumu o podanym id");

                using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
                {
                    try
                    {
                        
                        await _service.SaveChangesAsync();

                        scope.Complete();

                    }
                    catch (Exception)
                    {
                        return Problem("Nieoczekiwany błąd serwera");
                    }
                }
                await _service.SaveChangesAsync();

                return NoContent();
            }
        }
}