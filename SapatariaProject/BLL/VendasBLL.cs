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
    class VendasBLL
    {
        //Atributos
        ConnectionFactory cF;

        //CRUD
        private void Insert(VendasDTO venda)
        {
            try
            {
                cF = new ConnectionFactory();
                cF.CreateConnection();
                String comando = "Insert INTO Vendas (Vendedor, Cliente, Valor, Dia, Mes, Ano) Values ('" + venda.Vendedor + "', " + venda.Cliente + ", " + venda.Valor + ", " + venda.Dia + ", " + venda.Mes + ", " + venda.Ano + ")";
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

        private void Delete(VendasDTO venda)
        {
            try
            {
                cF = new ConnectionFactory();
                cF.CreateConnection();
                String comando = "Delete from Vendas Where ID = " + venda.Id + "";
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

        private void Update(VendasDTO venda)
        {
            try
            {
                cF = new ConnectionFactory();
                cF.CreateConnection();
                String comando = "Update Vendas set Vendedor = '" + venda.Vendedor + "', Cliente = " + venda.Cliente + ", Valor = " + venda.Valor + ", Dia = " + venda.Dia + ", Mes = " + venda.Mes + ", Ano = " + venda.Ano + " where ID = " + venda.Id;
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
                dT = cF.RetDataTable("Select * from Vendas");
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
                dR = cF.RetDataReader("Select * from Vendas");
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

        public List<VendasDTO> Read()
        {
            MySqlDataReader dR = ReadDr();
            List<VendasDTO> vendas = new List<VendasDTO>();
            try
            {
                if (dR != null) do
                    {
                        VendasDTO venda = new VendasDTO();
                        venda.Id = Convert.ToInt32(dR["ID"].ToString());
                        venda.Vendedor = dR["Vendedor"].ToString();
                        venda.Cliente = Convert.ToInt32(dR["Cliente"].ToString());
                        venda.Valor = float.Parse(dR["Valor"].ToString());
                        venda.Dia = Convert.ToInt32(dR["Dia"].ToString());
                        venda.Mes = Convert.ToInt32(dR["Mes"].ToString());
                        venda.Ano = Convert.ToInt32(dR["Ano"].ToString());
                        vendas.Add(venda);
                    } while (dR.Read());
                if (vendas.Count == 0) return null;
                return vendas;
            }
            catch
            {
                return null;
            }
        }

        public bool NovaVenda(VendasDTO venda)
        {
            try
            {
                //Obter data de Hoje
                DateTime data = DateTime.Today;
                venda.Dia = data.Day;
                venda.Mes = data.Month;
                venda.Ano = data.Year;
                Insert(venda);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
