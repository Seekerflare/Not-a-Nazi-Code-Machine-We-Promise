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
using Microsoft.VisualBasic;
namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Key theKey;
        public enum Rotors  { I, II, III, IV, V }
        
        public MainWindow()
        {
            InitializeComponent();
            
        }

        public void Settings()
        {
            int[] allRotors = new int[3] { comboRotorone.SelectedIndex, comboRotortwo.SelectedIndex, comboRotorthree.SelectedIndex};           
            var rotorList = new List<string>();
            foreach(int i in allRotors)
            {
                if (i <= -1)
                {
                    MessageBox.Show("Make sure settings are correct!");
                    return;
                }
                switch (i)
                {
                    case (int)(Rotors.I):
                        rotorList.Add("I");
                        break;
                    case (int)(Rotors.II):
                        rotorList.Add("II");
                        break;
                    case (int)(Rotors.III):
                        rotorList.Add("III");
                        break;
                    case (int)(Rotors.IV):
                        rotorList.Add("IV");
                        break;
                    case (int)(Rotors.V):
                        rotorList.Add("V");
                        break;
                }
            }
            string rotorsOrder="";
            foreach(string a in rotorList)
            {
                rotorsOrder += a+" ";
            }
            RotorSetup.Text = rotorsOrder.TrimEnd();

            if (string.IsNullOrWhiteSpace(startR1.Text)|| string.IsNullOrWhiteSpace(startR2.Text)|| string.IsNullOrWhiteSpace(startR3.Text))
            {
                MessageBox.Show("Make sure starting letters are correct!");
                return;
            }
            LetterSetup.Text = (startR1.Text + startR2.Text + startR3.Text).ToUpper();
        }

        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {
             
            MessageBox.Show(Convert.ToString(e.Key));
            Settings();
        }


    }
}
