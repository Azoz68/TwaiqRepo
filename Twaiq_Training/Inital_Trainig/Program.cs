using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inital_Trainig
{
    class Program
    {
        static void Main(string[] args)
        {

            var connectionString = "Data Source=DESKTOP-V48SL9M;Initial Catalog=Book;Integrated Security=True";
            var con = new SqlConnection();
            con.ConnectionString = connectionString;
            var command = "SELECT * FROM Book";
            con.Open();
            Console.WriteLine("Database has been opend");
            var cmd = new SqlCommand(command, con);
            var rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Console.WriteLine(rdr.GetValue(0));
                Console.WriteLine(rdr.GetValue(1));
            }
            con.Close();
            Console.WriteLine("Database has been closed");
        }
    }
}
