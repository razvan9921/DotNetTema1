using System;

namespace Product
{
    public class ManagerLogic
    {
        private ManagerEntity _manager;

        public ManagerLogic(ManagerEntity manager)
        {
            _manager = manager ?? throw new ArgumentNullException(nameof(manager));
        }

        public string GetFullName()
        {
            return _manager.FirstName + " " + _manager.LastName;
        }

        public bool isActive()
        {
            var isActive = (_manager.EndDate > _manager.StartDate) ? true : false;

            return isActive;
        }

    }
}