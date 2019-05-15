using ElectronicTrade.DataAccessLayer.EntityFramework;
using ElectronicTrade.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicTrade.BusinessLayer
{
    public class Testing
    {
       public void testing_method()
        {
            DatabaseContext db = new DatabaseContext();
            db.db_localization.ToList();
        }
    }
}
