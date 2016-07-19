using Lecture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lecture.DbLayer
{
    public class StaffManager : IStaffManager
    {

        private DataSource odb = new DataSource();
        public void Create(Models.Staff ostaffs)
        {
            odb.Staffs.Add(ostaffs);
            odb.SaveChanges();
        }

        public void update(Models.Staff ostaff)
        {
            var exisiting = Details(ostaff.StaffID);
            exisiting.FirstName = ostaff.FirstName;
            exisiting.LastName = ostaff.LastName;
            exisiting.DOB = ostaff.DOB;
            exisiting.Email = ostaff.Email;
            exisiting.Address_Line1 = ostaff.Address_Line1;
            exisiting.Address_Line2 = ostaff.Address_Line2;
            exisiting.City = ostaff.City;
            exisiting.Postcode = ostaff.Postcode;
            exisiting.Location_Work = ostaff.Location_Work;
            exisiting.Position = ostaff.Position;

            odb.SaveChanges();


        }

        public Models.Staff Details(int id)
        {
            return odb.Staffs.Where(e => e.StaffID == id).FirstOrDefault();
        }



        public void Delete(int id)
        {
            var isExisted = Details(id);


            odb.Staffs.Remove(isExisted);

            odb.SaveChanges();



        }




        public List<Models.Staff> StaffsDetails()
        {
            return odb.Staffs.ToList();
        }


        //        public void update_Publications(int id, Models.PublicationModel opublications)
        //        {


        //            var deails = Details(id);


        //            var ostaff = _dbo.Details(Convert.ToInt32(StaffId));

        //            var publication = new Publications
        //            {
        //                Image = new ImageFile { Name = fileName },
        //                Descriptions = "Test Publication",
        //                Publication_keyword = "Test",
        //                Published_Date = new DateTime(2016, 4, 26),
        //                URL_Publications = "www.test.com"
        //            };
        //            ostaff.Publications = new List<Publications>();
        //            ostaff.Publications.Add(publication);
        //           this.update(ostaff);




        //        }
        //    }









        public void update_Publications(int id, Publications opublications)
        {

            var ostaff = Details(Convert.ToInt32(id));

            ostaff.Publications = new List<Publications>();
            ostaff.Publications.Add(opublications);

            this.update(ostaff);



        }
    }
    
    
    }