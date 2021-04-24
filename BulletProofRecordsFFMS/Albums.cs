using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Data;
using System.Data.SqlClient;

namespace BulletProofRecordsFFMS
{
    class Albums : BDConnection
    {
        public string NombreAlbum { get; set; }
        public int FKArtista { get; set; }

        public Albums ()
        {
            NombreAlbum = null;
            FKArtista = 0;
        }

        public void InsertarAlbum ()
        {
            try
            {
                string spNombre = @"[dbo].[sp_Album_Insert]";

                SqlCommand cmd = new SqlCommand(spNombre, sqlConnection);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Nombre", NombreAlbum);
                cmd.Parameters.AddWithValue("@FKArtistaID", FKArtista);

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

        public DataTable MostarAlbum()
        {
            DataTable dt = new DataTable();
            try
            {
                sqlConnection.Open();
                string spNombre = @"[dbo].[sp_Album_Show]";

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
