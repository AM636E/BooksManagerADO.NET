using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using BooksManager.Entities;

namespace BooksManager.Model
{
    class BooksModel : IDisposable
    {
        private ObservableCollection<Book> _books;

        public ObservableCollection<Book> Books { get { return _books; } set { _books = value; } }

        public BooksModel()
        {
            _books = new ObservableCollection<Book>();
        }

        public void AddNewBook(Book book)
        {
            _books.Add(book);
        }

        public void LoadBooks()
        {
          //  _books = new ObservableCollection<Book>();
            _books.Clear();
            var tmp = Book.GetAllBooksObservable();

            foreach(Book b in tmp)
            {
                _books.Add(b);
            }
        }

        public void Dispose()
        {

        }

        ~BooksModel()
        {
            Dispose();
        }

        public override string ToString()
        {
            string output = "";

            foreach(Book book in _books)
            {
                output += book.ToString() + '\n';
            }

            return output;
        }
    }
}
