using PMS.Constants;
using PMS.Entities;
using PMS.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace PMS.Business
{
    public class CRUD:BaseRepository
    {
        public static readonly CRUD Instance = new CRUD();

        public List<Post> GetList()
        {
            Console.WriteLine("Database Connection has been Opened");
            var cmd = ConstantsQuery.selectWhere;
            var stringBuilder = new StringBuilder(cmd);
            stringBuilder.Append("1");
            stringBuilder.Append("Fetch First row");

            return ExcuteReader(ConstantsQuery.SelectQuery);

        }
    }
}
