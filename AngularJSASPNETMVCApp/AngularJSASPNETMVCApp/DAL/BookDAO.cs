using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using AngularJSASPNETMVCApp.POCO;
using System.Web.Mvc;
using System.Data;

namespace AngularJSASPNETMVCApp.DAL
{
    public class BookDAO
    {
        public List<Book> getBooks()
        {
            List<Book> books = new List<Book>();
            Book book;
            string queryString =
    "SELECT BookId, Created, Isbn, Title, Publisher, AuthorshipDetails from dbo.Book";

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["NorthwindConnectionString"].ToString()))
            {
                try
                {
                    // Create the Command and Parameter objects.
                    SqlCommand command = new SqlCommand(queryString, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        book = new Book();
                        book.BookId = (Guid)reader[0];
                        book.Created = (DateTime)reader[1];
                        book.Isbn = (reader[2] == DBNull.Value ? null : (string)reader[2]);
                        book.Title = (reader[3] == DBNull.Value ? null : (string)reader[3]);
                        book.Publisher = (reader[4] == DBNull.Value ? null : (string)reader[4]);
                        book.AuthorshipDetails = (reader[5] == DBNull.Value ? null : (string)reader[5]);
                        books.Add(book);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return books;
        }

        public int AddBook(Book aNewBook)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["NorthwindConnectionString"].ToString()))
            {
                try
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand("dbo.InsertBook", connection);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Isbn", aNewBook.Isbn));
                    cmd.Parameters.Add(new SqlParameter("@Title", aNewBook.Title));
                    cmd.Parameters.Add(new SqlParameter("@Publisher", aNewBook.Publisher));
                    cmd.Parameters.Add(new SqlParameter("@AuthorshipDetails", aNewBook.AuthorshipDetails));

                    cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return 0;
        }


    }
}