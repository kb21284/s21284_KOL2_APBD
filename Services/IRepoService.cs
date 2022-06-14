using s21284_KOL2_APBD.Entities.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace s21284_KOL2_APBD.Services
{
    public interface IRepoService
    {
        IQueryable<Album> GetAlbum();
        Task CreateAsync<T>(T entity) where T : class;
    }
}
