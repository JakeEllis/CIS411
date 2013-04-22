using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Collections.Generic;

namespace Playlister.dal.Repositories
{
    interface IRepository<T>
    {
        T getById(T playlisterObject);
        T[] getAll();
        void add(T playlisterObject);
        void update(T playlisterObject);
        void remove(T playlisterObject);
        IQueryable<T> query(Expression<Func<T, bool>> filter);
    }
}