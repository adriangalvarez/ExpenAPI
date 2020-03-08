using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExpenAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExpenAPI.Controllers
{
    // Rest API for managing buildings (CRUD)
    [ApiController]
    [Route("api/[controller]")]
    public class CountriesController : ControllerBase
    {
        private AppDBContext _context;

        public CountriesController(AppDBContext context )
        {
            _context = context;
        }

        // GET: api/countries
        // Returns all countries
        [HttpGet]
        public ActionResult<IEnumerable<Country>> GetAll()
        {
            return _context.Countries;
        }

        // GET: api/countries/{id}
        [HttpGet("{id}")]
        public ActionResult<Country> Get(int id )
        {
            Country country = _context.Countries.Find( id );
            if ( country == null )
            {
                return NotFound();
            }

            return country;
        }
    }
}