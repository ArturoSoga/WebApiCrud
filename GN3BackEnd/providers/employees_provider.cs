﻿using GN3BackEnd.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GN3BackEnd.providers
{
    public class employees_provider
    {
        public async Task<List<employees>> CreateEmployees(employees objtEmployees)
        {
            List<employees> listEmployees = new();
            using (DataBaseContext db = new())
            {
                try
                {
                    await db.employees.AddAsync(objtEmployees);
                    db.SaveChanges();
                    listEmployees.Add(objtEmployees);

                    return listEmployees;
                }
                catch
                {
                    //catch exception, por ahora no hay implementacion
                    return null;
                }
            }
        }
        public async Task<List<employees>> ReadEmployees()
        {
            List<employees> listEmployees = new();
            using (DataBaseContext db = new())
            {
                listEmployees =await db.employees.ToListAsync();
            }
            return listEmployees;
        }
        public async Task<List<employees>> UpdateEmployees(employees ObjEmployes)
        {
            List<employees> listEmployees = new();
            using (DataBaseContext db = new())
            {
                try
                {
                    db.employees.Update(ObjEmployes);
                    await db.SaveChangesAsync();
                    listEmployees.Add(ObjEmployes);

                    return listEmployees;
                }
                catch
                {
                    //catch exception
                    return null;
                }
            }
        }


        //No es necesario por la eliminacion logico
        //public async Task<List<employees>> DeleteEmployees()
        //{
        //    return null;
        //}
    }
}
