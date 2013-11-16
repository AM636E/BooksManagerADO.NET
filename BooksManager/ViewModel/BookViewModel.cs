using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksManager.ViewModel
{
    class BookViewModel : ObservableObject
    {
        ObservableCollection<Book> _books;
    }
}
