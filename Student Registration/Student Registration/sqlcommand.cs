using System;
using System.Data.SqlClient;

namespace Student_Registration
{
    internal class sqlcommand
    {
        private string sql;
        private SqlConnection con;

        public sqlcommand(string sql, SqlConnection con)
        {
            this.sql = sql;
            this.con = con;
        }

        public static implicit operator SqlCommand(sqlcommand v)
        {
            throw new NotImplementedException();
        }
    }
}