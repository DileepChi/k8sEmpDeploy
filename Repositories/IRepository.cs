using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeApi.Models;

namespace EmployeeApi.Repositories
{
    public interface IRepository
    {
        public IEnumerable<Employee> Get();
        public Employee GetEmployee(int id);
        public bool Put(int id,Employee emps);
        public void AddEmployee(Employee employee);
        public string Delete(int id);
    }
}
