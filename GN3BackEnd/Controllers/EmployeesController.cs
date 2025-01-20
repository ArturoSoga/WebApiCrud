using GN3BackEnd.Models;
using GN3BackEnd.providers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GN3BackEnd.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeesController : ControllerBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="objtDepartment"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("CreateEmployee")]
        public async Task<IEnumerable<employees>> CreateEmployeeAsync([FromBody] employees objtDepartment)
        {
            try
            {
                employees_provider provEmployees = new();
                return (IEnumerable<employees>)await provEmployees.CreateEmployees(objtDepartment);
            }
            catch
            {
                return null;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="objtDepartment"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("ReadEmployee")]
        public async Task<IEnumerable<employees>> ReadEmployeeAsync()
        {
            try
            {
                employees_provider provEmployee = new();
                return await provEmployee.ReadEmployees();
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="objtEmployees"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("UpdateEmployee")]
        public async Task<IEnumerable<cat_departments>> UpdateEmployeeAsync([FromBody] employees objtEmployees)
        {
            try
            {
                employees_provider provEmployees = new();
                return (IEnumerable<cat_departments>)await provEmployees.UpdateEmployees(objtEmployees);
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// En realidad no es necesario ya en este caso espceifico la eliminacion es un simple update a una columna logica en una sola tabla 
        /// comento la definicion por requerimiento pero no hay implementacion
        /// </summary>
        /// <param name="objtDepartment"></param>
        /// <returns></returns>
        //[HttpPost]
        //[Route("DeleteEmployee")]
        //public async Task<IEnumerable<cat_departments>> DeleteEmployeeAsync([FromBody] cat_departments objtDepartment)
        //{
        //    try
        //    {
        //        employees_provider provEmployees = new();
        //        //return (IEnumerable<cat_departments>)await provEmployees.DeleteEmployees();
        //    }
        //    catch
        //    {
        //        return null;
        //    }
        //}
    }
}
