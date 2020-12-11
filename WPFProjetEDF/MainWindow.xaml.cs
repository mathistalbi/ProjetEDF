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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFProjetEDF
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        edfEntities gst;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            gst = new edfEntities();
        }

        private void btnConnexion_Click(object sender, RoutedEventArgs e)
        {
            {
                if (txtLogin.Text == "" && txtMdp.Text == "")
                {
                    MessageBox.Show("Veuillez entrer un login et un mot de passe", "Votre choix", MessageBoxButton.OK, MessageBoxImage.Hand);
                }
                else if (txtLogin.Text == "" && txtMdp.Text != "")
                {
                    MessageBox.Show("Veuillez entrer un login", "Votre choix", MessageBoxButton.OK, MessageBoxImage.Hand);
                }
                else if (txtLogin.Text != "" && txtMdp.Text == "")
                {
                    MessageBox.Show("Veuillez entrer un mot de passe", "Votre choix", MessageBoxButton.OK, MessageBoxImage.Hand);
                }
                else
                {
                    controleur monControleur = gst.controleur.ToList().Find(ctrl => ctrl.login == txtLogin.Text && ctrl.mdp == txtMdp.Text);
                    if (monControleur == null)
                    {
                        MessageBox.Show("Mauvais identifiants", "Votre choix", MessageBoxButton.OK, MessageBoxImage.Hand);
                    }
                    else
                    {
                        if (monControleur.statut == "admin")
                        {
                            MenuControleur frm = new MenuControleur();
                            frm.Show();
                        }
                        else
                        {
                            MenuControleurNonAdmin frm = new MenuControleurNonAdmin();
                            frm.Show();
                        }
                    }
                }
            }
        }
    }
}
