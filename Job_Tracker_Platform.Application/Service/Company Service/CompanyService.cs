using Job_Tracker_Platform.Application.DTO.Company;
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

        public async Task Delete(Guid id)
        {
            var find = await _companyRepository.GetCompanyDataWhitId(id);
            if(find == null)
            {
                throw new Exception("Company not found");
            }
            await _companyRepository.Delete(find);
        }

        public async Task<List<CompanyDTO>> GetCompanyAllDataAsync()
        {
            var companies = await _companyRepository.GetCompanyAllData();
            return companies.Select(c => new CompanyDTO
            {
                CompanyName = c.CompanyName,
                Website = c.Website,
                Location = c.Location,
                Size = c.Size
            }).ToList();
        }

        public async Task<CompanyOutPutDTO?> GetCompanyDataWhitIdAsync(Guid id)
        {
            Company find = await _companyRepository.GetCompanyDataWhitId(id);
            if(find == null)
            {
                throw new Exception("Company not found");
            }
            var result = new CompanyOutPutDTO
            {
                CompanyName = find.CompanyName,
                Website = find.Website,
                Location = find.Location,
                Size = (int)find.Size
            };

            return result;
        }
    }
}
