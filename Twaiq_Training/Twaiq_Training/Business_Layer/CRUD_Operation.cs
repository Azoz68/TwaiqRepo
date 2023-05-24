
using Twaiq_Training;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Data.SqlClient;
using System;

namespace Business_Layer 
{
    public class CRUD_Operation : BaseRepository
    {
        public static readonly CRUD_Operation Instance = new CRUD_Operation();
        public List<Book> GetList()
        {
            var con = GetConnection();
            Console.WriteLine("Database Connection has been Opened");
            var queries = "SELECT * FROM Book";

            var cmd = new SqlCommand(queries, con);

            var result = GetBooks(cmd, con);

            return result;

        }
    }
}
