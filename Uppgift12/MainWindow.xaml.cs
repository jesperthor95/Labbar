using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Uppgift12
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int[] value = new int[5];

        int btncount = 0;
       

        public MainWindow()
        {
            InitializeComponent();

            txtMataInTal.Focus();

        }

        
        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            if (btncount < 5 )
            {
                value[btncount] = int.Parse(txtMataInTal.Text);
                btncount++;
                txtMataInTal.Focus();

            }
            listBox.ItemsSource = null;
            listBox.ItemsSource = value;

            double sum = value[0] + value[1] + value[2] + value[3] + value[4];
            double medelvärde = sum / 5.0;
            txtTotalMedel.Text = medelvärde.ToString();

           
            if (btncount == 5)
            {
                btnOk.IsEnabled = false;
            }

          
 
        }

        private void reset_Click(object sender, RoutedEventArgs e)
        {
            Array.Clear(value, 0, value.Length);
            listBox.ItemsSource= null;
            txtMataInTal.Clear();
            txtTotalMedel.Clear();
            txtMataInTal.Focus();

            btncount = 0;
            btnOk.IsEnabled = true;
        }
    }
}
