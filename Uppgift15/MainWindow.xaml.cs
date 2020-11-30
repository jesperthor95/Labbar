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

namespace Uppgift15
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        char[] lowVawels = { 'a', 'e', 'i', 'o', 'u', 'y', 'å', 'ä', 'ö'};
        char[] highVowels = { 'A', 'E', 'I', 'O', 'U', 'Y', 'Å', 'Ä', 'Ö' };
        int vokaler = 0;
        
        
        public MainWindow()
        {
            InitializeComponent();
            
        }

       private bool IsVowel (char kollaOmVokal) // kollar om ett inmatat tecken är en vokal
       {
          
           bool vowel = false;

            foreach (char Vowels in lowVawels)
            {
              if (Vowels == kollaOmVokal)
               {
                   vowel = true;
                    break;
                }
             }

           return vowel;
       }
        
        private int NumberOfvowels (string input) // räknar ut alla vokaler i text inputen
        {
  
            foreach (char vowels in input)
            {

                    if (IsVowel(vowels))
                    {
                        vokaler++;
                    }
  
            }

            return vokaler;

        }

        private string Jibberish (string input) // ersätter vokaler med ö/Ö
        {
            
            

            foreach (char vowel in lowVawels)
            {
                input = input.Replace(vowel, 'ö');
            }

            foreach (char vowel in highVowels)
            {
                input = input.Replace(vowel, 'Ö');
            }
            return input;
            
            
        }
        
        private void btnConvertText_Click(object sender, RoutedEventArgs e)
        {
            // Data som matas in
            string input;
            input = txtBox.Text;

            // printar ut resultatet i olika textrutor
            lblrotResult.Content = $"{Jibberish(txtBox.Text)}";
            result.Content = $"antal vokaler {NumberOfvowels(txtBox.Text)}"; 

            // nollställer "antalet vokaler"
            vokaler = 0;
        
        }

    }
}
