using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Data;
using System.Data.SqlClient;

namespace BulletProofRecordsFFMS
{
    class Reporte : BDConnection
    {
        public Reporte()
        {

        }

        public DataTable MostarReporte ()
        {
            DataTable dt = new DataTable();
            try
            {
                sqlConnection.Open();
                string spNombre = @"[dbo].[sp_Reporte_Show]";

                SqlCommand cmd = new SqlCommand(spNombre, sqlConnection);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();

                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                dataAdapter.Fill(dt);
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

            return dt;
        }
    }
}
