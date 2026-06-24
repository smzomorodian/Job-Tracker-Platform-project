using Job_Tracker_Platform.Application.DTO;
using Job_Tracker_Platform.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_Tracker_Platform.Application.Interfaces_Repository
{
    public interface IJobRepository
    {
        Task AddJob(JobApplication jobApplication);
    }
}
