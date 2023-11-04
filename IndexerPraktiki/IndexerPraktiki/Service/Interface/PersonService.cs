using IndexerPraktiki.Data;
using IndexerPraktiki.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerPraktiki.Service.Interface
{
    internal class PersonService : IPersonService
    {
        private readonly AppDbContext _context;
        public PersonService()
        {
            _context = new AppDbContext();
        }
        public Person GetById(int? id)
        {
            if(id is null ) throw new ArgumentNullException();

            var data = _context.People().FirstOrDefault(x => x.Id == id);


            if(data is null ) throw new NullReferenceException("Data Not Found");

            return data;
        }
    }
}
