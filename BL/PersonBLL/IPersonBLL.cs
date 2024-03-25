using BL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.PersonBLL
{
    public  interface IPersonBLL
    {
        Task<PersonDTO> GetPerson(string EmailAddress);
        Task<string> InsertPerson(PersonDTO person);

        Task<bool> UpdatePerson(PersonDTO person);
    }
}
