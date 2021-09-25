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
    public class CareerController : BaseController
    {
        private readonly ICareerService _careerService;

        public CareerController(IConfiguration configuration, IMapper mapper, ICareerService careerService) : base(configuration, mapper)
        {
            _careerService = careerService;
        }

        [HttpGet]
        [Route("")]
        public IActionResult GetAll()
        {
            var result = _mapper.Map<IList<CareerVM>>(_careerService.GetAll());

            return Ok(result);
        }

    }
}
