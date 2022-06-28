using _14_Generic.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Generic.Repository
{
    public interface IGenericRepository<T> where T: BaseEntity
    {

        public int Add(T entity);
        public int Update(T entity);
        public int Delete(T entity);

        public T  Find(int id);
        public List<T> GelAll();
    }
}
