using PMS.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace PMS.Repository
{
    public class BaseRepository
    {
        private readonly string connectString;
        protected BaseRepository()
        {
            connectString = ConfigurationManager.ConnectionStrings["PostDB"].ConnectionString;
        }
        protected SqlConnection GetConnection()
        {
            var Conection = new SqlConnection(connectString);
            return Conection;
        }
        public void OpenConnectio(SqlConnection connection)
        {
            connection.Open();

        }
        public List<Post> ExcuteReader(string Query)
        {
            var connection = GetConnection();
            OpenConnectio(connection);
            var cmd = new SqlCommand(Query, connection);
            
            return ReadEntity(cmd.ExecuteReader());
        }
        public List<Post> ReadEntity(SqlDataReader rdr)
        {
            var list = new List<Post>();
            while (rdr.Read())
            {
                var result = new Post();
                result.Id = Convert.ToInt32(rdr[0]);
                if(rdr[1].ToString() != null) { 
                    result.PostTile = rdr[1].ToString();
                }
                else
                {
                    result.PostTile = null;
                }
                result.PostDescreption = rdr[2].ToString();
                result.PublishDate = rdr.IsDBNull(3) ? "" : rdr[3].ToString();
                result.AutherName = rdr[4].ToString();

                list.Add(result);
            }
            return list;
        }
    }
}
