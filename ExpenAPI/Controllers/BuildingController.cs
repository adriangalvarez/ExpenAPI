using System.Collections.Generic;
using System.Threading.Tasks;
using ExpenAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExpenAPI.Controllers
{
    // Rest API for managing buildings (CRUD)
    [ApiController]
    [Route("api/[controller]")]
    public class BuildingController : ControllerBase
    {
        private readonly AppDBContext _context;

        public BuildingController(AppDBContext context)
        {
            _context = context;
        }

        // GET: /api/building
        // Returns all buildings
        [HttpGet]
        public ActionResult<IEnumerable<Building>> GetAllBuildings()
        {
            return _context.Buildings;
        }

        // GET: api/building/{id}
        // Returns building with id sent in url
        [HttpGet("{id}")]
        public ActionResult<Building> Get(int id)
        {
            Building building = _context.Buildings.Find(id);

            if ( building == null )
                return NotFound();
            else
                return building;
        }

        // POST: api/building
        // Create new building sent in body
        // Returns new building with id
        [HttpPost]
        public async Task<ActionResult> AddBuildingAsync(Building newBuilding)
        {
            _context.Buildings.Add( newBuilding );
            await _context.SaveChangesAsync();
            return CreatedAtAction( nameof( Get ), new Building { Id = newBuilding.Id }, newBuilding );
        }

        // PUT: api/building/{id}
        // Replaces old building values specified by id with new building sent in body
        // If building id sent in body doesn't match id in url, Bad Request is returned
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateAsync(int id, Building building )
        {
            if ( id != building.Id )
            {
                return BadRequest();
            }

            _context.Entry( building ).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/building/id
        // Delete building with id sent in url
        // If id is not found, 404 is returned, otherwise, deleted building is returned
        [HttpDelete("{id}")]
        public async Task<ActionResult<Building>> DeleteAsync(int id)
        {
            Building building = _context.Buildings.Find( id );
            if ( building == null )
            {
                return NotFound();
            }

            _context.Buildings.Remove( building );
            await _context.SaveChangesAsync();

            return building;
        }
    }
}