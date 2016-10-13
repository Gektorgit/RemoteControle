using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RemoteControleClient.Repository
{
    public interface ISimpleRepository<T>
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        void Save(T obj);
        void Create(T obj);
        void Delete(T obj);
    }
}
