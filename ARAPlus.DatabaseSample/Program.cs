using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace ARAPlus.DatabaseSample
{

    class Program
    {
        private static void DisplayStates(IEnumerable<EntityEntry> entries)
        {
            foreach (var entry in entries)
            {
                Console.WriteLine($"Entity: {entry.Entity.GetType().Name},State: {entry.State.ToString()}");
                
            }
        }

        static async Task Main(string[] args)
        {

            Nullable<int> iV1;

            int? iV2;

            int i = 0;


            using (NorthwindContext ctx = new NorthwindContext())
            {
                using (var tx = ctx.Database.BeginTransaction(System.Data.IsolationLevel.ReadCommitted))
                {

                    long l = 1;
                    //Unchanged
                    var product1PK = ctx.Products.Find(l);

                    var product1Where = ctx.Products
                        .Where(p => p.ProductName == "Chai").
                        First();

                    var pSimple = from pS in ctx.Products
                                      //select Ps
                                  select new { Id = pS.ProductId, Name = pS.QuantityPerUnit };
                    //select productid, name from Products


                    DisplayStates(ctx.ChangeTracker.Entries());

                    //Changetracking entdeck änderungen
                    //Modified
                    product1PK.ProductName = "Chai Neu";
                    DisplayStates(ctx.ChangeTracker.Entries());
                    // product1PK.CategoryId = -7;
                    product1PK.UnitsInStock = 12;
                    product1PK.ProductName = "Chai";
                    var cust = ctx.Customers.Find("ALFKI");
                    //modified -- UPDATE
                    cust.ContactName = "Johann Grabner";


                    Customer neuerKunde = new Customer();
                    neuerKunde.CustomerId = "GRABN";
                    neuerKunde.ContactName = "Johann";
                    neuerKunde.CompanyName = "Grabner";

                    //Added
                    ctx.Customers.Add(neuerKunde);
                    //Insert

                    await ctx.SaveChangesAsync();

                    ctx.Remove(neuerKunde);
                    ctx.SaveChanges();
                    //Delete
                    tx.Commit();
                }


            }
        }

            static void MainOld(string[] args)
        {
            //ADO.NET ActiveX Data Objects, Advanced Data Objects
            //DataProvider MS SQL OLEDB ODBC
            /*
             SqlConnection con = new SqlConnection("server=test;initital catalog=demodb");
             SqlCommand cmdRead = new SqlCommand("select * from kunden", con);
             SqlCommand cmdUpdate = new SqlCommand("update kunden set vorname='Johann' where kdnr=1", con);

             con.Open();
             cmdUpdate.ExecuteNonQuery(); //Insert, Update, Delete

             SqlDataReader myReader= cmdRead.ExecuteReader();

             while (myReader.Read())
             {
                 Console.WriteLine(myReader["Vorname"]);
             }
            */
            //OR--> Object / Relational Mapper - Hypernate, EF --> Entity Framework Core
            //  var k1 = ctx.Kunden.Where(k=>k.Kdnr==1); --> SELECT * from Kunden where kndr=1
            //ctx.Kunden.Add(newKunde)
            //ctx.SaveChanges(); ---> Insert into 
            //EF - Code First -- Klassen, DbContext DbSet
            //Database First -- Scaffold -- automatisch Generieren von Code
            //Model First

            using (NorthwindContext ctx = new NorthwindContext())
            {
                Product pNeu = new Product();
                pNeu.ProductId = -1;
                pNeu.ProductName = "Johann Graz";
                //ctx.Products.Add(pNeu);
                // ctx.SaveChanges();

                var productJohann = ctx.Products.Find(-1L);
                productJohann.ProductName = "Johann Wien";

                var affected = ctx.SaveChanges();
                ctx.Remove(productJohann);
                affected = ctx.SaveChanges();

            }
            using (NorthwindContext ctx = new NorthwindContext())
            {
                //ctx.Product.Add(new Model.Product() { ProdId = 1, Description = "Hello" });
                //Lazy Loading

                var categoriesV1 = ctx.Categories.Where(s => s.CategoryName.Contains("a"))
                    .OrderBy(s => s.CategoryId);

                var alleCats = categoriesV1.ToList();

                var catMitLinq = from c in ctx.Categories
                                 where c.CategoryName.Contains("a")
                                 orderby c.CategoryId
                                 select c;

                string sql1 = categoriesV1.ToQueryString();

                var categoriesV2 = ctx.Categories.Where(s => s.CategoryName.Contains("a"))
                    .Include(c=>c.Products)
                    .OrderBy(s => s.CategoryId);

                string sql2 = categoriesV2.ToQueryString();

                string s1 = categoriesV1.ToQueryString();

                var products = ctx.Products.Where(p => p.ProductId > 5).OrderBy(p => p.ProductName).
                    Include(p => p.Category); //Laden von abhängigen Objects

                var sqlText = products.ToQueryString();
                
                foreach (var item in products)
                {
                    Console.WriteLine($"{item.ProductId} {item.ProductName} ");
                    var cat = item.Category.CategoryName;
                }
            }






            Console.WriteLine("Hello World!");
        }
    }
}
