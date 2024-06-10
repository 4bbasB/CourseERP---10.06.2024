using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseERP.Core.Models
{
    public class Student : BaseModel
    {
        public string Fullname { get; set; }
        public double Grade { get; set; }
    }
}
