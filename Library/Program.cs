using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Program
    {

//1)	Stwórz nową klasę „Book”.
//2)	Zamodeluj utworzoną klasę tak aby miała przynajmniej 2 pola prywatne, 2 właściwości i 1 specjalną właściwość, która będzie typu innej klasy.Może to być np. „Autor”. Utwórz klasę „Autor” (lub innej wybranej przez Ciebie w pkt. 2). Zamodeluj tą klasę(typami prymitywnymi int, bool, string itp.).
//3)	W klasie „Book” utwórz konstruktor.Przyjmij w nim i wypełnij potrzebne, wybrane przez Ciebie parametry.
//4)  Utwórz w klasie „Book” przynajmniej 2 metody publiczne, które robią coś z książka.Liczę na kreatywność i w miarę realne przykłady.Wyobraźcie sobie, że robicie np.księgarnię internetową. Dodatkowo stwórz jedną metodę „pomocniczą” prywatną.
//5)  Utwórz klasę statyczną „GuestList”. W klasie tej utwórz 2 metody.Pierwsza powinna być odpowiedzialna za dodawanie gości do listy gości*, druga za drukowanie listy gości**. 
//Podpowiedź: *Należy do takiej metody przekazać obiekt typu List<string> oraz drugi parametr string. Wykonać operację i zwrócić obiekt typu List<string>** Należy przekazać w parametrze List<string>.

        static void Main(string[] args)
        {
            Book book = new Book("Rhytm of war", 213, 1);
            Book book2 = new Book("City of mirror", 1113, 0);
            Book book3 = new Book("Wither", 9911, 11);

            Console.WriteLine(book.isavailability(book));
            Console.WriteLine(book.isavailability(book2));
            book.OrderBook(book);

            GuestList.AddGuest("aaa");
            GuestList.AddGuest("bbb");
            GuestList.AddGuest("ccc");
            GuestList.AddGuest("ddd");
            GuestList.PrintGuestList();
            Console.ReadLine();
        }

    }
    static public class GuestList
    {
        static public List<string> _guestLists = new List<string>();

      
        static public void AddGuest(string name)
        {
            _guestLists.Add(name);
        }

        static public void PrintGuestList()
        {
            foreach (var item in _guestLists)
            {
                Console.WriteLine(item);
            }
        }
    }
}
