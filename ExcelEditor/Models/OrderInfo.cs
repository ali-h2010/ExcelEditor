using System;
using System.ComponentModel;

namespace ExcelEditor.Models
{
    public class OrderInfo : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }

        private int productId;
        private string _productName;
        private double _NoOfOrders;
        private DateTime _orderDate;
        private string countryName;
        private string shipCity;
        private int _shipid;

        public int ProductId
        {
            get
            {
                return productId;
            }
            set
            {
                productId = value;
                this.RaisePropertyChanged("ProductId");
            }
        }

        public string ProductName
        {
            get
            {
                return _productName;
            }
            set
            {
                _productName = value;
                RaisePropertyChanged("ProductName");
            }
        }

        public double NoOfOrders
        {
            get
            {
                return _NoOfOrders;
            }
            set
            {
                _NoOfOrders = value;
                RaisePropertyChanged("NoOfOrders");
            }
        }

        public DateTime OrderDate
        {
            get
            {
                return _orderDate;
            }
            set
            {
                _orderDate = value;
                RaisePropertyChanged("OrderDate");
            }
        }

        public string CountryName
        {
            get
            {
                return countryName;
            }
            set
            {
                countryName = value;
                RaisePropertyChanged("CountryName");
            }
        }

        public string ShipCity
        {
            get
            {
                return shipCity;
            }
            set
            {
                shipCity = value;
                RaisePropertyChanged("ShipCity");
            }
        }
        public int ShipId
        {
            get
            {
                return _shipid;
            }
            set
            {
                _shipid = value;
                RaisePropertyChanged("ShipId");
            }
        }

        private int orderID;
        private string customerID;
        private string customer;
 
        private string shipCountry;

        public int OrderID
        {
            get { return orderID; }
            set { this.orderID = value; }
        }

        public string CustomerID
        {
            get { return customerID; }
            set { this.customerID = value; }
        }

        public string ShipCountry
        {
            get { return shipCountry; }
            set { this.shipCountry = value; }
        }

        public string Customer
        {
            get { return this.customer; }
            set { this.customer = value; }
        }

       

        public OrderInfo(int orderId, string customerId, string country, string customer, string shipCity)
        {
            this.OrderID = orderId;
            this.CustomerID = customerId;
            this.Customer = customer;
            this.ShipCountry = country;
            this.ShipCity = shipCity;
        }

        public OrderInfo()
        {
        }
    }
}

