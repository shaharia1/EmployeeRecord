using System;
using System.Collections.Generic;
using EmployeeRecord.Models;

namespace EmployeeRecord.Interface
{
  public interface IEmployeeRepo : IBase<Employee>, IDisposable
  {
    Employee SaveEmployee(Employee employee);

    void UpdateEmployee(Employee employee);

    void DeleteEmployee(Employee employee);

    IEnumerable<Employee> GetEmployee(Employee employee); 

    Employee FindEmployeeById(long id);
  }
 
}
