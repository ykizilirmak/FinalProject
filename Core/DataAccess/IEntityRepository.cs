
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
                     //CORE KATMANI DİĞER KATMANLARI REFERANS ALMAZ
namespace Core.DataAccess
{                               //       t nesnesi class olacak ve entity den türemiş ve ya entity olacak ama entity istemiyoruz o yuzden newlenebilir olsun dedik
    public interface IEntityRepository<T> where T:class,IEntity,new() 
    {
        //             expression p=>p.d yani predicate ifadeleri kullanabilmek için uyguladıgımız yapı 
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T,bool>> filter = null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
