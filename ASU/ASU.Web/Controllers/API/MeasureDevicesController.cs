using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASU.DAL.Interfaces;
using ASU.DTO.Entities;
using ASU.Web.Models;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASU.Web.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeasureDevicesController : ControllerBase
    {
        IUnitOfWork db;

        public MeasureDevicesController(IUnitOfWork unit)
        {
            db = unit;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var device = await db.MeasureDevices.GetAsync(id);
            if (device == null)
                return NotFound(id);

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<MeasureDevice, MeasureDeviceView>()).CreateMapper();
            var view = mapper.Map<MeasureDevice, MeasureDeviceView>(device);
            return Ok(view);
        }

        [HttpPost]
        public async Task<IActionResult> Post(MeasureDeviceView view)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var measurementType = await db.MeasurementTypes.GetAsync(view.MeasurementTypeId);
            if (measurementType == null)
                return NotFound(view.MeasurementTypeId);

            var measureDeviceType = await db.MeasureDeviceTypes.GetAsync(view.MeasureDeviceTypeId);
            if (measureDeviceType == null)
                return NotFound(view.MeasureDeviceTypeId);

            var device = new MeasureDevice()
            {
                AllowedByCat = view.AllowedByCat,
                AllowedByClass = view.AllowedByClass,
                AllowedByRandom = view.AllowedByRandom,
                MDProducer = view.MDProducer,
                MDProductionDate = view.MDProductionDate,
                MeasureDeviceTypeId = view.MeasureDeviceTypeId,
                MeasurementTypeId = view.MeasurementTypeId,
                MeasurmentRange = view.MeasurmentRange,
                Name = view.Name,
                Number = view.Number,
                QualifiedName = view.QualifiedName,
                VerificationGap = view.VerificationGap,
                VerificationProc = view.VerificationProc
            };

            await db.MeasureDevices.AddAsync(device);
            await db.SaveAsync();
            return CreatedAtAction("Get", new { id = device.Id }, device);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, MeasureDeviceView view)
        {
            var device = await db.MeasureDevices.GetAsync(id);
            if (device == null)
                return NotFound(id);

            var measurementType = await db.MeasurementTypes.GetAsync(view.MeasurementTypeId);
            if (measurementType == null)
                return NotFound(view.MeasurementTypeId);

            var measureDeviceType = await db.MeasureDeviceTypes.GetAsync(view.MeasureDeviceTypeId);
            if (measureDeviceType == null)
                return NotFound(view.MeasureDeviceTypeId);

            var mapper = new MapperConfiguration(cfg =>
                cfg.CreateMap<MeasureDeviceView, MeasureDevice>()
                .ForMember("Id", opt => opt.Ignore())
            ).CreateMapper();

            var deviceUp = mapper.Map<MeasureDeviceView, MeasureDevice>(view);

            db.MeasureDevices.Update(deviceUp);
            await db.SaveAsync();

            return Ok(deviceUp);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var device = await db.MeasureDevices.GetAsync(id);

            if (device == null)
                return NotFound();

            db.MeasureDevices.Remove(device);
            await db.SaveAsync();
            return NoContent();
        }
    }
}