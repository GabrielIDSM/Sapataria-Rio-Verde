using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SapatariaProject.DTO;
using SapatariaProject.DAL;
using MySql.Data.MySqlClient;

namespace SapatariaProject.BLL
{
    class ClienteBLL
    {
        //Atributos
        ConnectionFactory cF;

        //CRUD
        private void Insert(ClienteDTO cliente)
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

        private void Delete(ClienteDTO cliente)
        {
            try
            {
                cF = new ConnectionFactory();
                cF.CreateConnection();
                String comando = "Delete from Clientes Where ID = " + cliente.Id + "";
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

        private void Update(ClienteDTO cliente)
        {
            try
            {
                cF = new ConnectionFactory();
                cF.CreateConnection();
                String comando = "Update Clientes set Nome = '" + cliente.Nome + "', Pedidos = " + cliente.Compras + ", Telefone = '" + cliente.Telefone + "' where ID = " + cliente.Id;
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

        public DataTable ReadDt()
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

        public MySqlDataReader ReadDr()
        {
            MySqlDataReader dR = null;
            try
            {
                cF = new ConnectionFactory();
                cF.CreateConnection();
                dR = cF.RetDataReader("Select * from Vendedores");
            }
            catch (Exception e)
            {
                throw new Exception("Erro: " + e.Message);
            }
            finally
            {
                cF = null;
            }
            return dR;
        }

        public List<ClienteDTO> Read()
        {
            MySqlDataReader dR = ReadDr();
            List<ClienteDTO> clientes = new List<ClienteDTO>();
            try
            {
                if (dR != null) do
                    {
                        ClienteDTO cliente = new ClienteDTO();
                        cliente.Id = Convert.ToInt32(dR["ID"].ToString());
                        cliente.Nome = dR["Nome"].ToString();
                        cliente.Compras = Convert.ToInt32(dR["Pedidos"].ToString());
                        cliente.Telefone = dR["Telefone"].ToString();
                        clientes.Add(cliente);
                    } while (dR.Read());
                if (clientes.Count == 0) return null;
                return clientes;
            }
            catch (Exception e)
            {
                throw new Exception("Erro: " + e.Message);
            }
        }

        //Demais métodos
        public bool NovoCliente(ClienteDTO cliente)
        {
            try
            {
                cliente.Nome = cliente.Nome.Replace("'", "''");
                cliente.Telefone = cliente.Telefone.Replace("'", "''");
                Insert(cliente);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}
