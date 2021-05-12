using OnlineStore.Model;
using OnlineStore.Model.Data;
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

namespace OnlineStore.View
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        UserContext db;

        public MainWindow()
        {
            InitializeComponent();
            db = new UserContext();
        }

        private void Signup_Click(object sender, RoutedEventArgs e)
        {
            string username = Username_TextBox.Text;
            string password = Password_TextBox.Password;

            if (username.Length < 4)
            {
                Username_TextBox.ToolTip = "Username should contain at least 4 characters";
                Username_TextBox.Background = Brushes.LightPink;
            }
            else if (password.Length < 4)
            {
                Password_TextBox.ToolTip = "Password should contain at least 4 characters";
                Password_TextBox.Background = Brushes.LightPink;
            }
            else
            {
                Username_TextBox.ToolTip = "";
                Username_TextBox.Background = Brushes.White;
                Password_TextBox.ToolTip = "";
                Password_TextBox.Background = Brushes.White;

                User user = new User(username, password);
                db.Users.Add(user);
                db.SaveChanges();

                Login loginWindow = new Login();
                loginWindow.Show();
                Hide();

            }

        }
        private void Go_To_Authorization_Click(object sender, RoutedEventArgs e)
        {
            Login loginWindow = new Login();
            loginWindow.Show();
            Hide();

        }
    }
}
