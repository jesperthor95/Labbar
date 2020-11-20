using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace Uppgift11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int changeValue = 5;
        
        public MainWindow()
        {
            InitializeComponent();
            progressBar.Value = 50;
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            int rightSide = 0;
            int antalGånger= 0;
            int randomNumber = 0;
            int chance = Convert.ToInt32(progressBar.Value);

            Random numberOfTries = new Random();

            antalGånger = int.Parse(txtValue.Text);

            
            
            for (int i = 0; i <= antalGånger; i++)
            {
                randomNumber = numberOfTries.Next(100);
                if (randomNumber <= chance)
                {

                    rightSide++;
             
                }

                lblFel.Content = $"Fel sida = {rightSide}";
                lblRätt.Content = $"rätt sida = {antalGånger - rightSide}";

            }
        }
        private void btnMoreOtur_Click(object sender, RoutedEventArgs e)
        {          
            progressBar.Value = progressBar.Value + changeValue;
            lblValue.Content = $"{progressBar.Value} %";
        }

        private void btnLessOtur_Click(object sender, RoutedEventArgs e)
        {            
            progressBar.Value = progressBar.Value - changeValue;
            lblValue.Content = $"{progressBar.Value} %";
        }
    }
}
