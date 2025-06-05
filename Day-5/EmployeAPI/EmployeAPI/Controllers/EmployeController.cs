using EmployeAPI.Entities.Context;
using EmployeAPI.Entities.Entities;
using EmployeAPI.Models;
using EmployeAPI.Services.Services.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmployeAPI.Controllers
{

    [ApiController]
    [Route("api/[Controller]")]

    public class EmployeController : Controller
    {

        private readonly IEmployeService _employeService;

        public EmployeController(IEmployeService employeService)
        {
            _employeService = employeService;
        }

        [HttpPost]
        [Route("Add")]
        [Authorize]
        public async Task<ActionResult> AddEmploye(EmployeDetails employeDetails)
        {
            await _employeService.InsertEmploye(employeDetails);
            return Ok("Employe created !");
        }

        [HttpGet]
        [Route("GetAll")]
        public ActionResult GetAll()
        {
            return Ok(_employeService.GetAll());
        }

        [HttpGet]
        [Route("GetById")]
        public ActionResult GetById(int id)
        {
            var res = _employeService.GetEmployeDetailsById(id);

            if (res != null) { return Ok(res); }

            return NotFound("Employe not found!");
        }

        // To Update Employe
        // To Delete Employe

    }
}
