using Job_Tracker_Platform.Application.DTO;
using Job_Tracker_Platform.Application.Services.JobApplications;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Job_Tracker_Platform_project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobApplicationController : ControllerBase
    {
        private readonly IJobService _jobService;
        public JobApplicationController(IJobService jobService)
        {
            _jobService = jobService;
        }

        [HttpPost]
        public async Task<IActionResult> CreatJobApplicationAsync(JobDTO jobDTO)
        {
            await _jobService.AddJob(jobDTO);
            return Ok("Company Created Successfully");
        }

        //[HttpGet]
    }
}
