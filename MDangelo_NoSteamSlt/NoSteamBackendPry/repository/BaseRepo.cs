using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoSteamBackendPry.repository
{
    public interface BaseRepo<T>
    {
        public T GetById(int id);
        public List<T> GetAll();
        public T Save(T entity);
        public T DeleteById(int id);
        public T Update(T entity);

    }
}
