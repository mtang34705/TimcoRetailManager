using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRMWPFUserInterface.ViewModels
{
    public class SalesViewModel:Screen
    {
        private BindingList<string> _products;

        public BindingList<string> Products
        {
            get { return _products; }
            set { 
                _products = value;
                NotifyOfPropertyChange(() => Products);
            }

        }
        private int _itemQuantity;

        public int ItemQuantity
        {
            get { return _itemQuantity; }
            set { _itemQuantity = value;
                NotifyOfPropertyChange(() => ItemQuantity);
            }
        }

        public bool CanAddToCart { 
            get {
                return false;
            } 
        }
        public void AddToCart()
        {
          

        }
        public bool CanRemoveFromCart
        {
            get
            {
                return false;
            }
        }
        public void RemoveFromCart()
        {


        }

        private BindingList<string> _cart;

        public BindingList<string> Cart
        {
            get { return _cart; }
            set { _cart = value;
                NotifyOfPropertyChange(() => Cart);
            }
        }

        public string SubTotal { get { return "0.00"; } }
        public string Total { get { return "0.00"; } }
        public string Tax { get { return "0.00"; } }

        public bool CanCheckout
        {
            get
            {
                return false;
            }
        }
        public void Checkout()
        {


        }
    }
}
