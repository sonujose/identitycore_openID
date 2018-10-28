
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using webapisqlite.Models;
using webapisqlite.Data;
using webapisqlite.Dtos;

namespace webapisqlite.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : Controller
    {
        private readonly ApplicationDbContext _applicationContext;

        public CompanyController(ApplicationDbContext applicationContext) {
            _applicationContext = applicationContext;
        }

        [HttpGet]
        public ActionResult<List<Company>> Get() {
            return _applicationContext.Company.ToList();
        }

        [HttpPost]
        public ActionResult AddCompany(Company company) {
            try
            {
                _applicationContext.Company.Add(new Company(){Name=company.Name, OwnerEmail=company.OwnerEmail, OwnerName=company.OwnerName});
                var result = _applicationContext.SaveChanges();
                return Ok(result);
            }
            catch (System.Exception)
            {            
                throw;                
            }
        }
    }
}