using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApplicationAPI_1.Repositories
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetEmployees();
        Task<IEnumerable<Employee>> Search(string name);

        Task<Employee> GetEmployee(int Id);
        Task<Employee> AddEmployee(Employee employee);
        Task<Employee> UpdateEmployee(Employee employee);
        Task<Employee> DeleteEmployee(int Id);

    }
}