using System;
using System.Collections.Generic;
using EmployeeRecord.Interface;
using EmployeeRecord.Models;

namespace EmployeeRecord.Repo
{

    public class EmployeeRepo : Base<Employee>, IEmployeeRepo
    {

        public EmployeeRepo(ApplicationDbContext dbContext) : base(dbContext)
        {

        }

        public Employee SaveEmployee(Employee employee)
        {
            try
            {               
                var data = Insert(employee);
                return data;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void UpdateEmployee(Employee employee)
        {
            try
            {

                Update(employee);

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeleteEmployee(Employee employee)
        {
            try
            {

                Delete(employee.Id);

            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<Employee> GetEmployee(Employee employee)
        {
            try
            {
                var data = GetAll();
                return data;

            }
            catch (Exception)
            {

                throw;
            }
        }      

        public Employee FindEmployeeById(long id)
        {
            try
            {
                var data = GetById(id);
                return data;
            }
            catch (Exception)
            {

                throw;
            }
        }       

       
        public void Dispose()
        {

        }


    }
}
