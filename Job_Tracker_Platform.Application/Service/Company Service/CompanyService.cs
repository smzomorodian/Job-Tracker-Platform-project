using Job_Tracker_Platform.Application.DTO;
using Job_Tracker_Platform.Application.Interfaces_Repository;
using Job_Tracker_Platform.Domain.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_Tracker_Platform.Application.Service.Company_Service
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository _companyRepository;
        public CompanyService(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        public async Task CreatCompany(CompanyDTO companyDTO)
        {
            Company creat = new Company
            (
                Guid.NewGuid(),
                companyDTO.CompanyName,
                companyDTO.Website,
                companyDTO.Location,
                companyDTO.Size
            );

            await _companyRepository.AddCompany(creat);
        }
    }
}
