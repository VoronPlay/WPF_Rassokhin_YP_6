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

namespace WPF_Rassokhin_YP_6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            {
                if (pwBox.Password.ToString() == "User" && logBox.Password.ToString() == "User")
                {
                    Window1 window1 = new Window1();
                    window1.Show();
                }
                else if (pwBox.Password.ToString() == "Admin" && logBox.Password.ToString() == "Admin")
                {
                    Window2 window2 = new Window2();
                    window2.Show();
                }
                else if (logBox.Password.ToString() != " " && pwBox.Password.ToString() != " ")
                {
                    MessageBox.Show("Поле с логином и с паролем не заполнено");
                }
                else if (pwBox.Password.ToString() != " ")
                {
                    MessageBox.Show("Поле с паролем не заполнено");
                }
                else if (logBox.Password.ToString() != " ")
                {
                    MessageBox.Show("Поле с логином не заполнено");
                }
                else if (pwBox.Password.ToString() != "User")
                {
                    MessageBox.Show("Пароль не верный");
                }
                else if (logBox.Password.ToString() != "User")
                {
                    MessageBox.Show("Логин не верный");
                }
                else if (logBox.Password.ToString() != "User" && pwBox.Password.ToString() != "User")
                {
                    MessageBox.Show("Логин и пароль не верны");
                }
                else if (pwBox.Password.ToString() != "Admin")
                {
                    MessageBox.Show("Пароль не верный");
                }
                else if (logBox.Password.ToString() != "Admin")
                {
                    MessageBox.Show("Логин не верный");
                }
                else if (logBox.Password.ToString() != "Admin" && pwBox.Password.ToString() != "Admin")
                {
                    MessageBox.Show("Логин и пароль не верны");
                }
            }

        }

       

        private void logCheck_Checked(object sender, RoutedEventArgs e)
        {
            App.Current.Properties[0] = logBox.Password.Trim();
        }
    }
}
