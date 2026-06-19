using Job_Tracker_Platform.Domain.Models.Enume;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_Tracker_Platform.Domain.Models
{
    public class JobApplication
    {
        public Guid Id { get; private set; }
        public JobApplicationStatus Statuse { get; private set; }
        public Guid CompanyId { get; private set; }
        public Company? Company { get; private set; }

        public Guid UserId { get; private set; }
        public User? User { get; private set; }

        private JobApplication() { }

        public JobApplication(JobApplicationStatus statuse, Guid companyId,Guid userId)
        {

            if (userId == Guid.Empty)
                throw new ArgumentException("UserId is required");

            if (companyId == Guid.Empty)
                throw new ArgumentException("CompanyId is required");


            Id = Guid.NewGuid();
            Statuse = statuse;
            CompanyId = companyId;
            UserId = userId;
        }
    }
}
