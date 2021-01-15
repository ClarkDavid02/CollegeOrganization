using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDCasupanan.COllegeOrganizationChart.Window.DAL
{
    public class DataInitiallizer : System.Data.Entity.DropCreateDatabaseAlways<CollegeOrganizationChartDBContext>
    {
        protected override void Seed(CollegeOrganizationChartDBContext context)
        {
            base.Seed(context);
            context.Employees.Add(new Models.Employee()
            {
                Id = Guid.Parse("25eee6e0-074f-4029-8d85-888fff2257e9"),
                Name = "123",
                gender = Models.Enums.Gender.Female,
                assignment = Models.Enums.Assignment.Office,
                Email = "bebelate@gmail.com",


            });
        }
    }
}
