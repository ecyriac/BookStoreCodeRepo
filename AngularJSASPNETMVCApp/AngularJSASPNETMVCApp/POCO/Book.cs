using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularJSASPNETMVCApp.POCO
{
    public class Book
    {
        protected DateTime created;

        public DateTime Created
        {
            get
            {
                return this.created;
            }

            set
            {
                this.created = value;
            }
        }

        protected Guid bookId;

        public Guid BookId
        {
            get
            {
                return this.bookId;
            }

            set
            {
                this.bookId = value;
            }
        }

        protected string isbn;

        public string Isbn
        {
            get
            {
                return this.isbn;
            }

            set
            {
                this.isbn = value;
            }
        }


        protected string title;
        
        public string Title
        {
            get
            {
                return this.title;
            }

            set
            {
                this.title = value;
            }
        }

        protected string publisher;

        public string Publisher
        {
            get
            {
                return this.publisher;
            }

            set
            {
                this.publisher = value;
            }
        }


        protected string authorshipDetails;

        public string AuthorshipDetails
        {
            get
            {
                return this.authorshipDetails;
            }

            set
            {
                this.authorshipDetails = value;
            }
        }


    }
}