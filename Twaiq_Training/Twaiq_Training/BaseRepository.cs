using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twaiq_Training
{

    public class BaseRepository
    {
        private readonly string connectionString;

        protected BaseRepository()
        {
            connectionString = ConfigurationManager.ConnectionStrings["TestBook"].ConnectionString;
        }

        protected SqlConnection GetConnection()
        {
            var result = new SqlConnection(connectionString);
            return result; 
        }

        public List<Book> GetBooks(SqlCommand command, SqlConnection connection)
        {
            var list = new List<Book>();
            try
            {
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var book = new Book();
                    book.Id = Convert.ToInt32(reader[0]);
                    book.Name = reader[1].ToString();
                    book.Pages = Convert.ToInt32(reader[2]);
                    list.Add(book);
                }


                return list;
            }
            finally
            {
                connection.Close();
            }
        }

    }
}
