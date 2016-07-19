using Lecture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture.DbLayer
{
    public interface IStaffManager
    {


        void Create(Staff ostaffs);

        void update(Staff ostaff);



         Staff Details(int id);



         void Delete(int id);

         List<Staff> StaffsDetails();


         void update_Publications(int id, Publications opublications);


    }
}
