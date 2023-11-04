using IndexerPraktiki.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerPraktiki.Controllers
{
    internal class PersonController
    {
        private readonly IPersonService _personService;

        public PersonController()
        {
            _personService = new PersonService();
        }

        public void GetById()
        {
            try
            {

                Console.WriteLine("Add Person Id");

                int id = int.Parse(Console.ReadLine());


                var response = _personService.GetById(id);

                var result = $"{response.Id}-{response.FullName}-{response.Age}";

                Console.WriteLine(result);


            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }



        }
    }
}
