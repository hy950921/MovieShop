using ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.ServiceInterfaces
{
    public interface ICastService
    {
        

        Task<List<CastResponseModel>> GetResponseCasts();
        Task<CastResponseModel> GetCastDetailsById(int id);
    }
}
