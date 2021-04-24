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
    /// Interaction logic for FormAlbums.xaml
    /// </summary>
    public partial class FormAlbums : Window
    {
        Artista Art = new Artista();
        Albums Alb = new Albums();
        public FormAlbums()
        {
            InitializeComponent();
            MostarArtistas();
            MostarAlbums();
        }

        private void btnIngresar_Click(object sender, RoutedEventArgs e)
        {
            if (CheckAlbumDatos())
            {
                ObtenerAlbumDatos();
                Alb.InsertarAlbum();
                MostarAlbums();
                Limpiador();
            }
        }

        private bool CheckAlbumDatos()
        {
            if (string.IsNullOrEmpty(txtNombreAlbum.Text) || string.IsNullOrEmpty(txtArtistaId.Text))
            {
                MessageBox.Show("Por favor, llene o selecione la informacion necesaria.");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void ObtenerAlbumDatos()
        {
            Alb.NombreAlbum = txtNombreAlbum.Text;
            Alb.FKArtista = int.Parse(txtArtistaId.Text);
        } 

        private void MostarAlbums ()
        {
            dgAlbums.ItemsSource = Alb.MostarAlbum().DefaultView;
        }

        private void MostarArtistas ()
        {
            dgArtistas.ItemsSource = Art.MostrarArtista().DefaultView;
        }

        private void dgArtistas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataRowView dataRow = (DataRowView)dgArtistas.SelectedItem;

            if (dataRow != null)
            {
                txtArtistaId.Text = dataRow[0].ToString();
            }
        }

        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            Limpiador();
        }

        private void Limpiador ()
        {
            foreach (Control ctr in GridgbAlbumDatos.Children)
            {
                if (ctr.GetType() == typeof(TextBox))
                    ((TextBox)ctr).Text = string.Empty;
            }
        }

        private void btnRegresar_Click(object sender, RoutedEventArgs e)
        {
            MenuPrincipal n2 = new MenuPrincipal();
            n2.Show();
            this.Close();
        }
    }
}
