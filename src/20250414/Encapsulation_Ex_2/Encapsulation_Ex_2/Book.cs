using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_Ex_2
{
    public class Book
    {
        private string _author;
        private string _isbn;
        private string _titel;
        private DateTime _nextAvailability;


        private BookLendingState _lendingState;
       

        public Book (string titel, string author, string isbn)
        {
            _titel = titel;
            _author = author;
            _isbn = isbn;

            _nextAvailability = DateTime.Now;
            _lendingState = BookLendingState.Available;
            
        }

        public BookLendingState LendingState
        {
            get { return _lendingState; }
        }

        public DateTime NextAvailability
        {
            get { return _nextAvailability; }
        }


        public string Titel
        {
            get { return _titel; }
        }

        public string Isbn
        {
            get { return _isbn; }
        }


        public string Author
        {
            get { return _author; }
        }

        public void Display()
        {
            Console.WriteLine
                ($"Titel: {_titel}  " +
                $"\nAuthor: {_author} " +
                $"\nISBN: {_isbn} " +
                $"\nNext Availabal: {_nextAvailability.ToString("dd.MM.yyyy")} " +
                $"\nStatus: {_lendingState.ToString().ToUpper()}\n");

        }

        public void Borrow(TimeSpan borrowDuration)
        {
            if (_lendingState != BookLendingState.Available)
            {
                return;
            }

            _nextAvailability = _nextAvailability.Add(borrowDuration);
            _lendingState = BookLendingState.Borrowed;
        }

    }
}
