using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using UTN_Students.BusinessLogic.Contracts;
using UTN_Students.Models.Models;
using UTNAvanzada2.Common;

namespace UTN_Students.BusinessLogic.Implementations
{
    public class StudentService : BaseService<Student>, IStudentService
    {
        public StudentService(
            IConfiguration configuration,
            IMemoryCache memoryCache,
            IJsonManager<Student> jsonManager) : base(configuration, memoryCache, jsonManager)
        {

        }
    }
}
