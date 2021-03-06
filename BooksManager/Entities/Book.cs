﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;

namespace BooksManager.Entities
{
    class Book
    {
        private int _id;
        private string _name;
        private int _pages;

        public Book(int id, string name, int pages)
            : this(name, pages)
        {
            _id = id;
        }

        public Book(string name, int pages)
        {
            _name = name;
            _pages = pages;
        }
        public void Insert()
        {

        }

        public static DataSet ExecuteQuery(string query)
        {
            SqlDataAdapter da = new SqlDataAdapter(
                    query,
                    @"server=drud\zazsqlserver;uid=zaz;Integrated Security=true;database=Publishing"
                );
            DataSet result = new DataSet();

            try
            {
                da.Fill(result);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return result;
        }

        public static Book GetBookById(int id)
        {
            DataSet book = Book.ExecuteQuery(String.Format("SELECT * FROM dbo.books WHERE bid = {0}", id));

            return new Book((string)book.Tables[0].Rows[0]["bookname"], (int)book.Tables[0].Rows[0]["booksize"]);
        }

        public static Book GetLastBook()
        {
            DataSet lastid = Book.ExecuteQuery("SELECT MAX(bid) AS id FROM dbo.Books");

            int id = (int)lastid.Tables[0].Rows[0]["id"];

            return Book.GetBookById(id);
        }

        public static List<Book> GetAllBooks()
        {
            DataSet books = Book.ExecuteQuery("SELECT * FROM dbo.Books");
            List<Book> result = new List<Book>();

            DataTable dt = books.Tables[0];

            foreach(DataRow dr in dt.Rows)
            {
                result.Add(new Book((int)dr["bid"], (string)dr["bookname"], (int)dr["booksize"]));
            }

            return result;
        }

        public override string ToString()
        {
            return String.Format("{0} {1} {2}", _id, _name, _pages);
        }
    }
}
