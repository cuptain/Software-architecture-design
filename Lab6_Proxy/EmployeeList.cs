using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace Lab6_Proxy
{
    public class EmployeesList : IEmployeesLoader
    {
        private Employee[] _employees;

        public EmployeesList()
        {
            LoadDataFromXml();
        }

        private void LoadDataFromXml()
        {
            XmlSerializer xml = new XmlSerializer(typeof(Employee[]));
            using (FileStream reader = new FileStream("emp.xml", FileMode.Open))
            {
                _employees = (Employee[])xml.Deserialize(reader);
            }
        }

        public Employee GetEmployee(int id)
        {
            return _employees?.FirstOrDefault(x => x.Id == id);
        }

        public int GetEmployeesCount()
        {
            return _employees.Length;
        }

        public Employee[] GetEmployees()
        {
            return _employees;
        }
    }
}