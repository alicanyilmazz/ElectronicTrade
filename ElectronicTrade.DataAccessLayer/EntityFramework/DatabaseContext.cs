using ElectronicTrade.DataAccessLayer.EntityMappings;
using ElectronicTrade.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicTrade.DataAccessLayer.EntityFramework
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Address> db_address { get; set; }
        public DbSet<Category> db_category { get; set; }
        public DbSet<Comment> db_comment { get; set; }
        public DbSet<ElectronicTrade.Entities.Exception> db_exception { get; set; }
        public DbSet<Localization> db_localization { get; set; }
        public DbSet<Log> db_log { get; set; }
        public DbSet<Member> db_member { get; set; }
        public DbSet<Message> db_message { get; set; }
        public DbSet<Options> db_option { get; set; }
        public DbSet<Order> db_order { get; set; }
        public DbSet<OrderDetail> db_orderdetail { get; set; }
        public DbSet<Product> db_product { get; set; }
        public DbSet<ProductImage> db_productimage { get; set; }
        public DbSet<Role> db_role { get; set; }
        public DbSet<User_Role> db_user_role { get; set; }
        public DbSet<User> db_user { get; set; }
        

        public DatabaseContext()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DatabaseContext, ElectronicTrade.DataAccessLayer.Migrations.Configuration>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Configurations.Add(new AddressMap());
            modelBuilder.Configurations.Add(new CategoryMap());
            modelBuilder.Configurations.Add(new CommentMap());
            modelBuilder.Configurations.Add(new ExceptionMap());
            modelBuilder.Configurations.Add(new LocalizationMap());
            modelBuilder.Configurations.Add(new LogMap());
            modelBuilder.Configurations.Add(new MemberMap());
            modelBuilder.Configurations.Add(new MessageMap());
            modelBuilder.Configurations.Add(new OptionMap());
            modelBuilder.Configurations.Add(new OrderDetailMap());
            modelBuilder.Configurations.Add(new OrderMap());
            modelBuilder.Configurations.Add(new ProductImageMap());
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new RoleMap());
            modelBuilder.Configurations.Add(new User_RoleMap());
            modelBuilder.Configurations.Add(new UserMap());
           


        }
    }
}
