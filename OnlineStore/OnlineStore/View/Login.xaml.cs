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
using System.Windows.Shapes;
using OnlineStore.Model;
using OnlineStore.Model.Data;

namespace OnlineStore.View
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            string username = Username_TextBox.Text;
            string password = Password_TextBox.Password;

                User authUser;
                using (UserContext db = new UserContext())
                {
                    authUser = db.Users.Where(a => a.Username == username && a.Password == password).FirstOrDefault();
                }

                if (authUser != null && authUser.Username != "admin")
                {
                    StoreList storeListWindow = new StoreList();
                    storeListWindow.Show();
                    Hide();
                }
                else if (authUser == null)
                {
                    Username_TextBox.ToolTip = "Неверное имя пользователя или пароль";
                    Username_TextBox.Background = Brushes.LightPink;
                    Password_TextBox.Background = Brushes.LightPink;
                }
                else if (authUser != null && authUser.Username == "admin")
                {
                    AdminWindow adminWindow = new AdminWindow();
                    adminWindow.Show();
                    Hide();
                }
        }

        private void Go_To_Registration_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Hide();

        }

    }
}
