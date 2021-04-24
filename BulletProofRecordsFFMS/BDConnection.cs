using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace BulletProofRecordsFFMS
{
    class BDConnection
    {
        private static string SQLConnectionString = @"server = (local)\SQLEXPRESS; Initial Catalog = BulletProofRecords; Integrated Security = True";

        protected SqlConnection sqlConnection = new SqlConnection(SQLConnectionString);
        
        
        public BDConnection()
        {

        }

        public void CheckConnection()
        {
            try
            {
                sqlConnection.Open();
                MessageBox.Show("Estas connectado a " + sqlConnection.Database.ToString() + " exitosamente!!");
            }
            catch (Exception ex)
            {
                sqlConnection.Close();
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}
