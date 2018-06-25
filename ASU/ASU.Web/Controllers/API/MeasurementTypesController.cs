using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ASU.DTO;
using ASU.DTO.Entities;
using Microsoft.AspNetCore.Authorization;
using ASU.Web.Models;
using ASU.DAL.Interfaces;

namespace ASU.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeasurementTypesController : ControllerBase
    {
        private IUnitOfWork db;

        public MeasurementTypesController(IUnitOfWork unit)
        {
            db = unit;
        }

        // GET: api/MeasurementTypes
        [HttpGet]
        public IEnumerable<MeasurementType> GetMeasurementTypes()
        {
            return db.MeasurementTypes.GetAll();
        }

        // GET: api/MeasurementTypes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMeasurementType([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var measurementType = await db.MeasurementTypes.GetAsync(id);

            if (measurementType == null)
            {
                return NotFound();
            }

            return Ok(measurementType);
        }

        // PUT: api/MeasurementTypes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMeasurementType([FromRoute] int id, [FromBody] MeasurementTypeView measurementType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var type = await db.MeasurementTypes.GetAsync(id);

            if (type == null)
                return NotFound(id);
            type.Name = measurementType.Name;
            db.MeasurementTypes.Update(type);
            await db.SaveAsync();

            return Ok(type);
        }

        // POST: api/MeasurementTypes
        [HttpPost]
        public async Task<IActionResult> PostMeasurementType([FromBody] MeasurementTypeView measurementType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            MeasurementType type = new MeasurementType() {Name = measurementType.Name };
            db.MeasurementTypes.Add(type);
            await db.SaveAsync();

            return CreatedAtAction("GetMeasurementType", new { id = type.Id }, type);
        }

        // DELETE: api/MeasurementTypes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMeasurementType([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var measurementType = await db.MeasurementTypes.GetAsync(id);
            if (measurementType == null)
            {
                return NotFound();
            }

            db.MeasurementTypes.Remove(measurementType);
            await db.SaveAsync();

            return NoContent();
        }
    }
}