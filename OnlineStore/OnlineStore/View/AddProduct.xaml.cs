using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Логика взаимодействия для AddProduct.xaml
    /// </summary>
    public partial class AddProduct : Window
    {
        ProductContext db;
        public AddProduct()
        {
            InitializeComponent();
            db = new ProductContext();
        }

        private void Admin_Window_Click(object sender, RoutedEventArgs e)
        {
            AdminWindow adminWindow = new AdminWindow();
            adminWindow.Show();
            Hide();
        }

        private void Add_Product_Click(object sender, RoutedEventArgs e)
        {
            //string name = Name_TextBox.Text;
            //decimal price = decimal.Parse(Price_TextBox.Text);
            //int quantity = Int32.Parse(Quantity_TextBox.Text);
            //string source = ItemPicture.Source.ToString();     
            if(Name_TextBox.Text == "" || Price_TextBox.Text == "" || Quantity_TextBox.Text == "")
            {
                MessageBox.Show("Поля не могут быть пустыми");
            }
            else if (Price_TextBox.Text == "0" || Quantity_TextBox.Text == "0")
            {
                MessageBox.Show("Поля не могут содержать 0");
            }
            else if (Regex.IsMatch(Name_TextBox.Text, "[0-9]"))
            {
                Name_TextBox.ToolTip = "Название не должно содержать цифры";
                Name_TextBox.Background = Brushes.LightPink;
            }
            else if (Regex.IsMatch(Price_TextBox.Text, "[^0-9/,]"))
            {
                Price_TextBox.ToolTip = "Цена должна содержать только цифры и запятую";
                Price_TextBox.Background = Brushes.LightPink;
            }
            else if (Regex.IsMatch(Quantity_TextBox.Text, "[^0-9]"))
            {
                Quantity_TextBox.ToolTip = "Количество должно содержать только цифры";
                Quantity_TextBox.Background = Brushes.LightPink;
            }
            else
            {
                Product product = new Product(Name_TextBox.Text, decimal.Parse(Price_TextBox.Text), Int32.Parse(Quantity_TextBox.Text), ItemPicture.Source.ToString());
                db.Products.Add(product);
                db.SaveChanges();                
                Name_TextBox.Text = "";
                Name_TextBox.Background = Brushes.White;
                Price_TextBox.Text = "";
                Price_TextBox.Background = Brushes.White;
                Quantity_TextBox.Text = "";
                Quantity_TextBox.Background = Brushes.White;
                ItemPicture.Source = MainItemPicture.Source;
                MessageBox.Show("Продукт добавлен");
            }

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Login loginWindow = new Login();
            loginWindow.Show();
            Hide();
        }
        
        private void Add_Picture_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.FileName = "";
            dlg.DefaultExt = ".png";

            Nullable<bool> result = dlg.ShowDialog();

            if (result == true)
            {
                BitmapImage image = new BitmapImage();
                image.BeginInit();
                image.UriSource = new Uri(dlg.FileName);
                image.EndInit();
                ItemPicture.Source = image;
            }

        }
    }
}
