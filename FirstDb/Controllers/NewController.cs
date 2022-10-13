using FirstDb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstDb.Controllers
{
    public class NewController : Controller
    {
        // GET: New
        public ActionResult Index()
        {
            return View();
        }
        //view
        public ActionResult EmpView()
        {
            return View();
        }

        //method
        public ActionResult Insert(Emps emp)
        {
            using (var entity = new PriyaEntities3()) {
                stud empinfo = new stud();
                empinfo.Emp_Id = emp.EmpId;
                empinfo.Emp_Name = emp.EmpName;
                empinfo.Emp_Age=emp.EmpAge;
                entity.studs.Add(empinfo);
                entity.SaveChanges();

            }
               
                return View();
        }
    }
}