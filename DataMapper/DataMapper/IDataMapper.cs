using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMapper
{
    public interface IDataMapper <T>
    {
        void Create(T obj);
        void Edit(int key, T obj);
        void Delete(int key);
        T Read(int key);

    }
}
