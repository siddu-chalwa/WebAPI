using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientEight.Models
{
    /// <summary>
    /// class: User: getter, setter property for data variables
    /// </summary>
    public class User
    {
        public int ID { get; set; }
        public string UserID { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
    }
}
