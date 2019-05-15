using ElectronicTrade.Core.DataAccess;
using ElectronicTrade.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicTrade.DataAccessLayer.Repositories
{
    public class Repository<T> : RepositoryBase, IDataAccess<T> where T : class   // class olmak zorunda demezsek tutup int da gönderilebilir ve hata yaratır.
    {
        private DbSet<T> _objectSet;
        public Repository() // db.Set<T>(); tekrar tekrar olusturmamak icin direkt nesne olusturuldugunda ctor içerisinde bir kere değişkene atıp heryerde kullanacagız.
        {

            _objectSet = db.Set<T>();
        }

        public List<T> List()  // tüm tabloyu List olarak döner
        {
            return _objectSet.ToList();  // db nin içerisinde ilgili Set i bul onu bize List olarak dön
        }

        public IQueryable<T> IQ_List(Expression<Func<T, bool>> where) //Linq sorgusuna ORDER BY gibi ekstra yapılar eklememizi saglar.
        {
            return _objectSet.Where(where);
        }

        public IQueryable<T> ListQueryable()
        {
            return _objectSet.AsQueryable<T>();
        }


        public List<T> List(Expression<Func<T, bool>> where) //bir Linq sorgusu yaparak sorgu sonucunun List halinde döner
        {
            return _objectSet.Where(where).ToList();
        }


        public int Insert(T obj)  // Ornegin bir Category gonderince Category yi Comment gönderince Comment i vs insert etmeli bu yüzden tipi generic olmalı.
        {
            _objectSet.Add(obj);

            //if (obj is OperationBase) // Eger  MyEntityBase den kalıtım alıyorsa asagıdaki özelliklerini otomatik save edecek.
            //{
            //    OperationBase o = obj as OperationBase;
            //    DateTime now = DateTime.Now;   //Degiskene atamadan yaparsanız millisaniye cinsinden de olsa fark olusur.
            //    o.AddedDate = now;
            //    o.ModifiedDate = now;
            //    o.UserBy = App.Common.GetCurrentUserName();  // TODO : islem yapan kullanıcı adı yazılmalı

            //}

            return Save();
        }

        public int Update(T obj)
        {
            //if (obj is MyEntityBase) // Eger  MyEntityBase den kalıtım alıyorsa asagıdaki özelliklerini otomatik save edecek.
            //{
            //    MyEntityBase o = obj as MyEntityBase;

            //    o.ModifiedOn = DateTime.Now;
            //    o.ModifierUser = App.Common.GetCurrentUserName();  // TODO : islem yapan kullanıcı adı yazılmalı

            //}

            return Save();
        }

        public int Delete(T obj)
        {
            //if (obj is MyEntityBase) // Eger  MyEntityBase den kalıtım alıyorsa asagıdaki özelliklerini otomatik save edecek.
            //{
            //    MyEntityBase o = obj as MyEntityBase;
            //    DateTime now = DateTime.Now;   //Degiskene atamadan yaparsanız millisaniye cinsinden de olsa fark olusur.
            //    o.CreatedOn = now;
            //    o.ModifiedOn = now;
            //    o.ModifierUser =App.Common.GetCurrentUserName();  // TODO : islem yapan kullanıcı adı yazılmalı

            //}

            _objectSet.Remove(obj);
            return Save();
        }

        public int Save()    // Save metodu int döner kaç kayıt etkilendiyse onun adedini döner
        {
            return db.SaveChanges();
        }

        public T Find(Expression<Func<T, bool>> where)
        {
            return _objectSet.FirstOrDefault(where); // SingleOrDefault(); da kullanılabilir ama bu metot da bir tane alacagımızı garanti etmeliyiz ama.Parametre olarak kullanılan "where" yerine x=>x. seklinde Linq sorgusu geleceğine dikkat ediniz.
        }
    }
}
