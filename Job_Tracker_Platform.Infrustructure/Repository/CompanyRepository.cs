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

    public class CompanyRepository : ICompanyRepository
    {
        private readonly Appdbcontext _appdbcontext;
        public CompanyRepository(Appdbcontext appdbcontext)
        {
            _appdbcontext=appdbcontext;
        }

        public async Task AddCompany(Company company)
        {
            _appdbcontext.Companies.Add(company);
            await _appdbcontext.SaveChangesAsync();
        }
    }
}
