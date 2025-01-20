using GN3BackEnd.Models;
using GN3BackEnd.providers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace GN3BackEnd.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DepartmentsController : ControllerBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="objtDepartment"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("CreateDepartament")]
        public async Task<IEnumerable<cat_departments>> CreateDepartamentAsync([FromBody] cat_departments objtDepartment)
        {
            try
            {
                departments_provider provDepartment = new();
                return await provDepartment.CreateDepartment(objtDepartment);
            }
            catch
            {
                return null;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("ReadDepartament")]
        public async Task<IEnumerable<cat_departments>> ReadDepartamentAsync()
        {
            try
            {
                departments_provider provDepartment = new();
                return await provDepartment.ReadDepartment();
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
        [HttpPost]
        [Route("UpdateDepartament")]
        public async Task<IEnumerable<cat_departments>> UpdateDepartamentAsync([FromBody] cat_departments objtDepartment)
        {
            try
            {

                departments_provider provDepartment = new();
                return await provDepartment.UpdateDepartment(objtDepartment);
            }
            catch
            {
                return null;
            }
        }
        //Tecnicamente es una actualizacion que se hace en Update al parametro boolean "DepaActive" , por requerimiento del ejercicio lo pongo separado 
        /// <summary>
        /// 
        /// </summary>
        /// <param name="objtDepartment"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("DeleteDepartament")]
        public async Task<IEnumerable<cat_departments>> DeleteDepartamentAsync([FromBody] cat_departments Obj)
        {
            try
            {
                departments_provider provDepartment = new();
                return await provDepartment.DeleteDepartment(Obj.DepaId);
                
            }
            catch
            {
                return null;
            }
        }
    }
}
