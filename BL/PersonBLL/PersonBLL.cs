using BL.DTO;
using DAL.Data;
using DAL.PersonDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.PersonBLL
{
    public class PersonBLL : IPersonBLL
    {
        private readonly IPersonDAL _personDAL;
        public PersonBLL(IPersonDAL personDAL)
        {
            _personDAL = personDAL;
        }

        public async Task<PersonDTO> GetPerson(string EmailAddress)
        {
            var personDTO = await _personDAL.GetPerson(EmailAddress);
            if (personDTO == null) return null;
            return new PersonDTO
            {
                FirstName = personDTO.FirstName,
                Surname = personDTO.Surname,
                Cellphone1 = personDTO.Cellphone1,
                Cellphone2 = personDTO.Cellphone2,
                EmailAddress = personDTO.EmailAddress,
                Title = personDTO.Title,
                Gender = personDTO.Gender,
                Age = personDTO.Age,
                Picture = personDTO.Picture
            };
        }

        public async Task<string> InsertPerson(PersonDTO person)
        {
            var message = string.Empty;
            var personAlreadyExists = await _personDAL.GetPerson(person.EmailAddress);

            if (personAlreadyExists != null)
            {
                message = "Person with the same email address aleardy exists";
                return message;
            }

            await _personDAL.InsertPerson(new Person
            {
                FirstName = person.FirstName,
                Surname = person.Surname,
                Cellphone1 = person.Cellphone1,
                Cellphone2 = person.Cellphone2,
                EmailAddress = person.EmailAddress,
                Title = person.Title,
                Gender = person.Gender,
                Age = person.Age,
                Picture = person.Picture

            });
            message = $"{person.FirstName} saved successfully";
            return message;
        }
        public async Task<bool> UpdatePerson(PersonDTO person)
        {
            Person persontoAdd = new Person()
             {
                FirstName = person.FirstName,
                Surname = person.Surname,
                Cellphone1 = person.Cellphone1,
                Cellphone2 = person.Cellphone2,
                EmailAddress = person.EmailAddress,
                Title = person.Title,
                Gender = person.Gender,
                Age = person.Age,
                Picture = person.Picture

            };
            return await _personDAL.UpdatePerson(persontoAdd);
        }
    }
}
