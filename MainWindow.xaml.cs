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

namespace Calc
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string Num;
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            outNum.Text = Num;
        }

        private void rb_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton pressed = (RadioButton)sender;
            switch (pressed.Content.ToString())
            {
                case "BIN":
                    Num = String.Format("BIN {0:X8}", Convert.ToString(Convert.ToInt32(inNum.Text.ToString()), 2));
                    break;
                case "OCT":
                    Num = String.Format("OCT {0:X8}", Convert.ToString(Convert.ToInt32(inNum.Text.ToString()), 8));
                    break;
                case "HEX":
                    Num = String.Format("HEX {0:X8}", Convert.ToString(Convert.ToInt32(inNum.Text.ToString()), 2));
                    break;
            }

        }


    }
}