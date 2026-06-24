using Job_Tracker_Platform.Domain.Models.Enume;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_Tracker_Platform.Application.DTO
{
    public class JobDTO
    {
        public Guid UserId { get; set; }
        public Guid CompanyId { get; set; }
        public JobApplicationStatus Statuse { get; set; }
    }
}
