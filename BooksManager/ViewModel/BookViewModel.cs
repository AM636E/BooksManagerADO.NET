using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;

using BooksManager.Entities;
using BooksManager.Model;

namespace BooksManager.ViewModel
{
    class BookViewModel : ObservableObject
    {
        private BooksModel _model;

        public IEnumerable<Book> Books
        {
            get { return _model.Books; }
        }

        public ICommand EditCommand
        {
            get
            {
                return new DelegateCommand(_EditCommand);
            }
        }
        public ICommand AddCommand
        {
            get
            {
                return new DelegateCommand(_AddCommand);
            }
        }
        public ICommand LoadCommand
        {
            get
            {
                return new DelegateCommand(_LoadCommand);
            }
        }

        public BookViewModel()
        {
            _model = new BooksModel();
        }

        private void _LoadCommand()
        {
           // _model = new BooksModel();
           _model.LoadBooks();
        }

        private void _AddCommand()
        {

        }

        private void _EditCommand()
        {

        }
    }
}
