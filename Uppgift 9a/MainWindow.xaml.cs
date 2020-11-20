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

namespace Uppgift_9a
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

        private void btnControll_Click(object sender, RoutedEventArgs e)
        {
           
            string name = txtBoxName.Text;
            int age;
            int.TryParse(txtBoxAge.Text, out age);


            if (age < 7 && (bool) (withAdult.IsChecked))
            {
                
                lblInfo.Content = $"Hej {name}. Du är {age} år gammal.\nDu får se filmer med åldersgräns upp till 7-årsgräns";
                           
            }

                if (age < 7 && (bool)(withOutAdult.IsChecked))
                {

                lblInfo.Content = $"Hej {name}. Du är {age} år gammal.\nDu får se barntillåtna filmer.";

                }


            if (age > 6 && age < 11 && (bool) (withAdult.IsChecked))
            {
                
                lblInfo.Content = $"Hej {name}. Du är {age} år gammal.\nDu får se filmer med åldersgräns upp till 11-årsgräns";

                
            }

                if (age > 6 && age < 11 && (bool)(withOutAdult.IsChecked))
                {
                lblInfo.Content = $"Hej {name}. Du är {age} år gammal.\nDu får se filmer med åldergräns upp till 7-årsgräns.";
                }


            if (age > 10 && age < 15 )
            {
                lblInfo.Content = $"Hej {name}. Du är {age} år gammal.\nDu får se filmer med åldergräns upp till 11-årsgräns.";
            }

            if (age == 15)
            {
                lblInfo.Content = $"Hej {name}. Du är {age} år gammal.\nDu får se filmer med åldergräns upp till 15-årsgräns.";
            }

            if (age > 15)
            {
                lblInfo.Content = $"Hej {name}. Du är {age} år gammal.\nDu får se alla filmer";
            }

            
        }
    }
}
