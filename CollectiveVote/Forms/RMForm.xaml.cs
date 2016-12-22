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
    /// Interaction logic for RM.xaml
    /// </summary>
    public partial class RMForm : Window
    {
        private int Greece, Crimea, Egypt, numberOfVoting = 0;
        private Vote.RelativeMajority RelM; 
        private int quantity;
        private int i = 0;
        public RMForm()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            quantity = Int32.Parse(QuantityTB.Text);
            i = i + 1;
            if (i == quantity + 1)
            {
                button.Content = "Вывести результат";
            }

            if (i == quantity)
            {
                RelM = new Vote.RelativeMajority();
                MessageBox.Show(RelM.Majority(Greece, Egypt, Crimea));
                i = 0;
            }

                numberOfVoting = numberOfVoting + 1;

            if (EgyptRB.IsChecked == true)
            {
                Egypt = Egypt + 1;
            }

            if (CrimeaRB.IsChecked == true)
            {
                Crimea = Crimea + 1;
            }

            if (GreeceRB.IsChecked == true)
            {
                Greece = Greece + 1;
            }
        }
    }
}
