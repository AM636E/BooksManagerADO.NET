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
        private int ________;

        public ObservableCollection<Book> Books { get { return _books; } }

        public void AddNewBook(Book book)
        {
            _books.Add(book);
        }

        public void LoadBooks()
        {
            _books = Book.GetAllBooksObservable();
        }

        public void Dispose()
        {

        }

        ~BooksModel()
        {
            Dispose();
        }
    }
}
