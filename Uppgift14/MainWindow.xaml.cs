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

namespace Uppgift14
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
            string birthDate = txtBox.Text;
            int date = DateTime.Now.Year;

                

                if (string.Concat(birthDate).All(char.IsDigit))

                {
                    int age = int.Parse(birthDate);
                    int sum = date - age;
                    MessageBox.Show($"du är {sum} år gammal");
                   
                }
                else if (string.Concat(birthDate).Any(char.IsLetter) || string.Concat(birthDate).Any(char.IsDigit))
                {
                MessageBox.Show("Du måste mata in siffor!");

                }






        }
    }
}
