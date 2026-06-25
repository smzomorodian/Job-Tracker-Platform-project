using Job_Tracker_Platform.Application.DTO.Company;
using Job_Tracker_Platform.Domain.Models;
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
        Task<CompanyOutPutDTO?> GetCompanyDataWhitIdAsync(Guid id);
        Task<List<CompanyDTO>> GetCompanyAllDataAsync();
        Task Delete(Guid id);
    }
}
