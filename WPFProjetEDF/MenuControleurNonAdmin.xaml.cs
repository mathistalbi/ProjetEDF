using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPFProjetEDF
{
    /// <summary>
    /// Logique d'interaction pour MenuControleurNonAdmin.xaml
    /// </summary>
    public partial class MenuControleurNonAdmin : Window
    {
        edfEntities gst;
        public MenuControleurNonAdmin()
        {
            InitializeComponent();
        }

        private void lstClients_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void btnInsReleve_Click(object sender, RoutedEventArgs e)
        {
            if (txtReleve.Text == "")
            {
                MessageBox.Show("Veuillez inserer un relevé", "Votre choix", MessageBoxButton.OK, MessageBoxImage.Hand);
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            gst = new edfEntities();
            lstClients.ItemsSource = gst.client.ToList();
        }
    }
}
