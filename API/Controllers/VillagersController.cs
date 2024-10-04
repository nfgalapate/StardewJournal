using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    public class VillagersController : BaseApiController
    {
         private readonly DataContext _context;
        public VillagersController(DataContext context)
        {
           _context = context;
        }

        [HttpGet] //api/villagers
        public async Task<ActionResult<List<Villager>>> GetVillagers()
        {
            return await _context.Villagers.ToListAsync();
        }
        [HttpGet("{id}")] //api/villagers/guid-12345
        public async Task<ActionResult<Villager>> GetVillager(Guid id)
        {
            return await _context.Villagers.FindAsync(id);
        }
    }
}