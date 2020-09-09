using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using NET_Framework_pratice.Models;

namespace NET_Framework_pratice.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IHttpActionResult Get()
        {
            return Ok(EmployeeDao.Employees);
        }

        // GET api/values/5
        public IHttpActionResult Get(int id)
        {
            return Ok(EmployeeDao.Employees.FirstOrDefault(x => x.EmployeeId == id));
        }
        // POST api/values
        public IHttpActionResult Post(Employee employee )
        {
            EmployeeDao.Employees.Add(employee);
            return Ok(EmployeeDao.Employees);
        }

        // PUT api/values/5
        public IHttpActionResult Put(Employee employee)
        {
            var result = EmployeeDao.Employees.FirstOrDefault(x => x.EmployeeId == employee.EmployeeId);
            if (result != null)
            {
                result.Name = employee.Name;
                result.PhoneNumber = employee.PhoneNumber;
                result.Address = employee.Address;
            }
            return Ok(EmployeeDao.Employees);
        }

        // DELETE api/values/5
        public IHttpActionResult Delete(int id)
        {
            EmployeeDao.Employees.RemoveAll(x => x.EmployeeId == id);
            return Ok(EmployeeDao.Employees);
        }
    }
}
