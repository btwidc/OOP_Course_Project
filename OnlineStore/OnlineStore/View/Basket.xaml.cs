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
using OnlineStore.Model;
using OnlineStore.Model.Data;
using System.ComponentModel;
using System.Collections.ObjectModel;

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

        private void ButtonResetFilters_Click(object sender, RoutedEventArgs e)
        {       
            ComboBoxCategoryFilter.Text = "";
            List<Purchase> purchases = new List<Purchase>();
            using (PurchaseContext db = new PurchaseContext())
            {
                var items = db.Purchases;
                foreach (Purchase purchase in items)
                {
                    purchases.Add(new Purchase() { Id = purchase.Id, Product_id = purchase.Product_id, Name = purchase.Name, Price = purchase.Price, Quantity = purchase.Quantity, Source = purchase.Source});
                }
                BasketList.ItemsSource = purchases;
            }
        }

        private void ButtonSetFilters_Click(object sender, RoutedEventArgs e)
        {                       
            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(BasketList.ItemsSource);
            string text = ComboBoxCategoryFilter.Text;
            if (text == "Название")
            {
                view.SortDescriptions.Add(new SortDescription("Name", ListSortDirection.Ascending));
            }
            else if (text == "Цена")
            {
                view.SortDescriptions.Add(new SortDescription("Price", ListSortDirection.Ascending));
            }
            else if (text == "Количество")
            {
                view.SortDescriptions.Add(new SortDescription("Quantity", ListSortDirection.Ascending));
            }
            else
            {
                MessageBox.Show("Выберите категорию сортировки");
            }
        }
    }
}
