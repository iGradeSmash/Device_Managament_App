using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Device_Management_App.Utility;

namespace Device_Management_App.Classes
{
    public class Connection
    {
        
       private  SqlCommand command;
        private SqlDataReader reader;
        private SqlDataAdapter adapter = new SqlDataAdapter();
        private SqlConnection sqlConnection = new SqlConnection(Constants.DATABASE_CONNECTION);
        string sqlStatement, sqlOutput = "";
        

        public void GetAllData(DataGridView dataGridView, string table)
        {
            List<Devices> devices = new List<Devices>();
            DataTable dataTable = new DataTable();
            dataGridView = new DataGridView();
            try
            {
                sqlConnection.Open();
                sqlStatement = $"SELECT * FROM {table}";
                command = new SqlCommand(sqlStatement, sqlConnection);

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    devices.Add(new Devices
                    {
                        Id = (int)reader.GetValue(0)
                    ,
                        Description = reader.GetValue(1).ToString()
                    ,
                        Type = reader.GetValue(2).ToString()
                    ,
                        Brand = reader.GetValue(3).ToString()
                    ,
                        Model = reader.GetValue(4).ToString()
                    ,
                        Barcode = reader.GetValue(5).ToString()
                    ,
                        Status = (Boolean)reader.GetValue(6)
                    });
                }

                
                dataTable.Load(reader);

                    dataGridView.DataSource = dataTable;
                
                    
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                reader.Close();
                sqlConnection.Close();
            }


        }

        public void SaveDeviceData(Devices devices)
        {
            try
            {
                sqlConnection.Open();
                sqlStatement = "INSERT INTO Devices([Description], [Type], [Brand], [Model],[Status])" +
                    $"VALUES('{devices.Description}','{devices.Type}','{devices.Brand}', '{devices.Model}', '{devices.Status}')";

                command = new SqlCommand(sqlStatement, sqlConnection);
                adapter.InsertCommand = new SqlCommand(sqlStatement, sqlConnection);
                adapter.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("From function save Data:"+devices.Description);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                command.Dispose();
                adapter.Dispose();
                sqlConnection.Dispose();
                sqlConnection.Close ();
            }
        }
    }
}
