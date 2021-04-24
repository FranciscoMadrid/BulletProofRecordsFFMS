using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Data;
using System.Data.SqlClient;

namespace BulletProofRecordsFFMS
{
    class Artista : BDConnection
    {
        public string ArtNombre { get; set; }
        public int Estado { get; set; }

        public Artista()
        {
            ArtNombre = null;
            Estado = 0;
        }

        public void InsertarArtista()
        {
            try
            {
                string spNombre = @"[dbo].[sp_Artista_Insert]";

                SqlCommand cmd = new SqlCommand(spNombre, sqlConnection);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Nombre", ArtNombre);
                cmd.Parameters.AddWithValue("@Estado", Estado);

                sqlConnection.Open();
                cmd.ExecuteNonQuery();
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

        public DataTable MostrarArtista()
        {
            DataTable dt = new DataTable();
            try
            {
                sqlConnection.Open();
                string spNombre = @"[dbo].[sp_Artista_Show]";

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
