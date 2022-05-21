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


namespace Mod10_1302204043
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
        public double cariPangkat(int a, int b)
        {
            if (b == 0)
            {
                return 1;
            }
            else if (b < 0)
            {
                return -1;
            }
            else if (b > 10 || a > 100){
                return -2;
            }
            else if (Math.Pow(a, b) > 2147483647)
            {
                return -3;
            }
            else 
            { 
                return Math.Pow(a, b);    
            }
            
        }

        private void btnInput_Click(object sender, RoutedEventArgs e)
        {
            
            int a = Convert.ToInt32(txtInput.Text);
            int b = Convert.ToInt32(txtInput2.Text);
            txtOutput.Text = Convert.ToString(cariPangkat(a, b));
        }

        private void txtInput_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtOutput_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtInput2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
