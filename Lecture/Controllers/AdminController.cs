using Lecture.DbLayer;
using Lecture.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lecture.Controllers
{
    [Authorize(Roles="Admin")]

    public class AdminController : Controller
    {
        const string ImageDirectory = "~/UploadedImages/";
        IStaffManager _dbo;

        public AdminController()
        {
            _dbo = new StaffManager();
        }
        public ActionResult Index() {

            var details = _dbo.StaffsDetails();

            return View(details);
        
        }

        public ActionResult Create() {



            return View();
        
        }

        [HttpPost]
        public ActionResult Create(Staff ostaff )
       {
            try
            {
                if (!ModelState.IsValid) 
                    return View();
                _dbo.Create(ostaff);

                return RedirectToAction("Index");
            }
            catch 
            {
                return View();
            }
        }

        int test ;
        public ActionResult Upload(int Id)
        {
            TempData.Add("StaffId", Id);
            return View();
        }

        [HttpPost]
        public ActionResult UploadFile(string StaffId , PublicationModel op)
        {
            var fileName = "";
            if (Request.Files != null)
            {
                foreach (string file in Request.Files)
                {
                    var postedFile = Request.Files[file];
                    fileName = Path.GetFileName(postedFile.FileName);
                    postedFile.SaveAs(Server.MapPath(ImageDirectory) + fileName);
                }
            }
            var ostaff = _dbo.Details(Convert.ToInt32(StaffId));

            var publication = new Publications
            {
                Image = new ImageFile { Name = fileName },
                Descriptions = op.Descriptions,
                Publication_keyword = op.Publication_keyword,
                Published_Date = op.Published_Date,
                URL_Publications = "www.test.com"
            };
            ostaff.Publications = new List<Publications>();
            ostaff.Publications.Add(publication);
            _dbo.update(ostaff);
            return RedirectToAction("Index");
            
            //return RedirectToAction("Create", "Publication", new )
        }

        //[HttpPost]
        //public JsonResult Delete(int id) {
        //    try
        //    {

        //        _dbo.Delete(id);

        //        var data = _dbo.StaffsDetails();

        //        return Json("deleted", JsonRequestBehavior.AllowGet);
        //    }
        //    catch
        //    {
        //        return Json("Errors occurred", JsonRequestBehavior.AllowGet);
        //    }
        
        //}


        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {

                _dbo.Delete(id);

                var data = _dbo.StaffsDetails();

                return View(data);
            }
            catch
            {
                return View();
            }

        }







        public ActionResult Edit(int id) {

            var load_data = _dbo.Details(id);





            return View(load_data);
        }


        [HttpPost]
        public ActionResult Edit(Staff ostaff ) {

            _dbo.update(ostaff);

            return RedirectToAction("Index");
        
        }



    }
}