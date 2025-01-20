using GN3BackEnd.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GN3BackEnd.providers
{
    public class salaries_provider
    {
        public async Task<List<salaries>> CreateSalaries(salaries ObjSalaries)
        {
            List<salaries> ListSalaries = new();

            using (DataBaseContext db = new())
            {
                try
                {
                    await db.salaries.AddAsync(ObjSalaries);
                    db.SaveChanges();
                    ListSalaries.Add(ObjSalaries);

                    return ListSalaries;
                }catch{
                    //catch exception, por ahora no hay implementacion
                    return null;
                }
            }
        }
        public async Task<List<salaries>> ReadSalaries()
        {
            List<salaries> Salaries = new List<salaries>();
            using (DataBaseContext db = new DataBaseContext())
            {
                Salaries = await db.salaries.ToListAsync();
            }
            return Salaries;
        }

        public async Task<List<salaries>> UpdateSalaries(salaries ObjSalaries)
        {
            List<salaries> ListSalaries = new();
            using (DataBaseContext db = new())
            {
                try
                {
                    db.salaries.Update(ObjSalaries);
                    await db.SaveChangesAsync();
                    ListSalaries.Add(ObjSalaries);

                    return ListSalaries;
                }
                catch
                {
                    //catch exception
                    return null;
                }
            }
        }

        //public async Task<List<salaries>> DeleteSalaries()
        //{
        //    return null;
        //}
    }
}