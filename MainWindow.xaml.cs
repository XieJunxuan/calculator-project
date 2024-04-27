using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string message = "位数不得超过10位";
        public int cnt=0;
        public string a = "0";
        public string b = "0";
        public bool fh=false;
        public string fh2 = "1";
        public double l = 0;
        public MainWindow()
        {
            InitializeComponent();
        }
        //1
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            if (cnt >= 10)
            {
                _ = MessageBox.Show(message);
            }
            else
            {
                TB1.Text += 1;
                if (fh == true)
                {
                    b += "1";
                }
                else
                {
                    a += "1";
                }
                cnt++;
            }
        }
        //2
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            if (cnt >= 10)
            {
                _ = MessageBox.Show(message);
            }
            else
            {
                TB1.Text += 2;
                if (fh == true)
                {
                    b += "2";
                }
                else
                {
                    a += "2";
                }
                cnt++;
            }
        }
        //3
        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            if (cnt >= 10)
            {
                _ = MessageBox.Show(message);
            }
            else
            {
                TB1.Text += 3;
                if (fh == true)
                {
                    b += "3";
                }
                else
                {
                    a += "3";
                }
                cnt++;
            }
        }
        //4
        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            if (cnt >= 10)
            {
                _ = MessageBox.Show(message);
            }
            else
            {
                TB1.Text += 4;
                if (fh == true)
                {
                    b += "4";
                }
                else
                {
                    a += "4";
                }
                cnt++;
            }
        }
        //5
        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            if (cnt >= 10)
            {
                _ = MessageBox.Show(message);
            }
            else
            {
                TB1.Text += 5;
                if (fh == true)
                {
                    b += "5";
                }
                else
                {
                    a += "5";
                }
                cnt++;
            }
        }
        //6
        private void Button_Click6(object sender, RoutedEventArgs e)
        {
            if (cnt >= 10)
            {
                _ = MessageBox.Show(message);
            }
            else
            {
                TB1.Text += 6;
                if (fh == true)
                {
                    b += "6";
                }
                else
                {
                    a += "6";
                }
                cnt++;
            }
        }
        //7
        private void Button_Click7(object sender, RoutedEventArgs e)
        {
            if (cnt >= 10)
            {
                _ = MessageBox.Show(message);
            }
            else
            {
                TB1.Text += 7;
                if (fh == true)
                {
                    b += "7";
                }
                else
                {
                    a += "7";
                }
                cnt++;
            }
        }
        //8
        private void Button_Click8(object sender, RoutedEventArgs e)
        {
            if (cnt >= 10)
            {
                _ = MessageBox.Show(message);
            }
            else
            {
                TB1.Text +=8;
                if (fh == true)
                {
                    b += "8";
                }
                else
                {
                    a += "8";
                }
                cnt++;
            }
        }
        //9
        private void Button_Click9(object sender, RoutedEventArgs e)
        {
            if (cnt >= 10)
            {
                _ = MessageBox.Show(message);
            }
            else
            {
                TB1.Text += 9;
                if (fh == true)
                {
                    b += "9";
                }
                else
                {
                    a += "9";
                }
                cnt++;
            }
        }
        //0
        private void Button_Click0(object sender, RoutedEventArgs e)
        {
            if (cnt >= 10)
            {
                _ = MessageBox.Show(message);
            }
            else
            {
                TB1.Text += 0;
                if (fh == true)
                {
                    b += "0";
                }
                else
                {
                    a += "0";
                }
                cnt++;
            }
        }
        //clear
        private void Button_Click_C(object sender, RoutedEventArgs e)
        {
            TB1.Text = "";
            cnt = 0;
            fh=false;
	        fh2="";
            a = "";
            b = "";
        }
        //del
        private void Button_Click_del(object sender, RoutedEventArgs e)
        {
            if (TB1.Text.Length >0 )
            {
                TB1.Text = TB1.Text.Substring(0, TB1.Text.Length - 1);
            }
        }
        //jia
        private void Button_Click_jia(object sender, RoutedEventArgs e)
        {
            fh2 = "1";
            TB1.Text += "+";
            fh=true;
            cnt = 0;
        }
        //jian
        private void Button_Click_jian(object sender, RoutedEventArgs e)
        {
            fh2 = "2";
            TB1.Text += "-";
            fh = true;
            cnt = 0;
        }
        //chen
        private void Button_Click_chen(object sender, RoutedEventArgs e)
        {
            fh2 = "3";
            TB1.Text += "×";
            fh = true;
            cnt = 0;
        }
        //chu
        private void Button_Click_chu(object sender, RoutedEventArgs e)
        {
            fh2 = "4";
            TB1.Text += "÷";
            fh = true;
            cnt = 0;
        }
        //denyu
        private void Button_Click_denyu(object sender, RoutedEventArgs e)
        {
            if (fh2=="1")
            {
                double d= double.Parse(a);
                double f = double.Parse(b);
                l = d + f;               
                TB1.Text = l.ToString(); 
            }
            if (fh2 == "2")
            {
                double d = double.Parse(a);
                double f = double.Parse(b);
                l = d - f;
                TB1.Text = l.ToString(); 
            }
            if (fh2 == "3")
            {
                double d = double.Parse(a);
                double f = double.Parse(b);
                l = d * f;
                TB1.Text = l.ToString(); 
            }
            if (fh2 == "4")
            {
                double d = double.Parse(a);
                double f = double.Parse(b);
                l = d / f;
                TB1.Text = l.ToString(); 
            }
        }

        

    }
}
