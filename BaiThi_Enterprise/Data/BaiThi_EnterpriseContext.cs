using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BaiThi_Enterprise.Models
{
    public class BaiThi_EnterpriseContext : DbContext
    {
        public BaiThi_EnterpriseContext (DbContextOptions<BaiThi_EnterpriseContext> options)
            : base(options)
        {
        }

        public DbSet<BaiThi_Enterprise.Models.Employee> Employee { get; set; }
    }
}
