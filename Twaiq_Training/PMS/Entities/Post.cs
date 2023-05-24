using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public string PostTile { get; set; }
        public string PostDescreption { get; set; }
        public string PublishDate { get; set; }
        public string AutherName { get; set; }
    }
}
