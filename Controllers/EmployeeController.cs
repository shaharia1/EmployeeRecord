using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Results;
using EmployeeRecord.Interface;
using EmployeeRecord.Models;
using EmployeeRecord.Repo;

namespace EmployeeRecord.Controllers
{
    [RoutePrefix("api/employee")]
    public class EmployeeController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public EmployeeController()
        {


        }


        [HttpPost]
        [Route("SaveEmployee")]
        public JsonResult<Employee> SaveEmployee(Employee entity)
        {
            using (IEmployeeRepo employeeRepo = new EmployeeRepo(db))
            {
                try
                {
                    var data = employeeRepo.SaveEmployee(entity);
                    return Json(data);
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }


        }

        [HttpPost]
        [Route("UpdateEmployee")]
        public void UpdateEmployee(Employee entity)
        {
            using (IEmployeeRepo employeeRepo = new EmployeeRepo(db))
            {
                try
                {
                    employeeRepo.UpdateEmployee(entity);

                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }


        }

        [HttpPost]
        [Route("DeleteEmployee")]
        public void DeleteEmployee(Employee entity)
        {
            using (IEmployeeRepo employeeRepo = new EmployeeRepo(db))
            {
                try
                {
                    employeeRepo.DeleteEmployee(entity);

                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }


        }

        [HttpPost]
        [Route("GetEmployee")]
        public IEnumerable<Employee> GetEmployee(Employee filter)
        {
            try
            {
                using (IEmployeeRepo employeeRepo = new EmployeeRepo(db))
                {
                    var datas = employeeRepo.GetEmployee(filter);
                    return datas;

                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [HttpGet]
        [Route("FindEmployeeById/{id}")]
        public JsonResult<Employee> FindEmployeeById(long id)
        {
            try
            {
                using (IEmployeeRepo employeeRepo = new EmployeeRepo(db))
                {
                    var data = employeeRepo.FindEmployeeById(id);
                    return Json(data);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();

            }
            base.Dispose(disposing);
        }


    }
}
