using IndexerPraktiki.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerPraktiki.Service.Interface
{
    public interface IPersonService
    {
        Person GetById(int? id);
    }
}
