using System.Collections.Generic;

namespace Design_Pattern.DAO
{
    public interface DAO<T>
    {
        T get(string email);

        List<T> getAll();

        void save(T t);

        void update(T t, string name, string email);

        void delete(T t);
    }

}