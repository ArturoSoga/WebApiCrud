using GN3BackEnd.Interfaces;
using GN3BackEnd.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GN3BackEnd.providers
{
    public class salaries_provider : ICrud<salaries>
    {
        public async Task<List<salaries>> Create(salaries ObjSalaries)
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
        public async Task<List<salaries>> Read()
        {
            List<salaries> Salaries = new List<salaries>();
            using (DataBaseContext db = new DataBaseContext())
            {
                Salaries = await db.salaries.ToListAsync();
            }
            return Salaries;
        }

        public async Task<List<salaries>> Update(salaries ObjSalaries)
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
        public async Task<List<salaries>> Delete(int Id)
        {
            return null;
        }
    }
}