
using AngularWebApi.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularWebApi.Infra.Abstraction
{
    public interface IEmployeeRepositery
    {
        Task<IReadOnlyList<Employee>> GetListAsync();
        Task<Employee> GetIdAsync(int id);
        Employee AddData(Employee employee);
        Employee UpdateData(Employee employee); 
        Employee DeleteData(int id);
       
    }
}
