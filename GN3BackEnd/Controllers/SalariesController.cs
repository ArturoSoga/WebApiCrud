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
    public class SalariesController : ControllerBase
    {
        private readonly ICrud<salaries> _salariesRepository;

        private SalariesController (ICrud<salaries> salariesRepository) {
            _salariesRepository = salariesRepository;
        }
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
                return await _salariesRepository.Create(ObjSalaries);
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
                return await _salariesRepository.Read();
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
                return await _salariesRepository.Update(ObjSalaries);
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
        [Route("DeleteSalaries")]
        public async Task<IEnumerable<salaries>> DeleteSalariesAsync([FromBody] salaries ObjSalaries)
        {
            try
            {
                return await _salariesRepository.Delete(ObjSalaries.SalaId);
            }
            catch
            {
                return null;
            }
        }
    }
}
