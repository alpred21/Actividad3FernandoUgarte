using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaCRUD.MODELOS;

namespace SistemaCRUD.DAL
{
    internal class CienteDAL
    {
        public DataTable ListarClienteDal()
        {
            string consulta = "select * from cliente";
            DataTable Lista = Conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
    }
}
