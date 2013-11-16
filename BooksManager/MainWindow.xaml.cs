using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BooksManager
{
    using Entities;
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            try
            {
                List<Book> books = Book.GetAllBooks();

                foreach(var book in books)
                {
                    MessageBox.Show(book.ToString());
                }

            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
