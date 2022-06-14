
using Microsoft.EntityFrameworkCore;
using s21284_KOL2_APBD.Entities;
using s21284_KOL2_APBD.Entities.Models;

namespace s21284_KOL2_APBD.Services
{
    public class RepoService : IRepoService
    {
        private readonly RepositoryContext _repository;
        public RepoService(RepositoryContext repository)
        {
            _repository = repository;
        }
        public Task CreateAsync<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }

        public IQueryable<Album> GetAlbum()
        {
            return _repository.Album
                .Include(e => e.Tracks);
        }
    }
}
