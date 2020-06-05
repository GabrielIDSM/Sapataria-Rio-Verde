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
    class ClientesBLL
    {
        //Atributos
        ConnectionFactory cF;

        //CRUD
        private void Insert(ClientesDTO cliente)
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

        private void Delete(ClientesDTO cliente)
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

        private void Update(ClientesDTO cliente)
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
                dR = cF.RetDataReader("Select * from Clientes");
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

        public List<ClientesDTO> Read()
        {
            MySqlDataReader dR = ReadDr();
            List<ClientesDTO> clientes = new List<ClientesDTO>();
            try
            {
                if (dR != null) do
                    {
                        ClientesDTO cliente = new ClientesDTO();
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
                return null;
            }
        }

        //Demais métodos
        public bool NovoCliente(ClientesDTO cliente)
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

        public bool AttCliente(ClientesDTO cliente)
        {
            try
            {
                cliente.Nome = cliente.Nome.Replace("'", "''");
                cliente.Telefone = cliente.Telefone.Replace("'", "''");
                Update(cliente);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool ExcluirCliente(ClientesDTO cliente)
        {
            try
            {
                Delete(cliente);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        public int ProximoID()
        {
            try
            {
                List<ClientesDTO> clientes = Read();
                return clientes.Count + 1;
            } catch(Exception e)
            {
                return -1;
            }
        }

        public bool AddCompra(ClientesDTO cliente)
        {
            if (cliente == null) return true;
            try
            {
                cliente.Compras = cliente.Compras + 1;
                Update(cliente);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
