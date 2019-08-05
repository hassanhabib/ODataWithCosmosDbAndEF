using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CosmosEFWithOData.Brokers;
using CosmosEFWithOData.Models;
using Microsoft.AspNet.OData;

namespace CosmosEFWithOData.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly StudentsDbContext _context;

        public StudentsController(StudentsDbContext context)
        {
            _context = context;
        }

        // GET: api/Students
        [HttpGet]
        [EnableQuery()]
        public async Task<ActionResult<IEnumerable<Student>>> GetStudents()
        {
            return await _context.Students.ToListAsync();
        }
    }
}
