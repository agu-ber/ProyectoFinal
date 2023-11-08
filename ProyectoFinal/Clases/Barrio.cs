using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Clases
{
    public class Barrio
    {
        public DataTable getbarrios()
        {
            string sql = "select idbarrio, nombre from barrio order by nombre";
            return Database.Select(sql);
        }
    }
}
