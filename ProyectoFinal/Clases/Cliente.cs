using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Clases
{
    public class Cliente
    {
        public void Insertar(string nombre, string apellido, string telefono, string documento, int idbarrio)
        {
            string sql = "insert into cliente(nombre, apellido, nrodoc, telefono, idbarrio) ";
            sql += "values ('" + nombre + "', ";
            sql += "'" + apellido + "', ";
            sql += "'" + documento + "', ";
            sql += "'" + telefono + "', ";
            sql += "'" + idbarrio + "')";
            Database.Guardar(sql);
        }
    }
}
