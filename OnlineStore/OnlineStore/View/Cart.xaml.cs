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
    /// Логика взаимодействия для Cart.xaml
    /// </summary>
    public partial class Cart : Window
    {
        public Cart()
        {
            InitializeComponent();
            DataContext = new AddToCartVM();
        }

        private void GoToStore_Click(object sender, RoutedEventArgs e)
        {
            StoreList storeListWindow = new StoreList();
            storeListWindow.Show();
            Hide();
        }

        private void GoToBasket_Click(object sender, RoutedEventArgs e)
        {
            Basket basketWindow = new Basket();
            basketWindow.Show();
            Hide();
        }
    }
}
