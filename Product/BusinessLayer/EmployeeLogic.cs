using System;

namespace Product
{
    public class EmployeeLogic
    {
        private EmployeeEntity _employee;

        public EmployeeLogic(EmployeeEntity employee)
        {
            _employee = employee ?? throw new ArgumentNullException(nameof(employee));
        }

        public string GetFullName()
        {
            return _employee.FirstName + " " + _employee.LastName;
        }

        public bool isActive()
        {
            var isActive = (_employee.EndDate > DateTime.Today) ? true : false;
            
            return isActive;
        }

    }
}