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
    /// Interaction logic for FormReporte.xaml
    /// </summary>
    public partial class FormReporte : Window
    {
        Reporte Rep = new Reporte();
        public FormReporte()
        {
            InitializeComponent();
            MostarReporte();
        }
        public void MostarReporte ()
        {
            dgReporteria.ItemsSource = Rep.MostarReporte().DefaultView;
        }

        private void btnRegresar_Click(object sender, RoutedEventArgs e)
        {
            MenuPrincipal n2 = new MenuPrincipal();
            n2.Show();
            this.Close();
        }
    }
}
