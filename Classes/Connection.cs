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

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }

        }

        //Gets all available Devices from the Database
        public void GetAvailableDeviceData(DataGridView dataGridView)
        {

            sqlStatement = $"SELECT * FROM {UtilManager.Constants.TABLE_NAME_DEVICES} WHERE [IsAvailable] = 1 AND [Status] = 1";

            try
            {

                dataTable = new DataTable();
                sqlConnection.Open();
                adapter = new SqlDataAdapter(sqlStatement, sqlConnection);
                adapter.Fill(dataTable);
                dataGridView.DataSource = dataTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                adapter.Dispose();
                sqlConnection.Close();
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

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }


        /***************User Data Script*******************/

        //Gets the Current user ID from the Database
        public void GetUserID(string email, string password)
        {
            try
            {
              sqlStatement = $"SELECT TOP(1)* FROM {UtilManager.Constants.TABLE_NAME_USERS} WHERE Email='{email}' AND Password='{password}'";
                sqlConnection.Open();
                command= new SqlCommand(sqlStatement, sqlConnection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    UtilManager.Variables.UserID = reader.GetInt32(0);
                    UtilManager.Variables.RoleId = reader.GetInt32(1);
                    UtilManager.Variables.UserName = reader.GetString(2);
                    UtilManager.Variables.Department = reader.GetString(6);
                    UtilManager.Variables.Description = reader.GetString(7);

                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
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
                    adapter.InsertCommand = new SqlCommand(sqlStatement,sqlConnection);
                    adapter.InsertCommand.ExecuteNonQuery();
                MessageBox.Show($"{user.Name} Created Successfully!");
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
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
                sqlStatement = "UPDATE " + UtilManager.Constants.TABLE_NAME_USERS + "SET [RoleId] ='" + user.RoleId + "', [Name]='" + user.Name + "', [Address]='" + user.Address + "', [Telephone]='" + user.Telephone + "', [Department]='" + user.Department + "', [Description]='" + user.Description + "' WHERE [Id] =" + user.Id;
                command = new SqlCommand(sqlStatement, sqlConnection);
                adapter.UpdateCommand = new SqlCommand(sqlStatement, sqlConnection);
                adapter.UpdateCommand.ExecuteNonQuery();

                MessageBox.Show($"{user.Name} Updated Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                            sqlConnection.Close();
            }
        }
        
        //Updates user Password
        public void UpdateUserPassword(string password, int id)
        {
            try
            {
                sqlConnection.Open();
                adapter = new SqlDataAdapter();
                sqlStatement = $"UPDATE {UtilManager.Constants.TABLE_NAME_USERS} SET [password] = '{password}' WHERE [Id] = '{id}'";
                command = new SqlCommand(sqlStatement, sqlConnection);
                adapter.UpdateCommand = new SqlCommand(sqlStatement, sqlConnection);
                adapter.UpdateCommand.ExecuteNonQuery();

                MessageBox.Show($"Updated Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }
        
        //Checks if user password is valid
        public bool IsValidPassword(string password, int id)
        {
            bool isValid = false;
            try
            {
                sqlStatement = $"SELECT TOP(1)* FROM {UtilManager.Constants.TABLE_NAME_USERS} WHERE [id]='{id}' AND Password='{password}'";
                sqlConnection.Open();
                command = new SqlCommand(sqlStatement, sqlConnection);
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isValid= true;
                }
                sqlConnection.Close();
                return isValid;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
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


        //Populates Devices in Device Request Form
        public  Devices PopulateRequest(int id)
        {
            Devices dev = new Devices();

            try
            {
                sqlStatement = $"SELECT * FROM Devices WHERE [Id] = {id} and [Status]=1";
                sqlConnection.Open();
                command = new SqlCommand(sqlStatement, sqlConnection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    dev.Id = reader.GetInt32(0);
                    dev.Description = reader.GetString(1);
                    dev.Type = reader.GetString(2);
                    dev.Brand = reader.GetString(3);
                    dev.Model = reader.GetString(4);
                    dev.Barcode = reader.GetString(5);
                    dev.Status = reader.GetBoolean(6);
                    dev.IsAvailable = reader.GetBoolean(7);
                    dev.BorrowerId=reader.GetInt32(8);
                    dev.ExpectedReturnDate = reader.GetDateTime(9);
                }
                return  dev;
            }catch(Exception ex)
            {
                MessageBox.Show (ex.Message);
                return dev;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public void SubmitRequest(DeviceManager deviceManager)
        {
            adapter = new SqlDataAdapter();
            try
            {
                sqlStatement = $"INSERT INTO [Device_Manager]([User_Id], [Device_Id],[Technician_Id], [Admin_Id], [Name], [Department], [Description], [Brand], [Type], [Model], [Barcode], [Status], [TransactionType], [TransactionDate])" +
                    $"VALUES('{deviceManager.UserId}','{deviceManager.DeviceId}','{deviceManager.TechnicianId}'," +
                    $"'{deviceManager.AdminId}','{deviceManager.Name}','{deviceManager.Department}','{deviceManager.Description}'," +
                    $"'{deviceManager.Brand}','{deviceManager.Type}','{deviceManager.Model}','{deviceManager.Barcode}','{deviceManager.Status}','{deviceManager.TransactionType}',CONVERT(DATE,'{deviceManager.TransactionDate}',103))";
                sqlConnection.Open();
                command = new SqlCommand(sqlStatement, sqlConnection);
                adapter.InsertCommand = command;
                adapter.InsertCommand.ExecuteNonQuery();
                MessageBox.Show($"Request For Device: {deviceManager.Model} Submited Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }finally
            {
                sqlConnection.Close();
            }
        }

        public void LoadHistory(DataGridView dgvHistory, int id)
        {
            dataTable = new DataTable();
            sqlStatement = $"SELECT * FROM [TransactionHistory] WHERE [BorrowerId] = {id}";
            try
            {
                sqlConnection.Open();
                adapter = new SqlDataAdapter(sqlStatement, sqlConnection);
                adapter.Fill(dataTable);
                dgvHistory.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public void LoadHistory(DataGridView dgvHistory)
        {
            dataTable = new DataTable();
            sqlStatement = $"SELECT * FROM [Device_Manager] WHERE [DecisionDate] is NULL ";
            try
            {
                sqlConnection.Open();
                adapter = new SqlDataAdapter(sqlStatement, sqlConnection);
                adapter.Fill(dataTable);
                dgvHistory.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public void UpdateDeviceManagerRequest(int id, bool status, int userId,int deviceId,string transactiontype, bool isApproved, int technicianId)
        {
            try
            {
             
                sqlStatement = $@"UPDATE [DEVICE_MANAGER] SET Status = '{status}', TransactionType ='{transactiontype}', Technician_Id = '{technicianId}',IsApproved = '{isApproved}', DecisionDate = GETDATE() WHERE Id = {id}";
                sqlConnection.Open();
                command = new SqlCommand(sqlStatement, sqlConnection);
                command.ExecuteNonQuery();

                sqlStatement = $@"UPDATE [DEVICES] SET IsAvailable = '{status}', BorrowerId = '{userId}' WHERE Id = {deviceId}";
                //Update Device Table
                if (transactiontype == "Denied")
                {
                    sqlStatement = $@"UPDATE [DEVICES] SET IsAvailable = '{status}' WHERE Id = {deviceId}";
                }
               
                command = new SqlCommand(sqlStatement, sqlConnection);
                command.ExecuteNonQuery();



                if (isApproved)
                {
                    MessageBox.Show("Request Approved");
                }
                else
                {
                    MessageBox.Show("Request Denied");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}