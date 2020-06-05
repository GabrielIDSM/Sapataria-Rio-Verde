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
    class SapatosBLL
    {
        //Atributos
        ConnectionFactory cF;

        //CRUD
        private void Insert(SapatosDTO sapatos)
        {
            try
            {
                cF = new ConnectionFactory();
                cF.CreateConnection();
                String comando = "Insert INTO Sapatos (Nome, Tamanho, Quantidade, Sexo, Valor) Values ('" + sapatos.Nome + "', " + sapatos.Tamanho + ", " + sapatos.Quantidade + ", '" + sapatos.Sexo + "', " + sapatos.Valor.ToString().Replace(",", ".") + ")";
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

        private void Delete(SapatosDTO sapatos)
        {
            try
            {
                cF = new ConnectionFactory();
                cF.CreateConnection();
                String comando = "Delete from Sapatos Where ID = " + sapatos.Id + "";
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

        private void Update(SapatosDTO sapatos)
        {
            try
            {
                cF = new ConnectionFactory();
                cF.CreateConnection();
                String comando = "Update Sapatos set Nome = '" + sapatos.Nome + "', Tamanho = " + sapatos.Tamanho + ", Quantidade = " + sapatos.Quantidade + ", Sexo = '" + sapatos.Sexo + "', Valor = " + sapatos.Valor.ToString().Replace(",",".") + " Where ID =" + sapatos.Id;
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
                dT = cF.RetDataTable("Select * from Sapatos");
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
                dR = cF.RetDataReader("Select * from Sapatos");
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

        public List<SapatosDTO> Read()
        {
            MySqlDataReader dR = ReadDr();
            List<SapatosDTO> sapatos = new List<SapatosDTO>();
            try
            {
                if (dR != null) do
                    {
                        SapatosDTO sapato = new SapatosDTO();
                        sapato.Id = Convert.ToInt32(dR["ID"].ToString());
                        sapato.Nome = dR["Nome"].ToString();
                        sapato.Tamanho = Convert.ToInt32(dR["Tamanho"].ToString());
                        sapato.Quantidade = Convert.ToInt32(dR["Quantidade"].ToString());
                        sapato.Sexo = dR["Sexo"].ToString();
                        sapato.Valor = float.Parse(dR["Valor"].ToString());
                        sapatos.Add(sapato);
                    } while (dR.Read());
                if (sapatos.Count == 0) return null;
                return sapatos;
            }
            catch
            {
                return null;
            }
        }

        public int ProximoId()
        {
            List<SapatosDTO> sapatos = Read();
            if (sapatos != null) return sapatos.Count + 1;
            else return 1;
        }

        public bool NovoProduto(SapatosDTO sapato)
        {
            try
            {
                sapato.Nome = sapato.Nome.Replace("'", "''");
                Insert(sapato);
                return true;
            }catch
            {
                return false;
            }
        }

        public bool AttProduto(SapatosDTO sapato)
        {
            try
            {
                sapato.Nome = sapato.Nome.Replace("'", "''");
                Update(sapato);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool ExcProduto(SapatosDTO sapato)
        {
            try
            {
                Delete(sapato);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
