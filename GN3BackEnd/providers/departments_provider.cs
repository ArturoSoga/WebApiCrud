using GN3BackEnd.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GN3BackEnd.providers
{
    public class departments_provider
    {
        public async Task<List<cat_departments>> CreateDepartment(cat_departments objtDepartment)
        {
            List<cat_departments> listDepartments = new();
            using (DataBaseContext db = new())
            {
                try {
                    await db.cat_departments.AddAsync(objtDepartment);
                    db.SaveChanges();
                    listDepartments.Add(objtDepartment);

                    return listDepartments;
                }
                catch{
                    //catch exception
                    return null;
                }
            }
        }
        public async Task<List<cat_departments>> ReadDepartment()
        {
            List<cat_departments> listDepartments = new();
            using (DataBaseContext db = new())
            {
                listDepartments = await (from d in db.cat_departments select new cat_departments()
                {
                    DepaActive = d.DepaActive,
                    DepaDescripcion = d.DepaDescripcion,
                    DepaId = d.DepaId,
                }).ToListAsync();
            }
            return listDepartments;
        }
        public async Task<List<cat_departments>> UpdateDepartment(cat_departments objtDepartment)
        {
            List<cat_departments> listDepartments = new();
            using (DataBaseContext db = new())
            {
                try
                {
                    db.cat_departments.Update(objtDepartment);
                    await db.SaveChangesAsync();
                    listDepartments.Add(objtDepartment);

                    return listDepartments;
                }
                catch
                {
                    //catch exception
                    return null;
                }
            }
        }
        public async Task<List<cat_departments>> DeleteDepartment(int IdDepartment)
        {
            List<cat_departments> listDepartments = new();
            using (DataBaseContext db = new())
            {
                try
                {
                    cat_departments department = await (from d in db.cat_departments
                                                 select new cat_departments()
                                                 {
                                                     DepaActive = false,
                                                     DepaDescripcion = d.DepaDescripcion,
                                                     DepaId = d.DepaId,
                                                 }).Where(i => i.DepaId == IdDepartment).FirstOrDefaultAsync();

                    db.Update(department);
                    db.SaveChanges();
                    return listDepartments;
                }
                catch
                {
                    //catch exception
                    return null;
                }
            }
        }
    }
}
