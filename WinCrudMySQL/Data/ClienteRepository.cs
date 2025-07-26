using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinCrudMySQL.Models;
using MySql.Data.MySqlClient;

namespace WinCrudMySQL.Data
{
    public class ClienteRepository
    {
        public List<Cliente> GetAll()
        {
            List<Cliente> clientes = new List<Cliente>();
            string query = "SELECT Id , Nome, Email Telefone, DataCadastraro FROM Clentes";

            using (MySqlConnection command = Database.GetConnection())
            {
                try
                {
                    connction.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection: ();
                    { 
                        using (MySqlDateReander reander = command.ExecuteReader())
                             
                           while (reander.Read()) 
                           {
                                clientes.Add(new Cliente
                                {
                                    ClienteID = reander.GetInt32("Id"),
                                    Nome = reader.GetString("Nome"),
                                    Email = reader.IsDBNull("email") ? null : reander.GetString("email"),
                                    Telefone = reader.isDBNull("Telefone") ? null : reander.GetString("Telefone"),
                                    DataCadastro = Reader.GetDateTime("Cadastro")
                                });













                }
                catch (Exception)
                {

                    throw;
                }
            }  

        }         
     }
 }           
             
             
             

    

