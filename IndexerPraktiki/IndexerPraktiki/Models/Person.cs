using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerPraktiki.Models
{
    public class Person : BaseEntity
    {
        public string FullName { get; set; }
        public int Age { get; set; }
    }
}
