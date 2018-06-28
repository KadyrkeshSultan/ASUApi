using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASU.DAL.Interfaces;
using ASU.DTO.Documents;
using ASU.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASU.Web.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class StampTypesController : ControllerBase
    {
        IUnitOfWork db;

        public StampTypesController(IUnitOfWork unit)
        {
            db = unit;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(db.StampTypes.GetAll());
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]StampTypeView type)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var stampType = new StampType() { Name = type.Name, Desc = type.Desc };
            await db.StampTypes.AddAsync(stampType);
            await db.SaveAsync();
            return Ok(stampType);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody]StampTypeView view)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var stampType = await db.StampTypes.GetAsync(id);
            if (stampType == null)
                return NotFound(id);
            stampType.Desc = view.Desc;
            stampType.Name = view.Name;

            db.StampTypes.Update(stampType);
            await db.SaveAsync();
            return Ok(stampType);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var stampType = await db.StampTypes.GetAsync(id);
            if (stampType == null)
                return NotFound(id);

            db.StampTypes.Remove(stampType);
            await db.SaveAsync();
            return NoContent();
        }
    }
}