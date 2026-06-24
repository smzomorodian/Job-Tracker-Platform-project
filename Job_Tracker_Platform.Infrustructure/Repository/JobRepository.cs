using Job_Tracker_Platform.Application.DTO;
using Job_Tracker_Platform.Application.Interfaces_Repository;
using Job_Tracker_Platform.Domain.Models;
using Job_Tracker_Platform.Infrustructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_Tracker_Platform.Infrustructure.Repository
{
    public class JobRepository : IJobRepository
    {
        private readonly Appdbcontext _appdbcontext;
        public JobRepository(Appdbcontext appdbcontext)
        {
            _appdbcontext = appdbcontext;
        }

        public async Task AddJob(JobApplication jobApplication)
        {
            _appdbcontext.JobApplications.Add(jobApplication);
            await _appdbcontext.SaveChangesAsync();
        }
    }
}
