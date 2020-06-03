using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SapatariaProject.DAL;
using SapatariaProject.DTO;
using MySql.Data.MySqlClient;


namespace SapatariaProject.BLL
{
    class VendedoresBLL
    {
        //Atributos
        ConnectionFactory cF;
        //CRUD
        private void Insert(VendedoresDTO vendedores)
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

        private void Delete(VendedoresDTO vendedores)
        {
            try

            {
                cF = new ConnectionFactory();
                cF.CreateConnection();
                String comando = "Delete from Vendedores Where Login = '" + vendedores.Login + "'";
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

        private void Update(VendedoresDTO vendedores)
        {
            try

            {
                cF = new ConnectionFactory();
                cF.CreateConnection();
                String comando = "Update Vendedores set Senha = '" + vendedores.Senha + "', Vendas = " + vendedores.Vendas + " Where Login = '" + vendedores.Login + "'";
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

        public List<VendedoresDTO> Read()
        {
            MySqlDataReader dR = ReadDr();
            List<VendedoresDTO> vendedores = new List<VendedoresDTO>();
            try
            {
                if(dR != null) do
                {
                    VendedoresDTO vendedor = new VendedoresDTO();
                    vendedor.Login = dR["Login"].ToString();
                    vendedor.Senha = dR["Senha"].ToString();
                    vendedor.Vendas = Convert.ToInt32(dR["Vendas"].ToString());
                    vendedores.Add(vendedor);
                } while (dR.Read());
                if (vendedores.Count == 0) return null;
                return vendedores;
            }catch(Exception e) 
            { 
                throw new Exception("Erro: " + e.Message);
            }
        }

        //Demais métodos
        public VendedoresDTO EhVendedor(String login, String senha)
        {
            try
            {
                List<VendedoresDTO> vendedores = Read();
                foreach (VendedoresDTO v in vendedores)
                {
                    if (login.Equals(v.Login) && senha.Equals(v.Senha)) return v;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Erro: " + e.Message);
            }
            return null;
        }

        public bool NovoVendedor(VendedoresDTO vendedor)
        {
            try
            {
                vendedor.Login = vendedor.Login.Replace("'", "''");
                //Verifica validade
                bool validade = true;
                List<VendedoresDTO> vendedores = Read();
                if(vendedores != null) foreach(VendedoresDTO v in vendedores)
                    {
                        if (v.Login.Equals(vendedor.Login)) validade = false;
                    }
                if (validade) Insert(vendedor);
                else return false;
                return true;
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool AttVendedor(VendedoresDTO vendedor)
        {
            try
            {
                vendedor.Senha = vendedor.Senha.Replace("'", "''");
                Update(vendedor);
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
