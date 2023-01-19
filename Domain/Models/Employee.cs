namespace Domain.Models
{
    public class Employee
    {
        public string FirstName { get; set; }

        public string SurName { get; set; }

        public string MiddleName { get; set; }

        public string Birthday { get; set; }

        public string DateOfEmployment { get; set; }

        public Department Department { get; set; }

        public string Position { get; set; }

        public decimal Salary { get; set; }
    }
}
