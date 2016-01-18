using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_StringLength_Attribute
{

    public class Employee
    {
        public int EmployeeID { get; set; }
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50,MinimumLength=10)]
        public string Address { get; set; }

        [StringLength(50, MinimumLength = 10,ErrorMessage="Remark must have min lenght of 10 and max Length of 50")]
        public string Remarks { get; set; }

    }




}
