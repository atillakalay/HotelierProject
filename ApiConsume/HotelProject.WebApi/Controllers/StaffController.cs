﻿using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {

        private readonly IStaffService _staffService;
        public StaffController(IStaffService staffService)
        {
            _staffService = staffService;
        }

        [HttpGet]
        public IActionResult StaffList()
        {
            var values = _staffService.GetAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddStaff(Staff staff)
        {
            _staffService.Insert(staff);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteStaff(int id)
        {
            var values = _staffService.GetByID(id);
            _staffService.Delete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateStaff(Staff staff)
        {
            _staffService.Update(staff);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetStaff(int id)
        {
            var values = _staffService.GetByID(id);
            return Ok(values);
        }
        [HttpGet("Last4Staff")]
        public IActionResult Last4Staff()
        {
            var values = _staffService.TLast4Staff();
            return Ok(values);
        }
    }
}
