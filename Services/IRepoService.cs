using s21284_KOL2_APBD.Entities.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace s21284_KOL2_APBD.Services
{
    public interface IRepoService
    {
        IQueryable<Album> GetAlbumById(int idAlbum);
        Task SaveChangesAsync();
        Task CreateAsync<T>(T entity) where T : class;
    }
}
/*
 IQueryable<Zamowienie> GetAllOrders();
        IQueryable<Zamowienie> GetAllOrdersByClientName(string clientName);
        Task SaveChangesAsync();
        IQueryable<Pracownik> GetEmployeeById(int id);
        IQueryable<Klient> GetClientById(int id);
        IQueryable<WyrobCukierniczy> GetConfectioneryById(int id);
        Task CreateAsync<T>(T entity) where T : class;
 */
