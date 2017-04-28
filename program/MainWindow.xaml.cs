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

namespace program
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
        static Task<string> znajdz_r()
        {
            return Task.Run(() =>
            {


                return "napis";


            }

                );
        }

        private async void button_r_Click(object sender, RoutedEventArgs e)
        {
            string wynik = await znajdz_r();
            textBox_r.Text = wynik;
        }
        static Task<string> znajdz_s()
        {
            return Task.Run(() => 
            {


                return "napis";


            }
                
                );
        }
        private async void button_s_Click(object sender, RoutedEventArgs e)
        {
            string wynik = await znajdz_s();
            textBox_s.Text = wynik;
        }
    }
}
