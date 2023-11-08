using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Clases
{
    public class Producto
    {
        public void Insertar(string nombre, double precio, string codbarra, int stock)
        {
            string sql = "insert into producto(nombre, codbarra, precio, stock) ";
            sql = sql + "values ('" + nombre + "', ";
            sql += "'" + codbarra + "', ";
            sql += precio.ToString() + ", ";
            sql += stock.ToString() + ")";
            Database.Guardar(sql);
        }

        public DataTable Buscar(string nombre)
        {
            string sql = "select idproducto, nombre, codbarra, precio, stock ";
            sql += "from producto where nombre = '" + nombre + "'";
            return Database.Select(sql);
        }

        public DataTable BuscarPorCodBarra(string codigo)
        {
            string sql = "select idproducto, nombre, codbarra, precio, stock ";
            sql += "from producto where codbarra = '" + codigo + "'";
            return Database.Select(sql);
        }

        public DataTable BuscarPorID(int idproducto)
        {
            string sql = "select idproducto, nombre, codbarra, precio, stock ";
            sql += "from producto where id producto = '" + idproducto + "'";
            return Database.Select(sql);
        }

        public void Modificar(int idproducto, string nombre, string codbarra, double precio, int stock)
        {
            string sql = "update producto set ";
            sql = sql + "nombre = '" + nombre + "', ";
            sql += "codbarra = '" + codbarra + "', ";
            sql += "precio = '" + precio.ToString() + "', ";
            sql += "stock = '" + stock + "' ";
            sql += "where idproducto = " + idproducto;
            Database.Guardar(sql);
        }

        public void Eliminar(int idproducto)
        {
            string sql = "delete from producto where ";
            sql = sql + "idproducto = " + idproducto.ToString();
            Database.Guardar(sql);
        }
    }
}
