using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Json_Xml
{
    class Employe
    {
        public string EmployeName { get; set; }
    }
    class Department
    {
        public string DepartmentName { get; set; }
        public string EmployeName { get; set;}
        public override string ToString()
        {
            return $"Departmen Name : {DepartmentName}  Employe Name : {EmployeName}";
        }
    }
}
