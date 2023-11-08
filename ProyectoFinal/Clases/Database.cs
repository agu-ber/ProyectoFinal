using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace ProyectoFinal.Clases
{
    public static class Database
    {
        public static string GetCadena()
        {
            string Cadena = "datasource=localhost;port=3306;User Id=root;database=pfinal;Password=;SSL Mode=None;";
            return Cadena;
        }

        public static void Guardar(string sql)
        {
            string Cadena = GetCadena(); 
            MySqlConnection con = new MySqlConnection(Cadena);
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static DataTable Select(string sql)
        {
            string Cadena = GetCadena();
            MySqlConnection con = new MySqlConnection(Cadena);
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = con;
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
    }
}
