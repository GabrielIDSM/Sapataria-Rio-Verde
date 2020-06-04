using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SapatariaProject.DTO;
using SapatariaProject.DAL;
using System.Data;
using MySql.Data.MySqlClient;

namespace SapatariaProject.BLL
{
    class AdmBLL
    {
        //Atributos
        ConnectionFactory cF;

        //CRUD
        private void Insert(AdmDTO adm)
        {
            try
            {
                cF = new ConnectionFactory();
                cF.CreateConnection();
                String comando = "Insert INTO Adm (Login) Values ('" + adm.Login + "')";
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

        private void Delete(AdmDTO adm)
        {
            try
            {
                cF = new ConnectionFactory();
                cF.CreateConnection();
                String comando = "Delete from Adm Where Login = '" + adm.Login + "'";
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

        private void Update(AdmDTO adm)
        {
            try
            {
                cF = new ConnectionFactory();
                cF.CreateConnection();
                String comando = "Update Adm set Login = '" + adm.Login + "' where Login = '" + adm.Login + "'";
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
                dT = cF.RetDataTable("Select * from Adm");
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
                dR = cF.RetDataReader("Select * from Adm");
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

        public List<AdmDTO> Read()
        {
            MySqlDataReader dR = ReadDr();
            List<AdmDTO> adms = new List<AdmDTO>();
            try
            {
                if (dR != null) do
                    {
                        AdmDTO adm = new AdmDTO();
                        adm.Login = dR["Login"].ToString();
                        adms.Add(adm);
                    } while (dR.Read());
                if (adms.Count == 0) return null;
                return adms;
            }
            catch (Exception e)
            {
                throw new Exception("Erro: " + e.Message);
            }
        }

        //Métodos
        public bool EhAdm(String login)
        {
            try
            {
                List<AdmDTO> adms = Read();
                Console.WriteLine("Login: " + login);
                if (adms != null) foreach (AdmDTO a in adms)
                    {
                        Console.WriteLine("Adm: " + a.Login);
                        if (a.Login.Equals(login))
                        {
                            return true;
                        }
                    }
                return false;
            }catch(Exception e)
            {
                throw new Exception("Erro: " + e.Message);
            }
        }

        public List<VendedoresDTO> NaoAdms()
        {
            List<VendedoresDTO> notadms = new List<VendedoresDTO>();
            List<AdmDTO> adms = Read();
            VendedoresBLL vendedoresBLL = new VendedoresBLL();
            List<VendedoresDTO> vendedores = vendedoresBLL.Read();
            try
            {
                bool ehAdm = false;
                if(vendedores != null)
                {
                    foreach (VendedoresDTO v in vendedores)
                    {
                        ehAdm = false;
                        if (adms != null)
                        {
                            foreach (AdmDTO a in adms)
                            {
                                if (a.Login.Equals(v.Login))
                                {
                                    ehAdm = true;
                                    break;
                                }
                            }
                        }
                        if (!ehAdm) notadms.Add(v);
                    }
                }
                if (notadms.Count == 0) return null;
                return notadms;
            }catch (Exception e)
            {
                return null;
            }
        }

        public bool NovoAdm(AdmDTO adm)
        {
            try
            {
                Insert(adm);
                return true;
            }catch (Exception e)
            {
                return false;
            }
        }
    }
}
