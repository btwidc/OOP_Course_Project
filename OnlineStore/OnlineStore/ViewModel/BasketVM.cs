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
    public class BasketVM : INotifyPropertyChanged
    {
        public ObservableCollection<Purchase> Purchases { get; set; }

        public BasketVM()
        {
            using (PurchaseContext db = new PurchaseContext())
            {
                Purchases = new ObservableCollection<Purchase>(db.Purchases.ToList());
            }
        }


        private Purchase selectedPurchase;
        public Purchase SelectedPurchase
        {
            get { return selectedPurchase; }
            set
            {
                selectedPurchase = value;
                OnPropertyChanged("selectedPurchase");
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
