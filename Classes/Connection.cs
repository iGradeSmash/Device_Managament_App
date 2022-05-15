using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using Device_Managament_App.Utility;
using Device_Management_App.Utility;

namespace Device_Management_App.Classes
{
    public class Connection
    {

        private SqlCommand command;
        private SqlDataReader reader;
        private SqlDataAdapter adapter;
        private SqlConnection sqlConnection = new SqlConnection(Constants.DATABASE_CONNECTION);
        string sqlStatement, sqlOutput = "";
        private DataTable dataTable;


        public async Task GetAllData(DataGridView dataGridView, string table)
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


            }
            catch (Exception ex)
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
                adapter = new SqlDataAdapter();
                sqlConnection.Open();
                sqlStatement = "INSERT INTO Devices([Description], [Type], [Brand], [Model],[Barcode],[Status])" +
                    $"VALUES('{devices.Description}','{devices.Type}','{devices.Brand}', '{devices.Model}', '{devices.Barcode}','{devices.Status}')";

                command = new SqlCommand(sqlStatement, sqlConnection);
                adapter.InsertCommand = new SqlCommand(sqlStatement, sqlConnection);
                adapter.InsertCommand.ExecuteNonQuery();

                MessageBox.Show($"Success - Device{devices.Description} Saved!");

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

        public void UpdateDeviceData(Devices devices)
        {
            try
            {
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

            sqlStatement = "SELECT * FROM [Devices]";

            try
            {

                dataTable = new DataTable();
                sqlConnection.Open();
                adapter = new SqlDataAdapter(sqlStatement, sqlConnection);
                adapter.Fill(dataTable);
                dataGridView.DataSource = dataTable;
                sqlConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void GetAvailableDeviceData(DataGridView dataGridView)
        {

            sqlStatement = "SELECT * FROM [Devices] Where Status = 1";

            try
            {

                dataTable = new DataTable();
                sqlConnection.Open();
                adapter = new SqlDataAdapter(sqlStatement, sqlConnection);
                adapter.Fill(dataTable);
                dataGridView.DataSource = dataTable;
                sqlConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void Search(string txtBox, string option, DataGridView dataGridView)
        {
            sqlStatement = $"SELECT * FROM [Devices] WHERE [{option}] LIKE '%{txtBox}%'";

            try
            {

                dataTable = new DataTable();
                sqlConnection.Open();
                adapter = new SqlDataAdapter(sqlStatement, sqlConnection);
                adapter.Fill(dataTable);
                dataGridView.DataSource = dataTable;
                sqlConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void GetUserID(string email, string password)
        {
            try
            {
              sqlStatement = $"SELECT * FROM Users WHERE Email='{email}' AND Password='{password}'";
                sqlConnection.Open();
                command= new SqlCommand(sqlStatement, sqlConnection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                   GlobalVariables.UserID = reader.GetInt32(0);
                   GlobalVariables.RoleId = reader.GetInt32(1);
                   GlobalVariables.UserName = reader.GetString(5);
                }
                sqlConnection.Close();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
