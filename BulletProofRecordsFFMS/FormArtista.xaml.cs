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
    /// Interaction logic for FormArtista.xaml
    /// </summary>
    public partial class FormArtista : Window
    {
        Artista Art = new Artista();
        public FormArtista()
        {
            InitializeComponent();
            MostarArtistas();
        }

        private void btnIngresar_Click(object sender, RoutedEventArgs e)
        {
            if(CheckArtistaDatos())
            {
                ObtenerArtistaDatos();
                Art.InsertarArtista();
                Limpiador();
                MostarArtistas();
            }
        }

        private bool CheckArtistaDatos ()
        {
            if (string.IsNullOrEmpty(txtArtNombre.Text) || cmbEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, llene la informacion necesaria en las casillas");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void ObtenerArtistaDatos()
        {
            Art.ArtNombre = txtArtNombre.Text;
            Art.Estado = cmbEstado.SelectedIndex;
        }

        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            Limpiador();
        }

        private void MostarArtistas()
        {
            dgArtista.ItemsSource = Art.MostrarArtista().DefaultView;
        }
        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            MenuPrincipal n2 = new MenuPrincipal();
            n2.Show();
            this.Close();
        }

        private void Limpiador ()
        {
            foreach (Control ctr in gridGBDatosArtista.Children)
            {
                if (ctr.GetType() == typeof(TextBox))
                    ((TextBox)ctr).Text = string.Empty;
                if (ctr.GetType() == typeof(ComboBox))
                    ((ComboBox)ctr).SelectedIndex = -1;
            }
        }
    }
}
