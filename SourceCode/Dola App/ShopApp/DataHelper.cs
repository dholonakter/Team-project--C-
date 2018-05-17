﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace EntranceApp
{
    public class DataHelper
    {
        public MySqlConnection connection;

        public DataHelper()
        {
            String connectionInfo = "server=studmysql01.fhict.local;" +//the hera-server
                                    "database=dbi364365;" +
                                    "user id=dbi364365;" +
                                    "password=Dholon;";

            connection = new MySqlConnection(connectionInfo);
        }
        public Visitors GetVisitor()
        {
            Visitors visitor = null;
            return visitor;
        }


        public List<Visitors> GetAllVisitors()
        {
            String sql = "SELECT * FROM Persons";
            MySqlCommand command = new MySqlCommand(sql, connection);

            List<Visitors> temp;
            temp = new List<Visitors>();

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                int id;
                string name;
                int rfid;
                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["Id"]);
                    name = Convert.ToString(reader["Name"]);
                    rfid = Convert.ToInt32(reader["RFID"]);
                    temp.Add(new Visitors(id, name, rfid));
                }
            }
            catch
            {
                MessageBox.Show("error while loading the persons");
            }
            finally
            {
                connection.Close();
            }
            return temp;
        }

        public int AddVisitor(int id, string name, int rfid)
        {   //Probably you expected a return-value of type bool:
            //true if the query was executed succesfully and false otherwise.
            //But what if you executed a delete-query? Or an update-query?
            //The return-value is teh number of records affected.

            String sql = "INSERT INTO Persons VALUES (@name, @id, @rfid )";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@number", id);
            command.Parameters.AddWithValue("@rfid", rfid);

            //On internet you also see a solution like:
            // String sql = "INSERT INTO StudentTable VALUES (" +
            //     "'" + name + "'," + number  + "," + creditpoints + ")";
            //Be aware of sql-injection!

            try
            {
                connection.Open();
               int nrOfRecordsChanged = command.ExecuteNonQuery();
               return nrOfRecordsChanged;
            }
            catch
            {
                return -1; //which means the try-block was not executed succesfully, so  . . .
            }
            finally
            {
                connection.Close();
            }
        }

        
    }
}
