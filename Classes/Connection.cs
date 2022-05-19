using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using Device_Managament_App.Utility;

namespace Device_Management_App.Classes
{
    public class Connection
    {

        private SqlCommand command;
        private SqlDataReader reader;
        private SqlDataAdapter adapter;
        private SqlConnection sqlConnection = new SqlConnection(UtilManager.Constants.DATABASE_CONNECTION);
        string sqlStatement= "";
        private DataTable dataTable;

        /***************Device Data Scripts*****************/
        
        //Gets all Devices from the Database
        public void GetAllData(DataGridView dataGridView)
        {
            DataTable dataTable = new DataTable();
            dataGridView = new DataGridView();
            try
            {
                sqlConnection.Open();
                sqlStatement = $"SELECT * FROM {UtilManager.Constants.TABLE_NAME_DEVICES}";
                command = new SqlCommand(sqlStatement, sqlConnection);

                reader = command.ExecuteReader();

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
        
        //Inserts a Device Into the Databse
        public void SaveDeviceData(Devices devices)
        {
            try
            {
                adapter = new SqlDataAdapter();
                sqlConnection.Open();
                sqlStatement = "INSERT INTO"+ UtilManager.Constants.TABLE_NAME_DEVICES+ "([Description], [Type], [Brand], [Model],[Barcode],[Status], [IsAvailable], [BorrowerId],[ExpectedReturnDate])" +
                    $"VALUES('{devices.Description}','{devices.Type}','{devices.Brand}', '{devices.Model}', '{devices.Barcode}','{devices.Status}', '{devices.IsAvailable}','{devices.BorrowerId}','{devices.ExpectedReturnDate}')";

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

        //Updates a Device in the Database
        public void UpdateDeviceData(Devices devices)
        {
            try
            {
                sqlConnection.Open();
                adapter = new SqlDataAdapter();
                sqlStatement = $"UPDATE {UtilManager.Constants.TABLE_NAME_DEVICES} SET [Description] = '{devices.Description}', [Type] = '{devices.Type}', [Brand] ='{devices.Brand}', [Model]='{devices.Model}', [Barcode] ='{devices.Barcode}', [Status] = '{devices.Status}', [IsAvailable] ='{devices.IsAvailable}', [BorrowerId] = '{devices.BorrowerId}', [ExpectedReturnDate] = '{devices.ExpectedReturnDate}' WHERE Id = '{devices.Id}'";

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

        //Gets all Devices from the Database
        public void GetDeviceData(DataGridView dataGridView)
        {

            sqlStatement = $"SELECT * FROM {UtilManager.Constants.TABLE_NAME_DEVICES}";

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

        //Gets all available Devices from the Database
        public void GetAvailableDeviceData(DataGridView dataGridView)
        {

            sqlStatement = $"SELECT * FROM {UtilManager.Constants.TABLE_NAME_DEVICES} Where IsAvailable = 1";

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

        /***************Active Search Script****************/

        //Gets search results with the relevant Criteria from the Database
        public void Search(string txtBox, string option,string table ,DataGridView dataGridView)
        {
            sqlStatement = $"SELECT * FROM [{table}] WHERE [{option}] LIKE '%{txtBox}%'";

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


        /***************User Data Script*******************/

        //Gets the Current user ID from the Database
        public void GetUserID(string email, string password)
        {
            try
            {
              sqlStatement = $"SELECT * FROM {UtilManager.Constants.TABLE_NAME_USERS} WHERE Email='{email}' AND Password='{password}'";
                sqlConnection.Open();
                command= new SqlCommand(sqlStatement, sqlConnection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    UtilManager.Variables.UserID = reader.GetInt32(0);
                    UtilManager.Variables.RoleId = reader.GetInt32(1);
                    UtilManager.Variables.UserName = reader.GetString(2);
                }
                sqlConnection.Close();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Inserts a new user into the Database
        public void CreateUser(User user)
        {
            try
            {
                sqlConnection.Open();
                adapter = new SqlDataAdapter();
                sqlStatement = $@"INSERT INTO {UtilManager.Constants.TABLE_NAME_USERS}([RoleId], [Name], [Address], [Telephone],[Email], [Department], [Description],[CreatedAt], [Password])" +
                    $@"VALUES('{user.RoleId}','{user.Name}','{user.Address}','{user.Telephone}','{user.Email}','{user.Department}','{user.Description}',GETDATE(),'{UtilManager.Validation.PasswordEncode(user.Password)}')";
                    command = new SqlCommand(sqlStatement, sqlConnection);
                    adapter.InsertCommand = command;
                    adapter.InsertCommand.ExecuteNonQuery();
                MessageBox.Show($"{user.Name} Created Successfully!");
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                command.Dispose();
                adapter.Dispose();
                sqlConnection.Dispose();
                sqlConnection.Close();
            }
        }

        //Updates a user in the Database
        public void UpdateUser(User user)
        {
            try
            {
                sqlConnection.Open();
                adapter = new SqlDataAdapter();
                sqlStatement = $"UPDATE {UtilManager.Constants.TABLE_NAME_USERS}" +
                    $"SET [RoleId] ='{user.RoleId}',[Name]='{user.Name}', [Address]='{user.Address}', [Telephone]='{user.Telephone}',[Email]='{user.Email}', [Department]='{user.Department}', [Description]='{user.Description}',[CreatedAt] =GETDATE(), [Password] = '{UtilManager.Validation.PasswordEncode(user.Password)}'";
                command = new SqlCommand(sqlStatement, sqlConnection);
                adapter.UpdateCommand = command;
                adapter.UpdateCommand.ExecuteNonQuery();
                MessageBox.Show($"{user.Name} Updated Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                command.Dispose();
                adapter.Dispose();
                sqlConnection.Dispose();
                sqlConnection.Close();
            }
        }

        //Gets all users from the Database
        public void GetAllUsers(DataGridView dataGridView)
        {
            try
            {
                dataTable = new DataTable();
                sqlConnection.Open();
                sqlStatement = $"SELECT * FROM {UtilManager.Constants.TABLE_NAME_USERS}";
                adapter = new SqlDataAdapter(sqlStatement, sqlConnection);
                adapter.Fill(dataTable);
                dataTable = new DataTable();

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close ();
            }
        }

    }
}
