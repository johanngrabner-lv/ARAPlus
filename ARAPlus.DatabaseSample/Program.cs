using System;
using System.Data.SqlClient;
using System.Linq;
using Microsoft.EntityFrameworkCore;
namespace ARAPlus.DatabaseSample
{

    class Program
    {
        static void Main(string[] args)
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
