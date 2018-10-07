//NOT NECESSARY BECAUSE I MADE UP THE EMPLOYEELOGIC WICH DOES THE SAME THING
//NOW IT IS NECESSARY BECAUSE OF THE EMPLOYEE ABSTRACTION

using System;

namespace Product
{
    public class ArchitectLogic
    {
        private ArchitectEntity _architect;

        public ArchitectLogic(ArchitectEntity architect)
        {
            _architect = architect ?? throw new ArgumentNullException(nameof(architect));
        }

        public string GetFullName()
        {
            return _architect.FirstName + " " + _architect.LastName;
        }

        public bool isActive()
        {
            var isActive = (_architect.EndDate > DateTime.Today) ? true : false;

            return isActive;
        }

    }
}