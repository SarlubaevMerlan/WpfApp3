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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }
        public int key = 2011;//Указываем ключ.
        public string str = "kazax";

        private void button1_Click(object sender, EventArgs e)
        {
            char[] arr = textBox1.Text.ToCharArray();//Разбираем строку на символы и записываем в массив.
            for (int i = 0,j = 0; i < arr.Length; i++,j++)
            {
                if(j == str.Length - 1)
                    j = 0;
                textBox2.Text += (char)(arr[i] + str[j]); //Приводим символ к типу int,умножаем на 2011(переменная key) и разделяем каждый "шифрованный символ символом '-'. 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            char[] arr = textBox2.Text.ToCharArray();//Наши "символы же разделены '-',вот и ищем их.
            for (int i = 0,j = 0; i < arr.Length; i++,j++)
            {
                if (j == str.Length - 1)
                    j = 0;
                textBox3.Text += (char)(arr[i] - str[j]);//Тут вот муть какая-то,обернул в try,catch.Делим обратно на 2011 и приводим к типу char.
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
