using ADO_Entity_DIff_of_Inhert_and_Compo.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ADO_Entity_DIff_of_Inhert_and_Compo.Controllers
{
    public class ADODotNetController : Controller
    {
        public ActionResult Index()
        {
            //DataAccessLayer repo = new DataAccessLayer();
            //DataTable dt = repo.Selectalldata();
            return View();
        }
        // GET: ADODotNet
        [HttpGet]
        public ActionResult InsertPerson()
        {
            return View();
        }
        [HttpPost]
        public ActionResult InsertPerson(PersonModel person)
        {
            person.BusinessEntityID = Convert.ToInt32(person.BusinessEntityID);
            if (ModelState.IsValid)
            {
                DataAccessLayer objDB = new DataAccessLayer();
                string result = objDB.InsertData(person);
                ViewData["result"] = result;
                ModelState.Clear();
                return View();
            }
            else
            {
                ModelState.AddModelError("", "Error in saving data");
                return View();
            } 
        }

        [HttpGet]
        public ActionResult ShowAllPersonDetail()
        {
           PersonModel objPerson = new PersonModel();
            DataAccessLayer objDB = new DataAccessLayer(); //calling class DBdata
            objPerson.ShowallPerson = objDB.Selectalldata();
            return View(objPerson);

        }

        [HttpGet]
        public ActionResult Edit(string ID)
        {
            PersonModel objperson = new PersonModel();
            DataAccessLayer objDB = new DataAccessLayer(); //calling class DBdata
            return View(objDB.SelectDataByID(ID));
        }

        [HttpPost]
        public ActionResult Edit(PersonModel objperson)
        {
            objperson.BusinessEntityID = Convert.ToInt32(objperson.BusinessEntityID);
            if (ModelState.IsValid)
            {
                DataAccessLayer objDB = new DataAccessLayer();
                string result = objDB.UpdateData(objperson);
                ViewData["result"] = result;
                ModelState.Clear();
                return View();
            }
            else
            {
                ModelState.AddModelError("", "Error in Saving data");
                return View();
            }
        }

        [HttpGet]
        public ActionResult Delete(string ID)
        {
            PersonModel objperson = new PersonModel();
            DataAccessLayer objDB = new DataAccessLayer();
            return View(objDB.SelectDataByID(ID));
        }

        [HttpPost]
        public ActionResult Delete(PersonModel objperson)
        {
            DataAccessLayer objDB = new DataAccessLayer();
            string result = objDB.DeleteData(objperson);
            ViewData["result"] = result;
            ModelState.Clear();
            return View();
        }
    }
}