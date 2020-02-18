using System;

namespace Lab6_Proxy
{
    public class Proxy : EmployeesLoader
    {
        private EmployeesList _employeesList;

        private bool _access;
        
        public Proxy(bool access)
        {
            _access = access;
        }

        public void ChangeAccess(bool access)
        {
            _access = access;
        }

        public Employee GetEmployee(int id)
        {
            RequestStartTest();
            Employee emp = _employeesList.GetEmployee(id);
            return emp;
        }

        public int GetEmployeesCount()
        {
            RequestStartTest();
            int count = _employeesList.GetEmployeesCount();
            return count;
        }

        public Employee[] GetEmployees()
        {
            RequestStartTest();
            Employee[] employees = _employeesList.GetEmployees();
            return employees;
        }

        private void RequestStartTest()
        {
            TestAccess();
            TestEmployeeList();
        }

        private void TestEmployeeList()
        {
            if (_employeesList == null)
            {
                _employeesList = new EmployeesList();
            }
        }

        private void TestAccess()
        {
            if (!_access) { }
            throw new Exception("Нет доступа");
        }
    }
}