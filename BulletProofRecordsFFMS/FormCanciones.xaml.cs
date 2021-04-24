using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data;

namespace BulletProofRecordsFFMS
{
    /// <summary>
    /// Interaction logic for FormCanciones.xaml
    /// </summary>
    public partial class FormCanciones : Window
    {
        Artista Art = new Artista();
        Albums Alb = new Albums();
        Canciones Can = new Canciones();
        public FormCanciones()
        {
            InitializeComponent();
            MostarAlbums();
            MostarCanciones();
        }

        private void btnIngresar_Click(object sender, RoutedEventArgs e)
        {
            if (CheckCancionDatos())
            {
                ObtenerCancionDatos();
                Can.InsertarCancion();
                Limpiador();
                MostarCanciones();
            }
        }

        private bool CheckCancionDatos ()
        {
            if (string.IsNullOrEmpty(txtNombreCancion.Text) || string.IsNullOrEmpty(txtArtistaID.Text) || string.IsNullOrEmpty(txtAlbumID.Text)
                || string.IsNullOrEmpty(txtGenero.Text) || string.IsNullOrEmpty(txtNombreCancion.Text))
            {
                MessageBox.Show("Por favor ingrese o selecione la informacion necesaria.");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void ObtenerCancionDatos ()
        {
            Can.NombreCancion = txtNombreCancion.Text;
            Can.FKArtistaID = int.Parse(txtArtistaID.Text);
            Can.FKAlbumID = int.Parse(txtAlbumID.Text);
            Can.Genero = txtGenero.Text;
            Can.AñoCreacion = txtAnioCreacion.Text;
        }

        private void Limpiador ()
        {
            foreach (Control ctr in GridGBInfoCancion.Children)
            {
                if (ctr.GetType() == typeof(TextBox))
                    ((TextBox)ctr).Text = string.Empty;
            }
        }

        private void MostarCanciones ()
        {
            dgCanciones.ItemsSource = Can.MostrarCanciones().DefaultView;
        }

        private void MostarAlbums()
        {
            dgAlbum.ItemsSource = Alb.MostrarAlbum().DefaultView;
        }

        private void dgAlbum_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataRowView dataRow = (DataRowView)dgAlbum.SelectedItem;

            if (dataRow != null)
            {
                txtAlbumID.Text = dataRow[0].ToString();
                txtArtistaID.Text = dataRow[3].ToString();
            }
        }

        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            Limpiador();
        }

        private void btnRegresar_Click(object sender, RoutedEventArgs e)
        {
            MenuPrincipal n2 = new MenuPrincipal();
            n2.Show();
            this.Close();
        }
    }
}
