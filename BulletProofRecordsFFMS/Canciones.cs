using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Data;
using System.Data.SqlClient;

namespace BulletProofRecordsFFMS
{
    class Canciones : BDConnection
    {
        public string NombreCancion { get; set; }
        public int FKArtistaID { get; set; }
        public int FKAlbumID { get; set; }
        public string Genero { get; set; }
        public string AñoCreacion { get; set; }

        public Canciones ()
        {
            NombreCancion = null;
            FKArtistaID = 0;
            FKAlbumID = 0;
            Genero = null;
            AñoCreacion = null;
        }

        public void InsertarCancion()
        {
            try
            {
                string spNombre = @"[dbo].[sp_Cancion_Insert]";

                SqlCommand cmd = new SqlCommand(spNombre, sqlConnection);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Nombre", NombreCancion);
                cmd.Parameters.AddWithValue("@FKArtistaID", FKArtistaID);
                cmd.Parameters.AddWithValue("@FKAlbumID", FKAlbumID);
                cmd.Parameters.AddWithValue("@Genero", Genero);
                cmd.Parameters.AddWithValue("@AnioCreacion", AñoCreacion);

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

        public DataTable MostrarCanciones ()
        {
            DataTable dt = new DataTable();
            try
            {
                sqlConnection.Open();
                string spNombre = @"[dbo].[sp_Cancion_Show]";

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
