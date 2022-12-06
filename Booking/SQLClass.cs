using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data.Common;

namespace Booking
{
    public static class SQLClass
    {

        public const string CONNECTION_STRING =
           "SslMode=none;Server=sql8.freesqldatabase.com;Database=sql8582204;port=3306;Uid=sql8582204;pwd=JewBSNfaZ1";

        public static MySqlConnection CONN;

        public static List<string> Select(string cmdText)
        {

            List<string> list = new List<string>();
            MySqlCommand cmd = new MySqlCommand(cmdText, SQLClass.CONN);
            DbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    list.Add(reader.GetValue(i).ToString());
                }

            }
            reader.Close();
            return list;
        }


        //summary
        //функция Update запроса /Insert/Delete
        // </summary>
        public static void Update(string cmdText)
        {
            MySqlCommand cmd = new MySqlCommand(cmdText, SQLClass.CONN);
            DbDataReader reader = cmd.ExecuteReader();
            reader.Close();
        }

    }
}
