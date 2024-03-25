using DAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.PersonDAL
{
    public  interface IPersonDAL
    {
        Task<Person> GetPerson(string EmailAddress);
        Task InsertPerson(Person person);

         Task<bool> UpdatePerson(Person person);
    }
}
