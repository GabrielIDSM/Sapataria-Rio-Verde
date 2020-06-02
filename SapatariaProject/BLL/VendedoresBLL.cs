using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SapatariaProject.DAL;
using SapatariaProject.DTO;


namespace SapatariaProject.BLL
{
    class VendedoresBLL
    {
        ConnectionFactory cF;
        public void Insert(VendedoresDTO vendedores)
        {
            try
            {
                cF = new ConnectionFactory();
                cF.CreateConnection();
                String comando = "Insert INTO Vendedores (Login, Senha, Vendas) Values ('"+ vendedores.Login +"', '"+ vendedores.Senha +"' , 0)";
                cF.SqlCommand(comando);
            }
            catch (Exception e)
            {
                throw new Exception("Erro: " + e.Message);
            }
            finally
            {
                cF = null;
            }

        }

        public DataTable Read()
        {
            DataTable dT = null;
            try
            {
                cF = new ConnectionFactory();
                cF.CreateConnection();
                dT = cF.RetDataTable("Select * from Vendedores");
            }
            catch (Exception e)
            {
                throw new Exception("Erro: " + e.Message);
            }
            finally
            {
                cF = null;
            }
            return dT;
        }
    }
}
