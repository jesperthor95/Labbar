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

namespace Uppgift_7
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

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            int sum1, sum2, wholeSum, restSum;

            sum1 = int.Parse(txtBoxOne.Text);
            sum2 = int.Parse(txtBoxTwo.Text);

            wholeSum = sum1 / sum2;
            restSum = sum1 % sum2;

            txtBoxWhole.Text = wholeSum.ToString();
            txtBoxRest.Text = restSum.ToString();

            resultat.Content = $"Om lika delning får varje person {wholeSum} godis var.\nResterande godisar är {restSum} stycken! ";
            resultat.Visibility = Visibility.Visible;
        }
    }
}
