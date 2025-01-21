using GN3BackEnd.Interfaces;
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
        private readonly ICrud<cat_departments> _cat_departments;

        private DepartmentsController (ICrud<cat_departments> cat_departments)
        {
            _cat_departments = cat_departments;
        }

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
                return await _cat_departments.Create(objtDepartment);
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
                return await _cat_departments.Read();
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
                return await _cat_departments.Update(objtDepartment);
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
                return await _cat_departments.Delete(Obj.DepaId);
                
            }
            catch
            {
                return null;
            }
        }
    }
}
