using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            using(BookDBEntities entity = new BookDBEntities() )
            {
                BookTable1 tbl = new BookTable1();
                tbl.BookId = 1;
                tbl.Author = "James";
                tbl.BookName = "Java";
                tbl.Price = 200;
                entity.BookTable1.Add(tbl);
                entity.SaveChanges();
                Console.WriteLine("bookrecord added successful");



                var query = from t in entity.BookTable1 select t;
                foreach (var t1 in query)
                {
                    Console.WriteLine("BookId" + t1.BookId);
                    Console.WriteLine("BookName" + t1.BookName);
                    Console.WriteLine("Author" + t1.Author);
                    Console.WriteLine("Price" + t1.Price); ;

                }
               // var book = (from b in entity.BookTable1 where b.BookId == 2 select b).FirstOrDefault();
               // if (book != null)
               // {
                 //   entity.BookTable1.Remove(book);
                   // entity.SaveChanges();
                    //Console.WriteLine("record deleted");

                //}
                //else
                //{
                  //  Console.WriteLine("Recordf not found");
                //}
                //Console.ReadLine();
            }



        }
    }
}
            
 