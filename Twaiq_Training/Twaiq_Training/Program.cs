using Business_Layer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twaiq_Training
{
    class Program
    {
        public static readonly CRUD_Operation operation = CRUD_Operation.Instance;
        static void Main(string[] args)
        {
            var result = operation.GetList();
            foreach(var item in result)
            {
                Console.WriteLine(item.Id + "\t :" + item.Name + "\t :" + item.Pages);
            }
            Console.WriteLine("Database has been closed");
        }
    }
}
