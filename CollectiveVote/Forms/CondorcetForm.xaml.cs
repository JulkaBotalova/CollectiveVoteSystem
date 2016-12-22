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

namespace CollectiveVote.Forms
{
    /// <summary>
    /// Interaction logic for Condorcet.xaml
    /// </summary>
    public partial class CondorcetForm : Window
    {
        private Vote.Condorcet.Winner Win;
        private Vote.Condorcet.Kopland Kopland;
        private Vote.Condorcet.Simpson Simpson;
        private int quantity;
        private int i = 0;
        int[] Eg = new int[20];
        int[] Gr = new int[20];
        int[] Cr = new int[20];

        public CondorcetForm()
        {
            InitializeComponent();
            WinnerB.Visibility = Visibility.Hidden;
            SimpsonB.Visibility = Visibility.Hidden;
            KoplandB.Visibility = Visibility.Hidden;
        }


        private void NextB_Click(object sender, RoutedEventArgs e)
        {
            quantity = Int32.Parse(QuantityTB.Text);


            Gr[i] = int.Parse(TBGreece.Text);
            Cr[i] = int.Parse(TBCrimea.Text);
            Eg[i] = int.Parse(TBEgypt.Text);

            TBCrimea.Clear();
            TBGreece.Clear();
            TBEgypt.Clear();

            i = i + 1;
            if (i == quantity - 1)
            {
                NextB.Content = "Вывести результат";
            }

            if (i == quantity)
            {
                i = 0;
                WinnerB.Visibility = Visibility.Visible;
                SimpsonB.Visibility = Visibility.Visible;
                KoplandB.Visibility = Visibility.Visible;
            }
        }


        private void WinnerB_Click(object sender, RoutedEventArgs e)
        {
            Win = new Vote.Condorcet.Winner();
            MessageBox.Show(Win.Win(quantity, Gr, Eg, Cr));
        }

        private void KoplandB_Click(object sender, RoutedEventArgs e)
        {
            Kopland = new Vote.Condorcet.Kopland();
            MessageBox.Show(Kopland.MethodKopland(quantity, Gr, Eg, Cr));
        }

        private void SimpsonB_Click(object sender, RoutedEventArgs e)
        {
            Simpson = new Vote.Condorcet.Simpson();
            MessageBox.Show(Simpson.MethodSimpson(quantity, Gr, Eg, Cr));
        }
    }
}
