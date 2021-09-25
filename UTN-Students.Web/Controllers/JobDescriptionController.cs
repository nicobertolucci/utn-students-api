using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using UTN_Students.BusinessLogic.Contracts;
using UTN_Students.Web.Filters;
using UTN_Students.Web.ViewModels;

namespace UTN_Students.Web.Controllers
{
    [ApiKeyAuth]
    [Route("api/[controller]")]
    [ApiController]
    public class JobPositionController : BaseController
    {
        private readonly IJobPositionService _jobPositionService;

        public JobPositionController(IConfiguration configuration, IMapper mapper, IJobPositionService jobPositionService) : base(configuration, mapper)
        {
            _jobPositionService = jobPositionService;
        }

        [HttpGet]
        [Route("")]
        public IActionResult GetAll()
        {
            var result = _mapper.Map<IList<JobPositionVM>>(_jobPositionService.GetAll());

            return Ok(result);
        }
    }
}
