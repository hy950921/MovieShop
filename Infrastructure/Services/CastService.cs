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
    public class CastService : ICastService
    {
        private readonly ICastRepository _castRepository;

        public CastService(ICastRepository castRepository)
        {
            _castRepository = castRepository;
        }

        public Task<CastResponseModel> GetCastDetails(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<CastResponseModel> GetCastDetailsById(int id)
        {
            var cast = await _castRepository.GetCastByIdAsync(id);

            var castResponse = new CastResponseModel()
            {
                Id = cast.Id,
                Name = cast.Name,
                Gender = cast.Gender,
                TmdbUrl = cast.TmdbUrl,
                ProfilePath = cast.ProfilePath
            };
            return castResponse;
        }

        public async Task<List<CastResponseModel>> GetResponseCasts()
        {
            var casts = await _castRepository.GetAllCastsAsync();

            var res = new List<CastResponseModel>();

            foreach (var cast in casts)
            {
                res.Add(new CastResponseModel { Id = cast.Id, Name = cast.Name, Gender = cast.Gender, TmdbUrl = cast.TmdbUrl, ProfilePath = cast.ProfilePath });
            }
            return res;
        }
    }
}
