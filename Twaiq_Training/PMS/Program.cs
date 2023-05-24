using PMS.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS
{
    class Program
    {
        public static readonly CRUD operation = CRUD.Instance;

        static void Main(string[] args)
        {
            var posts = operation.GetList();
            foreach(var post in posts)
            {
                Console.WriteLine(post.PostTile + " " + post.PostDescreption + " " 
                    + post.PublishDate + "\t" + post.AutherName);
            }
        }
    }
}
