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


namespace WpfApp3
{
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }
        public string str = "kazax";

        private void button1_Click(object sender, EventArgs e)
        {
            char[] arr = textBox1.Text.ToCharArray();
            for (int i = 0,j = 0; i < arr.Length; i++,j++)
            {
                if(j == str.Length - 1)
                    j = 0;
                textBox2.Text += (char)(arr[i] + str[j]); 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            char[] arr = textBox2.Text.ToCharArray();
            for (int i = 0,j = 0; i < arr.Length; i++,j++)
            {
                if (j == str.Length - 1)
                    j = 0;
                textBox3.Text += (char)(arr[i] - str[j]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
            
        }
    }
}
