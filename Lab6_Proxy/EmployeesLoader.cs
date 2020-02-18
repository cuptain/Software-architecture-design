namespace Lab6_Proxy
{
    public interface IEmployeesLoader
    {
        Employee GetEmployee(int id);

        int GetEmployeesCount();

        Employee[] GetEmployees();
    }
}