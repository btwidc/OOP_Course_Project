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
    public class OrderVM : INotifyPropertyChanged
    {
        public ObservableCollection<Order> Orders { get; set; }

        public OrderVM()
        {
            using (OrderContext db = new OrderContext())
            {
                Orders = new ObservableCollection<Order>(db.Orders.ToList());
            }
        }


        private Order selectedOrder;
        public Order SelectedOrder
        {
            get { return selectedOrder; }
            set
            {
                selectedOrder = value;
                OnPropertyChanged("SelectedOrder");
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
