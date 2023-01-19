using System;

namespace Domain.Models
{
    public class Company
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime CreatedDate { get; set; }

        public string LegalAddress { get; set; }
    }
}
