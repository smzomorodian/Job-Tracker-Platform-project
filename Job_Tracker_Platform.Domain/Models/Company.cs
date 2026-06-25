using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_Tracker_Platform.Domain.Models
{
    public class Company
    {
        public Guid Id { get; private set; }
        public string CompanyName { get; private set;}
        public string? Website { get; private set; }
        public string? Location { get; private set; }
        public int? Size { get; private set; }

        private Company() { }

        public Company(Guid id, string companyName, string? website, string? location, int? size)
        {
            if (string.IsNullOrWhiteSpace(companyName))
                throw new ArgumentException("Company Name is required");

            Id = Guid.NewGuid();
            CompanyName = companyName;
            Website = website;
            Location = location;
            Size = size;
        }

        public void UpdateCompany(string companyName, string? website, string? location, int? size)
        {
            if (string.IsNullOrWhiteSpace(companyName))
                throw new ArgumentException("Company Name is required");

            CompanyName = companyName;
            Website = website;
            Location = location;
            Size = size;
        }
    }
}
