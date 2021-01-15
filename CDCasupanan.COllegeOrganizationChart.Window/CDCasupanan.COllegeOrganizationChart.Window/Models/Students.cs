using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDCasupanan.COllegeOrganizationChart.Window.Models.Enums;

namespace CDCasupanan.COllegeOrganizationChart.Window.Models
{
    public class Students
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Gender gender { get; set; }
        public Department department { get; set; }
    }
}
