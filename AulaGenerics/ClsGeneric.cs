using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoTreinaWeb
{
    class ClsGeneric<T>
    {
        private List<T> lista;

        public ClsGeneric()
        {
            lista = new List<T>();
        }
        public List<T> GetList()
        {
            return lista;
        }
        public void InsertList(T obj)
        {
            lista.Add(obj);
        }
    }
}
