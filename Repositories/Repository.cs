using EmployeeApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeApi.Repositories
{
    public class Repository : IRepository
    {
        public List<Employee> employees = new List<Employee>();

        public Repository()
        {
            Add(new Employee { FName = "DIleep", LName = "Reddy", Email = "Dileep@gmail.com" });
            Add(new Employee { FName = "Bharath", LName = "Kumar", Email = "Bharath@gmail.com" });
        }
        private int _index = 1;
        public void AddEmployee(Employee employee)
        {
            Add(employee);
        }

        public string Delete(int id)
        {
            employees.RemoveAll(x => x.Id == id);
            return "Deleted successfully";
        }

        public IEnumerable<Employee> Get()
        {
            return employees;
        }

        public Employee GetEmployee(int id)
        {
            return employees.Where(x => x.Id == id).FirstOrDefault();
        }

        public bool Put(int id,Employee emps)
        {
            var item = employees.Where(x => x.Id == id).FirstOrDefault();
            if (item == null)
            {
                throw new ArgumentNullException("throw");
            }
            int index = employees.FindIndex(x => x.Id == id);
            if (index == -1)
            {
                throw new ArgumentNullException("throw");
            }
            employees.RemoveAt(index);
            employees.Add(emps);
            return true;
        }
        public Employee Add(Employee item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("Item");
            }
            item.Id = _index++;
            employees.Add(item);
            return item;
        }
    }
}
