using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicTrade.Core.DataAccess
{
    public interface IDataAccess<T>
    {
        List<T> List();  // tüm tabloyu List olarak döner

        IQueryable<T> IQ_List(Expression<Func<T, bool>> where); //Linq sorgusuna ORDER BY gibi ekstra yapılar eklememizi saglar.

        IQueryable<T> ListQueryable();

        List<T> List(Expression<Func<T, bool>> where); //bir Linq sorgusu yaparak sorgu sonucunun List halinde döner

        int Insert(T obj);  // Ornegin bir Category gonderince Category yi Comment gönderince Comment i vs insert etmeli bu yüzden tipi generic olmalı.

        int Update(T obj);

        int Delete(T obj);

        int Save();    // Save metodu int döner kaç kayıt etkilendiyse onun adedini döner

        T Find(Expression<Func<T, bool>> where);

    }
}
