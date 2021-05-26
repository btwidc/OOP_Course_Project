using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace OnlineStore.Model
{
    public class Purchase : INotifyPropertyChanged
    {
        public int id;
        public int product_id;
        private string name;
        private decimal price;
        private int quantity;
        private string source;

        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged("Id");
            }

        }

        public int Product_id
        {
            get { return product_id; }
            set
            {
                product_id = value;
                OnPropertyChanged("Product_id");
            }

        }


        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }

        }

        public decimal Price
        {
            get { return price; }
            set
            {
                price = value;
                OnPropertyChanged("Price");
            }
        }

        public int Quantity
        {
            get { return quantity; }
            set
            {
                quantity = value;
                OnPropertyChanged("Quantity");
            }
        }

        public string Source
        {
            get { return source; }
            set
            {
                source = value;
                OnPropertyChanged("Source");
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public Purchase() { }

        public Purchase(int product_id, string name, decimal price, int quantity, string source)
        {
            this.product_id = product_id;
            this.name = name;
            this.price = price;
            this.quantity = quantity;
            this.source = source;
        }

    }
}
