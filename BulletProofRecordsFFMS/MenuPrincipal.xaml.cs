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

namespace BulletProofRecordsFFMS
{
    /// <summary>
    /// Interaction logic for MenuPrincipal.xaml
    /// </summary>
    public partial class MenuPrincipal : Window
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnArtista_Click(object sender, RoutedEventArgs e)
        {
            FormArtista n2 = new FormArtista();
            n2.Show();
            this.Close();
        }

        private void btnAlbum_Click(object sender, RoutedEventArgs e)
        {
            FormAlbums n2 = new FormAlbums();
            n2.Show();
            this.Close();
        }

        private void btnCancion_Click(object sender, RoutedEventArgs e)
        {
            FormCanciones n2 = new FormCanciones();
            n2.Show();
            this.Close();
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnReporte_Click(object sender, RoutedEventArgs e)
        {
            FormReporte n2 = new FormReporte();
            n2.Show();
            this.Close();
        }
    }
}
