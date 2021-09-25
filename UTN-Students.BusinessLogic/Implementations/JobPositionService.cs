using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using UTN_Students.BusinessLogic.Contracts;
using UTN_Students.Models.Models;
using UTNAvanzada2.Common;

namespace UTN_Students.BusinessLogic.Implementations
{
    public class JobPositionService : BaseService<JobPosition>, IJobPositionService
    {
        public JobPositionService(
            IConfiguration configuration,
            IMemoryCache memoryCache,
            IJsonManager<JobPosition> jsonManager) : base(configuration, memoryCache, jsonManager)
        {
        }
    }
}
