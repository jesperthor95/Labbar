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

namespace Uppgift13
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            txtBox.Focus();
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {

            int antalBokstaver = 0;

            char character = char.Parse(txtChar.Text);
            string text = txtBox.Text;

            foreach (char rightCharacter in text)
            
            { 
            
                if (rightCharacter == character)
                { 
                    antalBokstaver++;
                }
                
            }

            lblResultat.Content = $"Du hittade {character} {antalBokstaver} gånger";
        }
    }
}
