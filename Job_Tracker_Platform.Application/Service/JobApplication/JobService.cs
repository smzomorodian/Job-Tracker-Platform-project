using Job_Tracker_Platform.Application.DTO;
using Job_Tracker_Platform.Application.Interfaces_Repository;
using Job_Tracker_Platform.Domain.Models;
using Job_Tracker_Platform.Domain.Models.Enume;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_Tracker_Platform.Application.Services.JobApplications
{

    public class JobService : IJobService
    {

        private readonly IJobRepository _jobRepository;
        public JobService(IJobRepository jobRepository)
        {
            _jobRepository = jobRepository;
        }
        public async Task AddJob(JobDTO jobDTO)
        {
            JobApplication creat = new JobApplication
            (
                JobApplicationStatus.Applied,
                jobDTO.CompanyId,
                jobDTO.UserId
            );

            await _jobRepository.AddJob(creat);
        }
    }
}
