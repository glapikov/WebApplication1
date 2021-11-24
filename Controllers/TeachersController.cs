using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TeachersController : ControllerBase
    {
        private TeacherRepository _repository;
        public TeachersController(TeacherRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Teacher>> GetAll()
        {
            var teacher = _repository.GetAll();
            return Ok(teacher);
        }

        [HttpGet("NoLessons")]
        public ActionResult<IEnumerable<Teacher>> Get()
        {
            var noLessons = _repository.Get();
            return Ok(noLessons);
        }
    }
}

