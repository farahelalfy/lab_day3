using day_3;
using Microsoft.VisualBasic.FileIO;
using System.Diagnostics;
using static System.Reflection.Metadata.BlobBuilder;

namespace day_3
{
    class Book
    {
        int id = 3;
        string name = "book3";
        string type = "drama";
        DateTime createdOn = DateTime.Now;
        bool isDeleted = false;
        string price = "250";
        static int count = 0;
        private bool isdeleted;

        public Book(int id, string name, string type, DateTime createdOn, bool isDeleted, string price)
        {
            this.id = id;
            this.name = name;
            this.type = type;
            this.createdOn = createdOn;
            this.isDeleted = isDeleted;
            this.price = price;
            count++;
        }
        public Book()
        {
            count++;

        }
        public Book(string name, int id)
        {
            this.name = name;
            this.id = id;
            count++;
        }
        static Book()
        {
            Console.WriteLine($"this is static ctor");

        }

        public void getDataBook(int id, string name, string type, DateTime createdOn, bool isDeleted, string price)
        {
            this.id = id;
            this.name = name;
            this.type = type;
            this.createdOn = createdOn;
            this.isDeleted = isDeleted;
            this.price = price;

        }
        

        public void printDataBook()
        {
            Console.WriteLine($"{id},{name},{type},{createdOn},{isDeleted},{price}");
        }

       
        public string IsDeleted()
        {
            return isDeleted ? "It is deleted" : "It is not deleted";
        }


        public static int getBookCount() 
        {
            return count;
        }
    }
}


internal class Program
    {
        static void Main(string[] args)
    {
       Book b1 = new Book(1,"book1","horror",DateTime.Now,false,"120");
        Book b2 = new Book(2,"book2","romance",DateTime.Now,true,"200");
        Book b3 = new Book();
        Book b4 = new Book(4,"book4", "fantasy", DateTime.Now , true, "220");
        b1.printDataBook();
        b2.printDataBook();
        b3.printDataBook();
        b4.printDataBook();

        Console.WriteLine($"Is b1 deleted? {b1.IsDeleted()}");
        Console.WriteLine($"Is b2 deleted? {b2.IsDeleted()}");
        Console.WriteLine($"Is b3 deleted? {b3.IsDeleted()}");
        Console.WriteLine($"Is b4 deleted? {b4.IsDeleted()}");

        Console.WriteLine($"Total books bought:{Book.getBookCount()}");
       
    }
    
}
