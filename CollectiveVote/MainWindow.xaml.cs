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

namespace CollectiveVote
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Forms.BordeForm _bf;
        private Forms.RMForm _rm;
        private Forms.CondorcetForm _cf;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RMButton_Click(object sender, RoutedEventArgs e)
        {
            _rm = new Forms.RMForm();
            _rm.Show();
        }

        private void BordeB_Click(object sender, RoutedEventArgs e)
        {
            _bf = new Forms.BordeForm();
            _bf.Show();
        }

        private void CondorcetB_Click(object sender, RoutedEventArgs e)
        {
            _cf = new Forms.CondorcetForm();
            _cf.Show();
        }
    }
}
