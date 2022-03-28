using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Books book1 = new Books("Harry Potter", "J.K.Rowling",12);
            Books book2 = new Books("1984", "George Orwell", 5);
            Books book3 = new EBooks("Anne with an E", "Lucy Maud Montgomery", 2, 100);
            book1.Information();
            book2.Information();
            book3.Information();

        }

        class Books
        {
            public string Name;
            public string Writer;
            public int Printing;
            public int Price;

            public Books()
            {
                Console.WriteLine("Book created");
            }
            public Books(string name, string writer, int price)
            {
                Name = name;
                Writer = writer;
                Price = price;
            }
            public virtual void Information()
            {
                Console.WriteLine($"Book Name: {Name}, Writer: {Writer},  Price: {Price}$");
            }
        }
        class EBooks:Books
        {
            public int CountDownloading;

            public EBooks(string name,string writer,int price, int countDownloading) :base(name,writer,price)
            {
                CountDownloading = countDownloading;
            }
            public override void Information()
            {
                Console.WriteLine($"E-Book Name: {Name}, Writer: {Writer},  Price: {Price}$ Count of Downloading: {CountDownloading}");
            }
        }
    }
}
