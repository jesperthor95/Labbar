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

namespace HarryPotterDel1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Ravenclaw raven;
        public Gryffindor gryff;
        public Slytherin slyt;
        public Hufflepuff huff;
        // public Wizard wiz;
        public MainWindow()
        {
            InitializeComponent();

            raven = new Ravenclaw();
            gryff = new Gryffindor();
            huff = new Hufflepuff();
            slyt = new Slytherin();

            raven.SetNewPassword(raven.Password, "arrnt");
            gryff.SetNewPassword(gryff.Password, "arnnt");
            huff.SetNewPassword(huff.Password, "arrnt");
            slyt.SetNewPasswordSlyt(slyt.Password, "tnnnnnnt");

            //wizard wizz = new wizard
            //{
            //  BloodStatus = txtBlood.Text,
            // DeathEater = false,
            // DumbledoresArmy = true,
            // Name = txtName.Text,
            // };

            // List<wizard> people = new List<wizard>();
            // people.Add(wizz);

            //listWizards.ItemsSource = people;


            //MessageBox.Show(wiz.BloodStatus + " " + wiz.DeathEater + " " + wiz.DumbledoresArmy + " " + wiz.Name);

            // string password = gryff.CheckPassword();
        }
    }
}
