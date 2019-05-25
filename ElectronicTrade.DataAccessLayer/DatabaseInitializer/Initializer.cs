using ElectronicTrade.DataAccessLayer.EntityFramework;
using ElectronicTrade.Entities;
using ElectronicTrade.Entities.EntityEnums.BadgeType;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicTrade.DataAccessLayer.DatabaseInitializer
{
    public class Initializer: CreateDatabaseIfNotExists<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            int counter = 1;
            int messagecounter = 1;

            DateTime now = DateTime.Now;


            //----------/---------Adding Members Begin--------/------------//

            #region
            for (int i = 0; i < 6; i++)
            {
                Member members = new Member()
                {
                    //Id = i + 1,
                    Name = FakeData.NameData.GetFirstName(),
                    Surname = FakeData.NameData.GetSurname(),
                    Email = FakeData.NameData.GetSurname(),
                    Biography = "",
                    ProfileImageName = "defaultmember.jpg",
                    UserBy = "System",
                    MemberType = 11,
                    AddedDate = now,
                };

                context.db_member.Add(members);
            }

            context.SaveChanges();
            #endregion

            //-------------------Adding Members End-----------------------//


            //////After that We will use this Member list//////
            List<Member> user_list = context.db_member.ToList();


            //---------/---------Adding Categories Begin-------/----------//

            #region
            for (int i = 0; i < 3; i++)
            {

                Category rootcategory = new Category()
                {
                    //Id = counter,
                    Name = $"Root Menu {i + 1}",
                    Description = FakeData.TextData.GetSentence(),
                    ActionName = $"Index{i + 1}",
                    ControllerName = $"Home{i + 1}",
                    QueryStrings = $"Query{i + 1}",
                    OrderNumber = i + 1,
                    UserBy = "BySystem",
                    ParentCategory = null,
                    AddedDate = now,


                };

                context.db_category.Add(rootcategory);

                counter++;

            }

            context.SaveChanges();
            #endregion

            //------------------Adding Categories End---------------------//


            //////After that We will use this Category list////////////
            List<Category> rootcategory_list = context.db_category.Where(x => x.ParentCategory == null).ToList();


            //--------/----------Adding Sub Categories Begin---/----------//

            #region
            foreach (Category rootcategory in rootcategory_list)
            {

                for (int i = 0; i < 1; i++)
                {

                    Category subcategory = new Category()
                    {
                        //Id = counter,
                        Name = $"Sub Menu {i + 1}",
                        Description = FakeData.TextData.GetSentence(),
                        ActionName = $"Sub Index{i + 1}",
                        ControllerName = $"Sub Home{i + 1}",
                        QueryStrings = $"Sub Query{i + 1}",
                        OrderNumber = i + 1,
                        UserBy = "BySystem",
                        ParentCategory = rootcategory,
                        AddedDate = now

                    };

                    context.db_category.Add(subcategory);

                    counter++;
                }
            }

            context.SaveChanges();
            #endregion

            //------------------Adding Sub Categories End-----------------//


            //////After that We will use this Category list////////////
            List<Category> subcategory_list = context.db_category.Where(x => x.ParentCategory != null).ToList();


            //---------/---------Adding Sub sub Categories Begin-----/----//

            #region
            foreach (Category subcategory in subcategory_list)
            {
                for (int i = 0; i < 1; i++)
                {
                    Category subsubcategory = new Category()
                    {
                        //Id =counter,
                        Name = $"Sub sub Menu {i + 1}",
                        Description = FakeData.TextData.GetSentence(),
                        ActionName = $"Sub sub Index{i + 1}",
                        ControllerName = $"Sub sub Home{i + 1}",
                        QueryStrings = $"Sub sub Query{i + 1}",
                        OrderNumber = i + 1,
                        UserBy = "BySystem",
                        ParentCategory = subcategory,
                        AddedDate = now
                    };

                    context.db_category.Add(subsubcategory);

                    counter++;
                }
            }

            context.SaveChanges();
            #endregion

            //------------------Adding Sub sub Categories End-------------//


            //////After that We will use this Category list////////////
            List<Category> category_list = context.db_category.ToList();


            //-------/-----------Adding Products Begin------------/-------//

            #region
            for (int i = 0; i < category_list.Count; i++)
            {
                Category product_category = category_list[FakeData.NumberData.GetNumber(0, category_list.Count - 1)];

                Product products = new Product()
                {
                    //Id = i + 1,
                    Name = $"ProductName{i}",
                    Description = FakeData.TextData.GetSentence(),
                    Price = FakeData.NumberData.GetNumber(1, 60),
                    StarPoint = FakeData.NumberData.GetNumber(5, 65),
                    StockStatus = "In Stock",
                    UnitInStock = FakeData.NumberData.GetNumber(5, 70),
                    StarGivenMemberCount = FakeData.NumberData.GetNumber(2, 25),
                    Discount = FakeData.NumberData.GetNumber(3, 45),
                    UserBy = "BySystem",
                    AddedDate = now,
                    BadgeType=ReturnBadge(i),
                    category = product_category

                };

                context.db_product.Add(products);

            }

            context.SaveChanges();
            #endregion

            //------------------Adding Products End-----------------------//

            //////After that We will use this Product list////////////
            List<Product> product_list = context.db_product.ToList();


            //-------/-----------Adding ProductsImage Begin--------/------//

            #region

            for (int i = 0; i < product_list.Count; i++)
            {
                ProductImage productImage = new ProductImage()
                {
                    //Id = i + 1,
                    FirstImageName = $"partialproduct_{FakeData.NumberData.GetNumber(1, 6)}.jpg",
                    SecondImageName = $"partialproduct_{FakeData.NumberData.GetNumber(1, 6)}.jpg",
                    ThirdImageName = $"partialproduct_{FakeData.NumberData.GetNumber(1, 6)}.jpg",
                    FourthImageName = $"partialproduct_{FakeData.NumberData.GetNumber(1, 6)}.jpg",
                    UserBy = "BySystem",
                    AddedDate = now,
                    product = product_list[i]

                };

                context.db_productimage.Add(productImage);
            }

            context.SaveChanges();
            #endregion

            //------------------Adding ProductsImage End------------------//



            //--------/----------Adding Comments Begin--------/-----------//

            #region

            for (int i = 0; i < 100; i++)
            {
                Comment comments = new Comment()
                {
                    //Id = i + 1,
                    Text = FakeData.TextData.GetSentence(),
                    UserBy = "BySystem",
                    AddedDate = now,
                    member = user_list[FakeData.NumberData.GetNumber(0, user_list.Count - 1)],
                    product = product_list[FakeData.NumberData.GetNumber(0, product_list.Count - 1)]
                };

                context.db_comment.Add(comments);
            }

            context.SaveChanges();
            #endregion

            //------------------Adding Comments End-----------------------//


            //--------/----------Adding Address Begin----------/----------//

            #region

            for (int i = 0; i < user_list.Count; i++)
            {
                Address addresses = new Address()
                {
                    //Id = i + 1,
                    Name = FakeData.PlaceData.GetStreetName(),
                    Description = FakeData.PlaceData.GetAddress(),
                    UserBy = "BySystem",
                    AddedDate = now,
                    member = user_list[i]
                };

                context.db_address.Add(addresses);
            }

            context.SaveChanges();
            #endregion

            //--------/----------Adding Address End----------/-----------//


            //////After that We will use this Address list////////////
            List<Address> address_list = context.db_address.ToList();


            //--------/----------Adding Order Begin----------/----------//

            #region

            for (int i = 0; i < 50; i++)
            {
                Member member = user_list[FakeData.NumberData.GetNumber(0, user_list.Count - 1)];
                Address adress = context.db_address.Where(x => x.Address_Member_Id == member.Id).FirstOrDefault();

                Order orders = new Order()
                {
                    //Id = i + 1,
                    Number = FakeData.TextData.GetAlphabetical(10),
                    Status = "Preparing",
                    UserBy = "BySystem",
                    Description = FakeData.TextData.GetSentence(),
                    AddedDate = now,
                    member = member,
                    address = adress

                };

                context.db_order.Add(orders);
            }

            context.SaveChanges();
            #endregion

            //--------/----------Adding Order End----------/----------//


            //////After that We will use this Order list////////////
            List<Order> order_list = context.db_order.ToList();


            //--------/----------Adding OrderDetail Begin-------/-------//

            #region

            for (int i = 0; i < order_list.Count; i++)
            {
                OrderDetail orderdetails = new OrderDetail()
                {
                    //Id = i + 1,
                    Price = FakeData.NumberData.GetNumber(1, 100),
                    Quantity = FakeData.NumberData.GetNumber(1, 125),
                    Discount = FakeData.NumberData.GetNumber(1, 90),
                    UserBy = "BySystem",
                    AddedDate = now,
                    order = order_list[i],
                    product = product_list[FakeData.NumberData.GetNumber(0, product_list.Count - 1)]

                };

                context.db_orderdetail.Add(orderdetails);
            }

            context.SaveChanges();
            #endregion

            //------------------Adding OrderDetail End------------------//


            //--------/----------Adding Message Begin-------/-------//

            #region

            List<string> FakeSubject = new List<string>() { "Hesabim calindi", "Yanlis siparis", "Yorum yapamiyorum", "Stokta urun yok", "Kredi kartim calindi", "Hakaret edildi", "Dolandirildim", "Bilgilerimi unuttum" };


            for (int i = 0; i < 3; i++)
            {
                Message rootmessage = new Message()
                {
                    //Id = messagecounter,
                    Subject = FakeSubject[FakeData.NumberData.GetNumber(0, FakeSubject.Count - 1)],
                    Text = FakeData.TextData.GetSentence(),
                    UserBy = "System",
                    IsRead = false,
                    AddedDate = now,
                    sendedmember = user_list[i],
                    takedmember = user_list[i + 3],
                    message = null

                };

                context.db_message.Add(rootmessage);

                messagecounter++;
            }

            context.SaveChanges();

            List<Message> message_list = context.db_message.ToList();

            for (int i = 0; i < 3; i++)
            {
                Message replymessage = new Message()
                {
                    //Id = messagecounter,
                    //Subject = FakeData.TextData.GetSentence(),
                    Text = FakeData.TextData.GetSentence(),
                    UserBy = "System",
                    IsRead = false,
                    AddedDate = now,
                    sendedmember = user_list[i + 3],
                    takedmember = user_list[i],
                    message = message_list[i]
                };

                context.db_message.Add(replymessage);

                messagecounter++;
            }

            context.SaveChanges();
            #endregion

            //------------------Adding Message End------------------//
        }

        public Badge ReturnBadge(int i)
        {
            if (i%2==0)
            {
                return Badge.Sale;
            }
            else
            {
                return Badge.Best;
            }
           
        }
    }
}
