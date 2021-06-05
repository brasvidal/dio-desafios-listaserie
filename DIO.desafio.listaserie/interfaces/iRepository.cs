using System.Collections.Generic;
namespace DIO.desafio.listaserie.interfaces
{
    public interface iRepository<T>
    {
        List<T> ListAll();
        T returnById(int id);
        void Insert(T entity);
        void Delete(int id);
        void Update(int id, T entity);
        int NextId();
        
    }
}