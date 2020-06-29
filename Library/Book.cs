using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book
    {
        private string _title;
        private int _isbn;
        private int _numberInShop;
        public Book(string title, int isbn, int numberInShop)
        {
            _title = title;
            _isbn = isbn;
            _numberInShop = numberInShop;
        }

        public bool GetKindOfCover { get; set; } //Czy Cover to okładka?
        
        public int GetNumberOfPages { get; set; }

        public Author Author { get; set; }

        public void OrderBook(Book book)
        {
            Console.WriteLine($"Book {book._title} has been booked") ;
        
        }

        public bool isavailability (Book book)
        {

            if (book._numberInShop >= 1)
            {
                return true;
            }
            else
                return false;
        }
        private void WhereIsBook(Book book)
        {
            if (book._numberInShop >= 1)
            {
                Console.WriteLine("Book is on the shelf");
            }
            else if (book._numberInShop >= 5)
            {
                Console.WriteLine("Books are in the warehouse");
            }
            else
                Console.WriteLine("We haven't this book in shop");
        }
    }

    public class Author
    {
        private string _name;
        private int _age;
        private int _yearOfBirth;
    
    }
}
