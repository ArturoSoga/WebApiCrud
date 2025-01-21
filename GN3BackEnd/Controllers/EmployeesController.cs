using GN3BackEnd.Interfaces;
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
        private readonly ICrud<employees> Employesprovider;

        private EmployeesController(ICrud<employees> employesprovider)
        {
            Employesprovider = employesprovider;
        }


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
                return await Employesprovider.Create(objtDepartment);
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
                return await Employesprovider.Read();
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
        public async Task<IEnumerable<employees>> UpdateEmployeeAsync([FromBody] employees objtEmployees)
        {
            try
            {
                return await Employesprovider.Update(objtEmployees);
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
        [HttpPost]
        [Route("DeleteEmployee")]
        public async Task<IEnumerable<employees>> DeleteEmployeeAsync([FromBody] cat_departments objtDepartment)
        {
            try
            {
                return await Employesprovider.Delete(objtDepartment.DepaId);
            }
            catch
            {
                return null;
            }
        }
    }
}
