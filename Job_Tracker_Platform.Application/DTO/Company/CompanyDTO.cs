using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_Tracker_Platform.Application.DTO.Company
{
    public class CompanyDTO
    {
        public string CompanyName { get; set; }
        public string? Website { get; set; }
        public string? Location { get; set; }
        public int? Size { get; set; }
    }
}
