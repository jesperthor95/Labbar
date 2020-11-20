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

namespace Uppgift_6
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

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            double sum1 = 0, sum2 = 0, sumTotal;
            lblResult.Content = "Summa";
            sum1 = double.Parse(txtBox1.Text);
            sum2 = double.Parse(txtBox2.Text);
            sumTotal = sum1 + sum2;

            txtBoxTotal.Text = sumTotal.ToString();
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            double sum1 = 0, sum2 = 0, sumTotal;
            lblResult.Content = "Differens";
            sum1 = double.Parse(txtBox1.Text);
            sum2 = double.Parse(txtBox2.Text);
            sumTotal = sum1 - sum2;

            txtBoxTotal.Text = sumTotal.ToString();
        }

        private void multi_Click(object sender, RoutedEventArgs e)
        {
            double sum1 = 0, sum2 = 0, sumTotal;
            lblResult.Content = "Produkt";
            sum1 = double.Parse(txtBox1.Text);
            sum2 = double.Parse(txtBox2.Text);
            sumTotal = sum1 * sum2;
            
            txtBoxTotal.Text = Math.Round(sumTotal, 2).ToString();

        }

        private void division_Click(object sender, RoutedEventArgs e)
        {
            double sum1 = 0, sum2 = 0, sumTotal;
            lblResult.Content = "Kvot";
            sum1 = double.Parse(txtBox1.Text);
            sum2 = double.Parse(txtBox2.Text);
            sumTotal = sum1 / sum2;
            

            txtBoxTotal.Text = Math.Round(sumTotal, 2).ToString();
            
        }

        private void rensa_Click(object sender, RoutedEventArgs e)
        {
            txtBox1.Clear();
            txtBox2.Clear();
            txtBoxTotal.Clear();

            lblResult.Content = "";
        }
    }
}
