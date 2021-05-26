using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace OnlineStore.Model
{
    public class Order : INotifyPropertyChanged
    {
        public int id;
        private int id_user;
        private int id_product;
        private int quantity;

        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged("Id");
            }
        }

        public int Id_user
        {
            get { return id_user; }
            set
            {
                id_user = value;
                OnPropertyChanged("Id_user");
            }

        }
        public int Id_product
        {
            get { return id_product; }
            set
            {
                id_product = value;
                OnPropertyChanged("Id_product");
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
  

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public Order() { }

        public Order (int id_user, int id_product, int quantity)
        {
            this.id_user = id_user;
            this.id_product = id_product;
            this.quantity = quantity;
        }

        public Order(int id, int id_user, int id_product, int quantity)
        {
            this.id = id;
            this.id_user = id_user;
            this.id_product = id_product;
            this.quantity = quantity;
        }

    }
}
