using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDCasupanan.COllegeOrganizationChart.Window.Models;

namespace CDCasupanan.COllegeOrganizationChart.Window.DAL
{
    public class CollegeOrganizationChartDBContext : DbContext
    {
        public CollegeOrganizationChartDBContext() : base("myConnectingString")
        { 
            Database.SetInitializer(new CDCasupanan.COllegeOrganizationChart.Window.DAL.DataInitiallizer());
        }
        public DbSet<Models.Employee> Employees { get; set; }
        public DbSet<Models.Students> Students { get; set; }
        public DbSet<Models.Department> Departments { get; set; }
    }
}
