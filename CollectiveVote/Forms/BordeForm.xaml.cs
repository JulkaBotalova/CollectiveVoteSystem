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
    /// Interaction logic for Borde.xaml
    /// </summary>
    public partial class BordeForm : Window
    {
        private Vote.Borde Bord;
        private int quantity;
        private int i = 0;
            //quantity = Int32.Parse(QuantityTB.Text);
            int[] Eg = new int[20];
            int[] Gr = new int[20];
            int[] Cr= new int[20];

        public BordeForm()
        {
            InitializeComponent();
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
            if (i == quantity-1)
            {
                NextB.Content = "Вывести результат";
            }

            if (i == quantity)
            {
                Bord = new Vote.Borde();
                MessageBox.Show(Bord.MethodBorde(quantity, Gr, Eg, Cr)); 
                i = 0;
            }          
        }
    }
}
