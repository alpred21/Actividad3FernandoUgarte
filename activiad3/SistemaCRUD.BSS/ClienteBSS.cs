using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaCRUD.MODELOS;
using SistemaCRUS.DAL;
namespace SistemaCRUD.BSS
{
    public class ClienteBSS
    {
        ClienteDAL dal = new ClienteDAL();
        public DataTable ListarClienteBss()
        {
            return dal.ListarClienteDal();
        }
    }
