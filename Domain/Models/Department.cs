using System.Collections.Generic;

namespace Domain.Models
{
    public class Department
    {
        public string Name { get; set; }

        public Employee Manager { get; set; }

        public List<Employee> Employees { get; set; }
    }
}
