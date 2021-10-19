using AngularWebApi.Infra.Abstraction;
using AngularWebApi.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularWebApi.Infra.Implementations
{
    public class EmployeeRepositery : IEmployeeRepositery
    {
        private readonly DatabaseContext context;

        public EmployeeRepositery(DatabaseContext _context)
        {
            context = _context;
        }
        public async Task<IReadOnlyList<Employee>> GetListAsync()
        {
            return await context.Employees.ToListAsync();
        }

        public async Task<Employee> GetIdAsync(int id)
        {
            return await context.Employees.FindAsync(id);
        }

        public Employee AddData(Employee employee)
        {
            context.Employees.Add(employee);
            context.SaveChanges();
            return employee;
        }
        public Employee UpdateData(Employee employee)
        {
            var employeeInDb = context.Employees.FirstOrDefault<Employee>(a => a.id == employee.id);
            employeeInDb.name = employee.name;
            employeeInDb.email = employee.email;
            employeeInDb.password = employee.password;
            context.SaveChanges();
            return employee;
        }
        public Employee DeleteData(int id)
        {
            var employeeInDb = context.Employees.FirstOrDefault<Employee>(a => a.id == id);
            context.Remove<Employee>(employeeInDb);
            context.SaveChanges();
            return employeeInDb;
        }
    }
}
