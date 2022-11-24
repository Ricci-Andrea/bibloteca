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

namespace Bibloteca_Ricci
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        Bibloteca b;
        private void aggiungi_Libro__Click(object sender, RoutedEventArgs e)
        {
            Libro libro = new();
            txtTitotolo.Text = libro.titolo;
            txtNUmPag.Text = libro.numeroDiPagine.ToString();
            txtAnnoDiPublicazione.Text = libro.AnnoDiPublicazione;
            txtNomeLBr.Text = libro.Autore;
            txtEditore.Text = libro.Editore;
            new Bibloteca(libro);


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string tittolo="";
            txtTtitoloRic.Text = tittolo;
            string tittoloCheStatoRicercato;
            tittoloCheStatoRicercato = b.ricercaLibroPerTtitolo(tittolo);
            lstRisRic.Items.Add(tittoloCheStatoRicercato);
        }
    }
}
