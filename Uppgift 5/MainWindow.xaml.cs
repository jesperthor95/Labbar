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

namespace Uppgift_5
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

        private void calculate_Click(object sender, RoutedEventArgs e)
        {
          
            int boxOne, boxTwo, totaltSum;

            boxOne = int.Parse(txtboxOne.Text);
            boxTwo = int.Parse(txtboxTwo.Text);
            totaltSum = boxOne + boxTwo;

            txtboxResult.Text = totaltSum.ToString();


        }

        private void Label_MouseLeftButtonDown(object sender, MouseEventArgs e)
        {

            int boxOne, boxTwo, totaltSum;

            boxOne = int.Parse(txtboxOne.Text);
            boxTwo = int.Parse(txtboxTwo.Text);
            totaltSum = boxOne + boxTwo;

            txtboxResult.Text = totaltSum.ToString();
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            txtboxOne.Clear();
            txtboxTwo.Clear();
            txtboxResult.Clear();
        }

        
    }
}
