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
    public class StudentController : BaseController
    {
        private readonly IStudentService _studentService;

        public StudentController(IConfiguration configuration, IMapper mapper, IStudentService studentService) : base(configuration, mapper)
        {
            _studentService = studentService;
        }

        [HttpGet]
        [Route("")]
        public IActionResult GetAll()
        {
            var result = _mapper.Map<IList<StudentVM>>(_studentService.GetAll());

            return Ok(result);
        }
    }
}
