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
using OnlineStore.ViewModel;

namespace OnlineStore.View
{
    /// <summary>
    /// Логика взаимодействия для Basket.xaml
    /// </summary>
    public partial class Basket : Window
    {
        public Basket()
        {
            InitializeComponent();
            DataContext = new BasketVM();
        }

        private void GoToCart_Click(object sender, RoutedEventArgs e)
        {
            Cart cartWindow = new Cart();
            cartWindow.Show();
            Hide();
        }
    }
}
