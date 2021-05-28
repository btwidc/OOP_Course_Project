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
using OnlineStore.View;
using System.Data.Entity;

namespace OnlineStore.ViewModel
{
    public class AddToCartVM : INotifyPropertyChanged
    {
        ProductContext db = new ProductContext();
        PurchaseContext pur = new PurchaseContext();
        OrderContext or = new OrderContext();
        public ObservableCollection<Product> Items { get; set; }

        MyCommand buyCommand;

        public AddToCartVM()
        {
            Items = new ObservableCollection<Product>(db.Products.ToList());
        }

        public MyCommand BuyCommand
        {
            get
            {
                return buyCommand ??
                    (buyCommand = new MyCommand((selectedItem) =>
                    {
                        if (selectedItem == null) return;
                        Product product = selectedItem as Product;
                        Product curPr = db.Products.Find(product.Id);
                        Purchase p = pur.Purchases.Where(pr => pr.Product_id == product.Id).FirstOrDefault();
                        Order o = or.Orders.Where(pr => pr.Id_product == product.Id).FirstOrDefault();
                        if (p == null && curPr != null )
                        {                     
                            if (curPr.Quantity >=2)
                            { 
                                curPr.Quantity--;
                                db.Entry(curPr).State = EntityState.Modified;
                                db.SaveChanges();
                                Items = new ObservableCollection<Product>(db.Products.ToList());
                                Purchase purchase = new Purchase
                                {
                                    Product_id = curPr.Id,
                                    Name = curPr.Name,
                                    Price = curPr.Price,
                                    Source = curPr.Source,
                                    Quantity = 1
                                };
                                Order order = new Order
                                {
                                    Id_product = curPr.Id,
                                    Id_user = 3,
                                    Quantity = 1
                                };
                                pur.Purchases.Add(purchase);
                                pur.SaveChanges();
                                or.Orders.Add(order);
                                or.SaveChanges();                                
                                MessageBox.Show("Покупка совершена");
                            }
                            else if (curPr.Quantity == 1)
                            {                                                                                              
                                Purchase purchase = new Purchase
                                {
                                    Product_id = curPr.Id,
                                    Name = curPr.Name,
                                    Price = curPr.Price,
                                    Source = curPr.Source,
                                    Quantity = 1
                                };
                                Order order = new Order
                                {
                                    Id_product = curPr.Id,
                                    Id_user = 3,
                                    Quantity = 1
                                };
                                pur.Purchases.Add(purchase);
                                pur.SaveChanges();
                                or.Orders.Add(order);
                                or.SaveChanges();                               
                                MessageBox.Show("Покупка совершена");
                                db.Products.Remove(curPr);
                                db.SaveChanges();
                                Items.Remove(product);
                                MessageBox.Show("Продукт закончился");
                            }
                        }
                        else if (p!= null)
                        {
                            if (curPr.Quantity >= 2)
                            { 
                            curPr.Quantity--;
                            db.Entry(curPr).State = EntityState.Modified;
                            db.SaveChanges();
                            Items = new ObservableCollection<Product>(db.Products.ToList());
                            p.Quantity++;
                            pur.Entry(p).State = EntityState.Modified;
                            pur.SaveChanges();
                            o.Quantity++;
                            or.Entry(o).State = EntityState.Modified;
                            or.SaveChanges();                           
                            MessageBox.Show("Покупка совершена");
                            }
                            else if (curPr.Quantity ==1 )
                            {
                            p.Quantity++;
                            pur.Entry(p).State = EntityState.Modified;
                            pur.SaveChanges();
                            o.Quantity++;
                            or.Entry(o).State = EntityState.Modified;
                            or.SaveChanges();
                            Items.Remove(product);
                            MessageBox.Show("Покупка совершена");
                            db.Products.Remove(curPr);
                            db.SaveChanges();                            
                            MessageBox.Show("Продукт закончился");
                              
                           
                            }
                        }                           
                    }));
            }
        }

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

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

    }

}
