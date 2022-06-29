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
using Microsoft.Win32;
using System.IO;

namespace Melnik2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string path;
        public MainWindow()
        {
            InitializeComponent();
        }
        //Answer.Text =  Convert.ToString(Convert.ToDouble(Edit11.Text) * Convert.ToDouble(BigEdit22.Text) * Convert.ToDouble(BigEdit33.Text) +
        //Convert.ToDouble(BigEdit12.Text)* Convert.ToDouble(BigEdit23.Text) * Convert.ToDouble(BigEdit31.Text) +
        //               Convert.ToDouble(BigEdit21.Text)* Convert.ToDouble(BigEdit32.Text) * Convert.ToDouble(BigEdit13.Text)
        //             - (Convert.ToDouble(BigEdit31.Text)* Convert.ToDouble(BigEdit22.Text) * Convert.ToDouble(BigEdit13.Text) +
        //               Convert.ToDouble(BigEdit21.Text)* Convert.ToDouble(BigEdit12.Text) * Convert.ToDouble(BigEdit33.Text) +
        //               Convert.ToDouble(BigEdit32.Text)* Convert.ToDouble(BigEdit23.Text) * Convert.ToDouble(BigEdit11.Text)));
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            using (StreamReader rd = new StreamReader(path))
            {
                string txt = rd.ReadToEnd();
                string one = txt[0].ToString() + txt[1].ToString() + txt[2].ToString();
                string two = txt[4].ToString() + txt[5].ToString() + txt[6].ToString();
                string tre = txt[8].ToString() + txt[9].ToString() + txt[10].ToString();
                textBlock.Text = ((int.Parse(one[0].ToString()) * int.Parse(two[1].ToString()) * int.Parse(tre[2].ToString()) +
                    int.Parse(one[1].ToString()) * int.Parse(two[2].ToString()) * int.Parse(tre[0].ToString()) +
                    int.Parse(two[0].ToString()) * int.Parse(tre[1].ToString()) * int.Parse(one[2].ToString()))
                    - (int.Parse(tre[0].ToString()) * int.Parse(two[1].ToString()) * int.Parse(one[2].ToString()) +
                    int.Parse(two[0].ToString()) * int.Parse(one[1].ToString()) * int.Parse(tre[2].ToString()) +
                    int.Parse(tre[1].ToString()) * int.Parse(two[2].ToString()) * int.Parse(one[0].ToString()))).ToString();
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            using (StreamReader rd = new StreamReader(path))
            {
                string txt = rd.ReadToEnd();
                string one = txt[0].ToString() + txt[1].ToString();
                string two = txt[3].ToString() + txt[4].ToString();
                textBlock.Text = ((int.Parse(one[0].ToString()) * int.Parse(two[1].ToString())) - (int.Parse(one[1].ToString()) * int.Parse(two[0].ToString()))).ToString();
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == true)
            {
                path = ofd.FileName;
            }
        }
    }
}
