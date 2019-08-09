using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CosmosEFWithOData.Brokers;
using CosmosEFWithOData.Models;
using Microsoft.AspNet.OData;
using System.Linq;
using System;

namespace CosmosEFWithOData.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly StudentsDbContext context;

        public StudentsController(StudentsDbContext context)
        {
            this.context = context;
        }

        // GET: api/Students
        [HttpGet]
        [EnableQuery()]
        public ActionResult<IQueryable<Student>> GetStudents()
        {
            return context.Students;
        }
    }
}
