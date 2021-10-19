using AngularWebApi.Infra.Abstraction;
using AngularWebApi.Model;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularWebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [EnableCors("MyCorsPolicy")]
    public class EmpController : ControllerBase
    {
        private readonly IEmployeeRepositery employeeRepositery;

        public EmpController(IEmployeeRepositery _employeeRepositery)
        {
            employeeRepositery = _employeeRepositery;
        }

       [HttpGet]
        public async Task<ActionResult<List<Employee>>> Get()
        {
            var employees=await employeeRepositery.GetListAsync();
            return Ok(employees);   

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Employee>> Get(int id)
        {
            var employee=await employeeRepositery.GetIdAsync(id);
            return Ok(employee);
        }

        [HttpPost]
        public ActionResult<Employee> Post(Employee employee)
        {
            var employee1=employeeRepositery.AddData(employee);
            return Ok(employee1);
        }

        [HttpPut]
        public ActionResult<Employee> Put(Employee employee)
        {
            var employee1 = employeeRepositery.UpdateData(employee);
            return Ok(employee1);
        }


        [HttpDelete("{id}")]
        public ActionResult<Employee> Delete(int id)
        {
            var employee1 = employeeRepositery.DeleteData(id);
            return Ok(employee1);
        }
    }
}
