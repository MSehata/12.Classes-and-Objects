using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Classes_and_Objects
{
    internal class book
    {
        public string tittle;
        public string author;
        public int pages;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            book book1 = new book();
            book book2 = new book();

            book1.tittle = "Its more than Just Money";
            book1.author = "Witness Mdaka";
            book1.pages = 400;

            book2.tittle = "The struggles to being content";
            book2.author = "Moloko Sehata";
            book2.pages = 120;

            Console.WriteLine("Tittle of Book 1: " + book1.tittle);
            Console.WriteLine("Author of Book 2: " + book2.author);
        }
    }
}
