using System;

namespace Product
{
    public abstract class EmployeeEntity
    {
        public abstract Guid Id { get; set; }
        public abstract string FirstName { get; set; }
        public abstract string LastName { get; set; }
        public abstract DateTime StartDate { get; set; }
        public abstract DateTime EndDate { get; set; }
        public abstract Double Salary { get; set; }
    }
}
