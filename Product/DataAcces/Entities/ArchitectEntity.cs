using System;

namespace Product
{
    public class ArchitectEntity : EmployeeEntity
    {
        public override Guid Id { get; set; }
        public override string FirstName { get; set; }
        public override string LastName { get; set; }
        public override DateTime StartDate { get; set; }
        public override DateTime EndDate { get; set; }
        public override double Salary { get; set; }
    }
}
