using Job_Tracker_Platform.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_Tracker_Platform.Infrustructure.Context
{
    public class Appdbcontext : DbContext
    {
            public Appdbcontext(
                DbContextOptions<Appdbcontext> options)
                : base(options)
            {
            }

            public DbSet<User> Users => Set<User>();
            public DbSet<Company> Companies => Set<Company>();
            public DbSet<JobApplication> JobApplications => Set<JobApplication>();
        
    }
}
