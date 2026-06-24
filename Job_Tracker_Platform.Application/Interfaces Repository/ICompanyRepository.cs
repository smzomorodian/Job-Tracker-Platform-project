using Job_Tracker_Platform.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_Tracker_Platform.Application.Interfaces_Repository
{
    public interface ICompanyRepository
    {
        Task AddCompany(Company company);

        Task<Company?> GetCompanyDataWhitId(Guid id);

        Task<List<Company>> GetCompanyAllData();
    }
}
