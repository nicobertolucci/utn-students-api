using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using UTN_Students.BusinessLogic.Contracts;
using UTN_Students.Models.Models;
using UTNAvanzada2.Common;

namespace UTN_Students.BusinessLogic.Implementations
{
    public class CareerService : BaseService<Career>, ICareerService
    {
        public CareerService(
            IConfiguration configuration,
            IMemoryCache memoryCache,
            IJsonManager<Career> jsonManager) : base(configuration, memoryCache, jsonManager)
        {

        }
    }
}
