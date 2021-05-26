using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OnlineStore.Model;
using OnlineStore.Model.Data;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.ComponentModel;
using OnlineStore.ViewModel;

namespace OnlineStore.View
{
    /// <summary>
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        ProductContext db = new ProductContext();            
        public AdminWindow()
        {
            InitializeComponent();
            DataContext = new AdminWindowVM();            
        }

        private void Go_To_Add_Product_Click(object sender, RoutedEventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.Show();
            Hide();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Login loginWindow = new Login();
            loginWindow.Show();
            Hide();
        }

        private void ButtonSetFilters_Click(object sender, RoutedEventArgs e)
        {
            
            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(ProductsList.ItemsSource);
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

        private void ButtonResetFilters_Click(object sender, RoutedEventArgs e)
        {
            
            TextBoxMinPrice.Text = "";
            TextBoxMaxPrice.Text = "";
            ComboBoxCategoryFilter.Text = "";
            List<Product> products = new List<Product>();
            using (ProductContext db = new ProductContext())
            {
                var items = db.Products;
                foreach (Product product in items.Where(a => a.Name != null))
                {
                    products.Add(new Product() { Id = product.Id, Name = product.Name, Price = product.Price, Quantity = product.Quantity });
                }
                ProductsList.ItemsSource = products;
            }
            
        }

        private void Button_Find_Click(object sender, RoutedEventArgs e)
        {
            
            if (TextBoxMinPrice.Text != string.Empty && TextBoxMaxPrice.Text != string.Empty)
            {
                decimal minPrice = 0;
                decimal maxPrice = 0;
                minPrice = Decimal.Parse(TextBoxMinPrice.Text);
                maxPrice = Decimal.Parse(TextBoxMaxPrice.Text);
                List<Product> currentProducts = new List<Product>();
                using (ProductContext db = new ProductContext())
                {
                    var products = db.Products;
                    foreach (Product product in products.Where(a => a.Name != null && a.Price >= minPrice && a.Price < maxPrice))
                    {
                        currentProducts.Add(new Product() { Id = product.Id, Name = product.Name, Price = product.Price, Quantity = product.Quantity });
                    }
                    ProductsList.ItemsSource = currentProducts;
                }
                if (currentProducts.Count < 1)
                {
                    MessageBox.Show("Нет продуктов, подходящих по указанным критериям");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Fill in the fields");
            }
            
        }

        private void ButtonEditItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void GoToOrders_Click(object sender, RoutedEventArgs e)
        {
            Orders ordersWindow = new Orders();
            ordersWindow.Show();
            Hide();
        }
    }
}
