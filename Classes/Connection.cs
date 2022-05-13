using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using Device_Management_App.Utility;

namespace Device_Management_App.Classes
{
    public class Connection
    {
        
       private  SqlCommand command;
        private SqlDataReader reader;
        private SqlDataAdapter adapter;
        private SqlConnection sqlConnection;
        string sqlStatement, sqlOutput = "";
        private DataTable dataTable;
        

        public async Task GetAllData(DataGridView dataGridView, string table)
        {
            List<Devices> devices = new List<Devices>();
            DataTable dataTable = new DataTable();
            dataGridView = new DataGridView();
            try
            {
                sqlConnection = new SqlConnection(Constants.DATABASE_CONNECTION);
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
                sqlConnection = new SqlConnection(Constants.DATABASE_CONNECTION);
                adapter = new SqlDataAdapter();
                sqlConnection.Open();
                sqlStatement = "INSERT INTO Devices([Description], [Type], [Brand], [Model],[Barcode],[Status])" +
                    $"VALUES('{devices.Description}','{devices.Type}','{devices.Brand}', '{devices.Model}', '{devices.Barcode}','{devices.Status}')";

                command = new SqlCommand(sqlStatement, sqlConnection);
                adapter.InsertCommand = new SqlCommand(sqlStatement, sqlConnection);
                adapter.InsertCommand.ExecuteNonQuery();

                MessageBox.Show($"Success - Device{devices.Description} Saved!");

            }catch(Exception ex)
            {
                MessageBox.Show("Error: "+ex.Message);
            }
            finally
            {
                command.Dispose();
                adapter.Dispose();
                sqlConnection.Dispose();
                sqlConnection.Close ();
            }
        }

        public void UpdateDeviceData(Devices devices)
        {
            try
            {
                sqlConnection= new SqlConnection(Constants.DATABASE_CONNECTION);
                sqlConnection.Open();
                adapter = new SqlDataAdapter();
                sqlStatement = $"UPDATE Devices SET [Description] = '{devices.Description}', [Type] = '{devices.Type}', [Brand] ='{devices.Brand}', [Model]='{devices.Model}', [Barcode] ='{devices.Barcode}', [Status] = '{devices.Status}'WHERE Id = '{devices.Id}'";

                command = new SqlCommand(sqlStatement, sqlConnection);
                adapter.UpdateCommand = new SqlCommand(sqlStatement, sqlConnection);
                adapter.UpdateCommand.ExecuteNonQuery();

                MessageBox.Show($"Success - Device{devices.Description} Upated!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                command.Dispose();
                adapter.Dispose();
                sqlConnection.Dispose();
                sqlConnection.Close();
            }
        }

        public void GetDeviceData(DataGridView dataGridView)
        {

            sqlStatement = "Select * from [Devices]";
            
            try
            {
                
                dataTable = new DataTable();
                sqlConnection = new SqlConnection(Constants.DATABASE_CONNECTION);
                sqlConnection.Open();
                adapter = new SqlDataAdapter(sqlStatement, sqlConnection);
                adapter.Fill(dataTable);
                dataGridView.DataSource = dataTable;
                sqlConnection.Close();

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}
