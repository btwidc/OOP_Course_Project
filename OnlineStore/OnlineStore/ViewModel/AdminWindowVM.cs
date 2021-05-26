using OnlineStore.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using OnlineStore.Model.Data;

namespace OnlineStore.ViewModel
{
    public class AdminWindowVM : INotifyPropertyChanged
    {
        ProductContext db = new ProductContext();
        
        MyCommand deleteCommand;

        private Product selectedProduct;
        public Product SelectedProduct
        {
            get { return selectedProduct; }
            set
            {
                selectedProduct = value;
                OnPropertyChanged("selectedProduct");
            }
        }
        
        public ObservableCollection<Product> Products { get; set; }

        public AdminWindowVM()
        {         
           Products = new ObservableCollection<Product>(db.Products.ToList());            
        }

        
        public MyCommand DeleteCommand
        {
            get
            {
                return deleteCommand ??
                    (deleteCommand = new MyCommand((selectedItem) =>
                    {
                        if (selectedItem == null) return;
                        Product product = selectedItem as Product;
                        Products.Remove(product);
                        db.Products.Remove(product);
                        db.SaveChanges();
                        MessageBox.Show("Продукт удалён");
                    }));
            }
        }
        
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

    }

}
