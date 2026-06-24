using Job_Tracker_Platform.Application.DTO;
using Job_Tracker_Platform.Application.Service.Company_Service;
using Job_Tracker_Platform.Application.User_Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Job_Tracker_Platform_project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyService _companyService;
        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        [HttpPost]
        public async Task<IActionResult> CreatCompany(CompanyDTO companyDTO)
        {
            await _companyService.CreatCompany(companyDTO);
            return Ok("Company Created Successfully");
        }
        /// <summary>
        /// To get a specific person by ID
        /// </summary>
        /// <param name="id">person ID</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDataSpecificPersonByID(Guid id)
        {
            var find = await _companyService.GetCompanyDataWhitIdAsync(id);
            if(find == null)
            {
                return BadRequest("شرکت یافت نشد.");
            }
            return Ok(find);
        }

        [HttpGet]
        public async Task<IActionResult> GetDataAllPerson()
        {
            List<CompanyDTO> find = await _companyService.GetCompanyAllDataAsync();
            return Ok(find);
        }
    }
}
