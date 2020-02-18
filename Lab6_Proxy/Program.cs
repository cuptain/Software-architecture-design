using System;
using System.Linq;

namespace Lab6_Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Proxy proxy = new Proxy(true);
            int count = GetEmployeesCount(proxy);
            string[] phoneNumbers = GetPhoneNumbers(proxy);
            Employee e1 = GetEmployee(proxy, 3);
            Employee e2 = GetEmployee(proxy, 15);
            proxy.ChangeAccess(false);
            Employee e3 = GetEmployee(proxy, 40);
            Console.ReadKey();
        }

        private static int GetEmployeesCount(Proxy proxy)
        {
            return proxy.GetEmployeesCount();
        }

        private static string[] GetPhoneNumbers(Proxy proxy)
        {
            Employee[] employees = proxy.GetEmployees();
            string[] phoneNumbers = employees.Select(x => x.PhoneNumber).ToArray();
            return phoneNumbers;
        }

        private static Employee GetEmployee(Proxy proxy, int id)
        {
            Employee employee = proxy.GetEmployee(id);
            return employee;
        }
    }
}
