using System.Collections.Generic;
using System.Threading.Tasks;

namespace GN3BackEnd.Interfaces
{
    public interface ICrud<T>
    {
        public Task<List<T>> Create(T Obj);
        public Task<List<T>> Read();
        public Task<List<T>> Update(T Obj);
        public Task<List<T>> Delete(int Id);
    }
}
