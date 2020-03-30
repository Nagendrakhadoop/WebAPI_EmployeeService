using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmployeeService.Controllers
{
    [Authorize]
    public class EmployeeController : ApiController
    {
        public IEnumerable<Employee> Get()
        {
            using (EmployeeDBEntities et = new EmployeeDBEntities())
            {
                return et.Employees.ToList();
            }
        }
    }
}
