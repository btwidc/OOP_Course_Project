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
            string confirm_password = Confirm_Password_TextBox.Password;

            if (username.Length < 4)
            {
                Username_TextBox.ToolTip = "Имя пользователя должно содержать хотя бы 4 символа";
                Username_TextBox.Background = Brushes.LightPink;
            }
            else if (password.Length < 4)
            {
                Password_TextBox.ToolTip = "Пароль должен содержать хотя бы 4 символа";
                Password_TextBox.Background = Brushes.LightPink;
            }
            else if (password != confirm_password)
            {
                Password_TextBox.ToolTip = "Подтверждение не соответствует паролю";
                Password_TextBox.Background = Brushes.LightPink;
                Confirm_Password_TextBox.Background = Brushes.LightPink;
            }
            else
            {
                Username_TextBox.ToolTip = null;
                Password_TextBox.ToolTip = null;
                Username_TextBox.Background = Brushes.White;
                Password_TextBox.Background = Brushes.White;
                Confirm_Password_TextBox.Background = Brushes.White;

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
