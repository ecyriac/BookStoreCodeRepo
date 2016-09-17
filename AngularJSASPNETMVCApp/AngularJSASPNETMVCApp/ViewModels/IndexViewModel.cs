using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AngularJSASPNETMVCApp.POCO;
using AngularJSASPNETMVCApp.DAL;

namespace AngularJSASPNETMVCApp.ViewModels
{
    public class IndexViewModel
    {
        protected List<Book> allBooks;

        public List<Book> AllBooks
        {
            get
            {
                return this.allBooks;
            }
        }


        public IndexViewModel()
        {
            BookDAO bookDAO = new BookDAO();
            this.allBooks = bookDAO.getBooks();

        }

    }
}