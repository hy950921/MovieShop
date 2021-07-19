using ApplicationCore.Entities;
using ApplicationCore.Models;
using ApplicationCore.RepositoryInterfaces;
using ApplicationCore.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class GenresService : IGenreService
    {
        private readonly IAsyncRepository<Genre> _genreRepository;

        public GenresService(IAsyncRepository<Genre> genreRepository)
        {
            _genreRepository = genreRepository;
        }

        public async Task<IEnumerable<GenreModel>> GetAllGenres()
        {
            var genres = await _genreRepository.ListAllAsync();

            var genresModel = new List<GenreModel>();

            foreach (var genre in genres)
            {
                genresModel.Add(new GenreModel { Id = genre.Id, Name = genre.Name });
            }
            return genresModel;
        }
    }
}
