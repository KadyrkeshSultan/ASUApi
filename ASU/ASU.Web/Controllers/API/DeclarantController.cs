using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASU.DTO;
using ASU.DTO.Actors;
using ASU.DTO.EF;
using ASU.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASU.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeclarantsController : ControllerBase
    {
        AppDbContext db;

        public DeclarantsController(AppDbContext dbContext)
        {
            db = dbContext;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var dec = await db.Declarants.FirstOrDefaultAsync(d => d.Id == id);
            if (dec == null)
                return NotFound(id);

            var view = new DeclarantView()
            {
                Id = id,
                Address = dec.Address,
                IIN = dec.IIN,
                Name = dec.Name,
                Phone = dec.Phone
            };
            return Ok(view);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] DeclarantView model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var dec = new Declarant()
            {
                Address = model.Address,
                IIN = model.IIN,
                Name = model.Name,
                Phone = model.Phone
            };
            await db.Declarants.AddAsync(dec);
            await db.SaveChangesAsync();
            return CreatedAtAction("Get", new { id = dec.Id }, dec);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] DeclarantView model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var dec = await db.Declarants.FirstOrDefaultAsync(d => d.Id == id);
            if (dec == null)
                return NotFound(id);

            dec.IIN = model.IIN;
            dec.Name = model.Name;
            dec.Phone = model.Phone;
            dec.Address = model.Address;

            db.Declarants.Update(dec);
            await db.SaveChangesAsync();
            return Ok(dec);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var dec = await db.Declarants.FirstOrDefaultAsync(d => d.Id == id);
            if (dec == null)
                return NotFound(id);

            db.Declarants.Remove(dec);
            await db.SaveChangesAsync();
            return NoContent();
        }
    }
}