using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Cellphone1 { get; set; }
        public string Cellphone2 { get; set; }
        public string EmailAddress { get; set; }
        public string Title { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string Picture { get; set; }
        public Role Role { get; set; }
    }
}
