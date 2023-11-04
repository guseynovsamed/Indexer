using Indexer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    public class DataList <T> where T : BaseEntity
    {
        
        private T[] _dataList;

        public DataList()
        {
            _dataList = new T[0];
        }

        public void Add(T item)
        {
            Array.Resize(ref _dataList, _dataList.Length+1);
            _dataList[_dataList.Length-1] = item;
        }

        public T GetById(int id)
        {
            return _dataList.FirstOrDefault(x => x.Id == id);
        }



        public T[] Remove(int id)
        {
            return _dataList.Where(n => n.Id != id).ToArray(); 
        }
    }
}
