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
    /// Logique d'interaction pour MenuControleur.xaml
    /// </summary>
    public partial class MenuControleur : Window
    {
        edfEntities gst;
        int idControleur;
        int idClient;
        public MenuControleur()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            gst = new edfEntities();
            lstControleurs.ItemsSource = gst.controleur.ToList();
            lstClients.ItemsSource = gst.client.ToList();
        }

        private void btnInsControleur_Click(object sender, RoutedEventArgs e)
        {
            if (txtPrenomControleur.Text == "" && txtNomControleur.Text == "")
            {
                MessageBox.Show("Veuillez entrer le prenom et le nom du controleur", "Votre choix", MessageBoxButton.OK, MessageBoxImage.Hand);
            }
            else if (txtPrenomControleur.Text == "" && txtNomControleur.Text != "")
            {
                MessageBox.Show("Veuillez entrer le prenom du controleur", "Votre choix", MessageBoxButton.OK, MessageBoxImage.Hand);
            }
            else if (txtPrenomControleur.Text != "" && txtNomControleur.Text == "")
            {
                MessageBox.Show("Veuillez entrer le nom du controleur", "Votre choix", MessageBoxButton.OK, MessageBoxImage.Hand);
            }
            else
            {
                MessageBox.Show("Enregistrement", "Votre choix", MessageBoxButton.OK, MessageBoxImage.Hand);
            }
        }

        private void lstControleurs_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void lstClients_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
