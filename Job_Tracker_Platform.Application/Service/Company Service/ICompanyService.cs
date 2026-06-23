using Job_Tracker_Platform.Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_Tracker_Platform.Application.Service.Company_Service
{
    public interface ICompanyService
    {
        Task CreatCompany(CompanyDTO companyDTO);
    }
}
