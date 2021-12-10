using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeApi.Models;
using EmployeeApi.Repositories;

namespace EmployeeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        IRepository _repository = null;
        public EmployeeController(IRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
           var emp= _repository.Get();
            return emp;
        }
        [HttpGet("{id}")]
        public Employee GetEmployee(int id)
        {
            var emp = _repository.GetEmployee(id);
            return emp;
        }
        [HttpPut]
        public bool put(int id,Employee emp)
        {
            return _repository.Put(id,emp);
        }
        [HttpDelete]
        public string Delete(int id)
        {
            return _repository.Delete(id);
        }
        [HttpPost]
        public void Post(Employee emp)
        {
            _repository.AddEmployee(emp);
        }
    }
}
