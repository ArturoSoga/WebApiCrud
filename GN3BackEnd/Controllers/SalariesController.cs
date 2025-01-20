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
    public class SalariesController : ControllerBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="objtDepartment"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("CreateSalaries")]
        public async Task<IEnumerable<salaries>> CreateSalariesAsync([FromBody] salaries ObjSalaries)
        {
            try
            {
                salaries_provider provSalaries = new();
                return (IEnumerable<salaries>)await provSalaries.CreateSalaries(ObjSalaries);
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
        [Route("ReadSalaries")]
        public async Task<IEnumerable<salaries>> ReadSalariesAsync()
        {
            try
            {
                salaries_provider provSalaries = new();
                return (IEnumerable<salaries>)await provSalaries.ReadSalaries();
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
        [Route("UpdateSalaries")]
        public async Task<IEnumerable<salaries>> UpdateSalariesAsync([FromBody] salaries ObjSalaries)
        {
            try
            {
                salaries_provider provSalaries = new();
                return (IEnumerable<salaries>)await provSalaries.UpdateSalaries(ObjSalaries);
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
        //[HttpPost]
        //[Route("DeleteSalaries")]
        //public async Task<IEnumerable<salaries>> DeleteSalariesAsync([FromBody] salaries ObjSalaries)
        //{
        //    try
        //    {
        //        salaries_provider provSalaries = new();
        //        return (IEnumerable<salaries>)await provSalaries.DeleteSalaries(ObjSalaries);
        //    }
        //    catch
        //    {
        //        return null;
        //    }
        //}
    }
}
