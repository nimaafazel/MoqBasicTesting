using MVC5_Testing_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC5_Testing_1.ModelAccess
{
    /// <summary>
    /// Interface to provide functionality for Department Data Access
    /// </summary>
    public interface IDepartmentAccess
    {
        List<Department> GetDepartments();
        Department GetDepartment(int id);
        void CreateDepartment(Department dept);
        bool CheckDepartmentExists(int id);
    }

    /// <summary>
    /// The Department Data Access
    /// </summary>
    public class DepartmentAccess : IDepartmentAccess
    {
        CompanyEntities ctx;

        public DepartmentAccess()
        {
            ctx = new CompanyEntities();
        }

        /// <summary>
        /// Gets all the Departments
        /// </summary>
        /// <returns></returns>
        public List<Department> GetDepartments()
        {
            var depts = ctx.Departments.ToList();
            return depts;
        }

        /// <summary>
        /// Gets department based on id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Department GetDepartment(int id)
        {
            //var dept = ctx.Departments.FirstOrDefault(d => d.DeptNo == id);
            var dept = ctx.Departments.Find(id);
            return dept;
        }

        /// <summary>
        /// Adds a Department to the Departments list
        /// </summary>
        /// <param name="dept"></param>
        public void CreateDepartment(Department dept)
        {
            ctx.Departments.Add(dept);
            ctx.SaveChanges();
        }

        /// <summary>
        /// Checks if the Deparment exists or not.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool CheckDepartmentExists(int id)
        {
            //var dep = ctx.Departments.FirstOrDefault(d => d.DeptNo == id);
            var dept = ctx.Departments.Find(id);
            return dept != null ? true : false;
        }

        

        

        
    }
}