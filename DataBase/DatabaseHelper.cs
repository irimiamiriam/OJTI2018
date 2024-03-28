using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.Windows.Forms;

namespace OJTI2018.DataBase
{
    class DatabaseHelper
    {
        private static readonly string connectionstring = SqlAccess.GetConnectionString();
        private static readonly string datepath = SqlAccess.GetFilePath();
        private static string delUtilizatori = "Delete from Utilizatori";
        private static string delItemi = "Delete from Itemi";
        private static string delEvaluari = "Delete from Evaluari";
        private static string resetU = "DBCC CHECKIDENT ('Utilizatori',RESEED, 0)";
        private static string resetI = "DBCC CHECKIDENT ('Itemi', RESEED, 0)";
        private static string resete = "DBCC CHECKIDENT ('Evaluari',RESEED, 0)";
        private static void ExecuteSqlCommand(string cmdText, SqlConnection con)
        {
            SqlCommand cmdToExecute = new SqlCommand(cmdText, con);
            cmdToExecute.ExecuteNonQuery();
        } 

        public static void Delete()
        {
            using(SqlConnection con = new SqlConnection(connectionstring)) 
            {
                con.Open();
            
                ExecuteSqlCommand(delUtilizatori, con);
                ExecuteSqlCommand(delItemi, con);
                ExecuteSqlCommand(delEvaluari, con);
                ExecuteSqlCommand(resetU, con);
                ExecuteSqlCommand(resetI, con);
                ExecuteSqlCommand(resete, con);

            }
        }


        public static void Initialisation()
        {
            using(SqlConnection con = new SqlConnection(connectionstring))
            {
                con.Open();
                string cmdInsertUtilizatori = "Insert into Utilizatori (NumePrenumeUtilizator, ParolaUtilizator, EmailUtilizator, ClasaUtilizator) values (@nume, @parola, @email, @clasa)";
                string cmdInsertItemi = "Insert into Itemi (TipItem, EnuntItem, Raspuns1Item,Raspuns2Item, Raspuns3Item, Raspuns4Item, RaspunsCorectItem) values (@tip, @enunt, @r1, @r2,@r3,@r4,@rc)";
                string cmdInsertEvaluari = "Insert into Evaluari (IdElev, DataEvaluare, NotaEvaluare) values (@id, @data, @nota)";
                using (StreamReader reader =  new StreamReader(datepath)) 
                {
                    reader.ReadLine();
                   while(reader.Peek()>0) 
                    {
                        using(SqlCommand insertUtilizatori = new SqlCommand(cmdInsertUtilizatori, con))
                        {
                            string line= reader.ReadLine();
                            if(line == "Itemi:") { break; }
                            
                                string[] split = line.Split(';');
                                insertUtilizatori.Parameters.AddWithValue("@nume", split[0]);
                                insertUtilizatori.Parameters.AddWithValue("@parola", split[1]);
                                insertUtilizatori.Parameters.AddWithValue("@email", split[2]);
                                insertUtilizatori.Parameters.AddWithValue("@clasa", split[3]);
                                insertUtilizatori.ExecuteNonQuery();
                              
                                
                            
                        }
                    }
                    
                    while (reader.Peek()>0)
                    {
                        using (SqlCommand insertItemi= new SqlCommand(cmdInsertItemi, con))
                        {
                            string line = reader.ReadLine();
                            if (line == "Evaluari:") { break; }
                            
                                string[] split = line.Split(';');
                                insertItemi.Parameters.AddWithValue("@tip", Convert.ToInt32(split[0]));
                                insertItemi.Parameters.AddWithValue("@enunt", split[1]);
                                insertItemi.Parameters.AddWithValue("@r1", split[2]);
                                insertItemi.Parameters.AddWithValue("@r2", split[3]);
                                insertItemi.Parameters.AddWithValue("@r3", split[4]);
                                insertItemi.Parameters.AddWithValue("@r4", split[5]);
                                insertItemi.Parameters.AddWithValue("@rc", split[6]);
                                insertItemi.ExecuteNonQuery();
                                
                            
                        }
                    }
                   
                    while (reader.Peek() > 0)
                    {
                        using (SqlCommand insertEvaluari = new SqlCommand(cmdInsertEvaluari, con))
                        {
                            string line = reader.ReadLine();
                            string[] split = line.Split(';');
                            insertEvaluari.Parameters.AddWithValue("@id", Convert.ToInt32(split[0]));
                            insertEvaluari.Parameters.AddWithValue("@nota", Convert.ToInt32(split[2]));
                            DateTime data = DateTime.ParseExact(split[1], "M/d/yyyy hh:mm:ss tt", null);
                            insertEvaluari.Parameters.AddWithValue("@data", data);
                            insertEvaluari.ExecuteNonQuery();
                        }
                    }

                }
            }
            
  
        }
        public static int SearchUser(string email, string parola)
        {
            int ok;
            using(SqlConnection con = new SqlConnection(connectionstring))
            {
                con.Open();
                string cmdSelect = "Select count(*) from Utilizatori where EmailUtilizator = @email and ParolaUtilizator= @parola";
                using(SqlCommand cmd = new SqlCommand(cmdSelect, con))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@parola", parola);
                    ok = (int)cmd.ExecuteScalar(); 
                }
            }
            return ok;
        }

        public static DataTable RandomItems()
        {
            DataTable items = new DataTable();
            items.Columns.Add("Tip");
            items.Columns.Add("Enunt");
            items.Columns.Add("R1");
            items.Columns.Add("R2");
            items.Columns.Add("R3");
            items.Columns.Add("R4");
            items.Columns.Add("RC");
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                con.Open();
                string cmdText = @"SELECT TOP 9 *
                FROM(
                  SELECT *, ROW_NUMBER() OVER(PARTITION BY TipItem  ORDER BY NEWID()) AS RowNum
                  FROM Itemi
                ) AS SubQuery
                WHERE RowNum = 1";
                using (SqlCommand cmd = new SqlCommand(cmdText, con))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        items.Rows.Add(reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString());
                    }
                }
            }

            return items;
        }
    }
}
