using DAL.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.PersonDAL
{
    public class PersonDAL : IPersonDAL
    {
        private readonly DatabaseContext _databaseContext;
        public PersonDAL(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task<Person> GetPerson(string EmailAddress)
        {
            return await _databaseContext.Person.FirstOrDefaultAsync(x => x.EmailAddress == EmailAddress);
        }

        public async Task InsertPerson(Person person)
        {
            _databaseContext.Person.Add(person);
           await  _databaseContext.SaveChangesAsync();
        }

        public async Task<bool> UpdatePerson(Person person)
        {
            var personFound = await  _databaseContext.Person.FirstOrDefaultAsync(x => x.EmailAddress == person.EmailAddress);
            if (personFound != null)
            { 
             personFound.Cellphone1 = person.Cellphone1;
             personFound.Cellphone2 = person.Cellphone2;
             personFound.Picture = person.Picture;
             personFound.Role = person.Role;
               await _databaseContext.SaveChangesAsync();
            }
            return personFound != null;
        }
    }
}
