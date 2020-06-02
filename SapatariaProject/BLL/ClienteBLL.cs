﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SapatariaProject.DTO;
using SapatariaProject.DAL;

namespace SapatariaProject.BLL
{
    class ClienteBLL
    {
        ConnectionFactory cF;
        public void Insert(ClienteDTO cliente)
        {
            try
            {
                cF = new ConnectionFactory();
                cF.CreateConnection();
                String comando = "Insert INTO Clientes (Nome, Pedidos, Telefone) Values ('" + cliente.Nome + "', 0, '" + cliente.Telefone + "')";
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
                dT = cF.RetDataTable("Select * from Clientes");
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
