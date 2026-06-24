using Job_Tracker_Platform.Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_Tracker_Platform.Application.Services.JobApplications
{
    public interface IJobService
    {
        Task AddJob(JobDTO jobDTO);
    }
}
