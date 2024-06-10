using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseERP.Core.Models
{
    public class Group : BaseModel
    {
        public string Name { get; set; }
        public static string Code(string Name, int Id)
        {
            return Name.ToUpper().Substring(0, 2) + Id;
        }
    }
}
