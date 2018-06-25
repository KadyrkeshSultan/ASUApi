using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASU.DAL.Interfaces;
using ASU.DTO;
using ASU.DTO.Entities;
using ASU.Web.Models;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASU.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeasureDeviceTypesController : ControllerBase
    {
        IUnitOfWork db;

        public MeasureDeviceTypesController(IUnitOfWork unit)
        {
            db = unit;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var device = await db.MeasureDeviceTypes.GetAsync(id);
            if (device == null)
                return NotFound();

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<MeasureDeviceType, MeasureDeviceTypeView>()).CreateMapper();
            var view = mapper.Map<MeasureDeviceType, MeasureDeviceTypeView>(device);
            return Ok(view);
        }

        [HttpPost]
        public async Task<IActionResult> Post(MeasureDeviceTypeView view)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var measurementType = await db.MeasurementTypes.GetAsync(view.MeasurementTypeId);
            if (measurementType == null)
                return NotFound(view.MeasurementTypeId);

            var device = new MeasureDeviceType()
            {
                AllowedByCat = view.AllowedByCat,
                AllowedByClass = view.AllowedByClass,
                AllowedByRandom = view.AllowedByRandom,
                MDProducer = view.MDProducer,
                MeasurementTypeId = view.MeasurementTypeId,
                MeasurmentRange = view.MeasurmentRange,
                QualifiedName = view.QualifiedName,
                VerificationGap = view.VerificationGap,
                VerificationProc = view.VerificationProc,
                Name = view.Name
            };

            await db.MeasureDeviceTypes.AddAsync(device);
            await db.SaveAsync();
            return CreatedAtAction("Get", new { id = device.Id }, device);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, MeasureDeviceTypeView view)
        {
            var device = await db.MeasureDeviceTypes.GetAsync(id);
            if (device == null)
                return NotFound();
            var measurementType = await db.MeasurementTypes.GetAsync(view.MeasurementTypeId);
            if (measurementType == null)
                return NotFound(view.MeasurementTypeId);

            var mapper = new MapperConfiguration(cfg =>
                cfg.CreateMap<MeasureDeviceTypeView, MeasureDeviceType>()
                .ForMember("Id", opt => opt.Ignore())
            ).CreateMapper();

            var deviceUp = mapper.Map<MeasureDeviceTypeView, MeasureDeviceType>(view);

            db.MeasureDeviceTypes.Update(deviceUp);
            await db.SaveAsync();

            return Ok(deviceUp);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var device = await db.MeasureDeviceTypes.GetAsync(id);

            if (device == null)
                return NotFound();

            db.MeasureDeviceTypes.Remove(device);
            await db.SaveAsync();
            return NoContent();
        }
    }
}