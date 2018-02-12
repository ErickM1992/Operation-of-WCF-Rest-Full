using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SimpleRESTServer.Models;

namespace SimpleRESTServer.Controllers
{
    public class PersonController : ApiController
    {

        List<Person> Persons = new List<Person>();
        //Definir que persona se manda.
        Person personfind = new Person();

        // GET: api/Person
        public IEnumerable<Person> Get()
        {


            Person per1 = new Person
            {
                ID = 1,
                LastName = "Moreira",
                FirstName = "Erick",
                PayRate = 254.32,
                StartDay = DateTime.Now,
                EndDay = DateTime.Now
            };



            Persons.Add(per1);

            Person per2 = new Person
            {
                ID = 2,
                LastName = "Marin",
                FirstName = "Cortez",
                PayRate = 3012.32,
                StartDay = DateTime.Now,
                EndDay = DateTime.Now
            };

            Persons.Add(per2);

            Person per3 = new Person
            {
                ID = 3,
                LastName = "Gonzales",
                FirstName = "Ronberto",
                PayRate = 145.32,
                StartDay = DateTime.Now,
                EndDay = DateTime.Now
            };

            Persons.Add(per3);


            return Persons;

           
        }

        // GET: api/Person/5
        public Person Get(int id)
        {

            Person per1 = new Person
            {
                ID = 1,
                LastName = "Moreira",
                FirstName = "Erick",
                PayRate = 254.32,
                StartDay = DateTime.Now,
                EndDay = DateTime.Now
            };



            Persons.Add(per1);

            Person per2 = new Person
            {
                ID = 2,
                LastName = "Marin",
                FirstName = "Cortez",
                PayRate = 3012.32,
                StartDay = DateTime.Now,
                EndDay = DateTime.Now
            };

            Persons.Add(per2);

            Person per3 = new Person
            {
                ID = 3,
                LastName = "Gonzales",
                FirstName = "Ronberto",
                PayRate = 145.32,
                StartDay = DateTime.Now,
                EndDay = DateTime.Now
            };

            Persons.Add(per3);

            foreach (var item in Persons)
            {
                if (item.ID == id)
                {
                    return item;
                }

            }

            return personfind;
        }

        // POST: api/Person
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Person/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Person/5
        public void Delete(int id)
        {
        }
    }
}
