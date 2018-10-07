using System;

namespace Product
{
    public class EmployeeEntity
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Double Salary { get; set; }
    }
}
