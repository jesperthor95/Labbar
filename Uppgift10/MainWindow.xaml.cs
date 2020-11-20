using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
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

namespace Uppgift10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random slump = new Random();
        int slumptal;
        int antalGissningar;
        
        
        public MainWindow()
        {
            InitializeComponent();
            btnGuess.IsEnabled = false;
        }

        private void btnSlumpTal_Click(object sender, RoutedEventArgs e)
        {

            slumptal = slump.Next(1000);
            
            btnGuess.IsEnabled = true;                   
        }

        private void btnGuess_Click(object sender, RoutedEventArgs e)
        {

           antalGissningar++;
           
            
            string tal = txtBoxNumber.Text;

            int guess;
            guess = int.Parse(tal);

           

            if (guess == slumptal)
            {
                txtBlockFeedback.Text = $"Du gissade rätt! du klarade det på {antalGissningar} försöket ";
            }

            if (guess > 100 + slumptal) 
            {
                txtBlockFeedback.Text = "Du gissade alldeles för högt";
            }

            if (guess < slumptal - 100) 
            {
                txtBlockFeedback.Text = "Du gissade alldeles för lågt";
            }

            if (guess > slumptal && guess < slumptal + 100) 
            {
                txtBlockFeedback.Text = "Du gissade för högt";
            }

            if (guess < slumptal && guess > slumptal - 100) 
            {
                txtBlockFeedback.Text = "Du gissade för lågt";
            }


        }
    }
}
