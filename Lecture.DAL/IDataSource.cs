using Lecture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture.DbLayer
{
   public  interface IDataSource
    {

       IQueryable<Staff> Staffs { get;}
 


    }
}
