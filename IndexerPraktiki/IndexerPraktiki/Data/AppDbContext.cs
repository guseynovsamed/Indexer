using IndexerPraktiki.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerPraktiki.Data
{
    public class AppDbContext
    {
        public Person[] People()
        {
            return new Person[]
            {
                new Person
                {
                    Id = 1, FullName = "Meryem Aliyeva " , Age = 23 ,
                },
                new Person
                {
                    Id = 2, FullName = " Semed Huseynov " , Age = 27 ,
                },
                new Person
                {
                    Id = 3 , FullName = "Tunzale Memmedova " , Age = 23 ,
                }
            };
        } 
    }
}
