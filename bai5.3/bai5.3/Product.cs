using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace bai5._3
{
    public class Product : INotifyPropertyChanged
    {
        private string productId = string.Empty;
        private string productName = string.Empty;
        private decimal unitPrice;
        private int quantity;
        private string category = string.Empty;

        public string ProductId
        {
            get => productId;
            set => Set(ref productId, value);
        }

        public string ProductName
        {
            get => productName;
            set => Set(ref productName, value);
        }

        public decimal UnitPrice
        {
            get => unitPrice;
            set => Set(ref unitPrice, value);
        }

        public int Quantity
        {
            get => quantity;
            set => Set(ref quantity, value);
        }

        public string Category
        {
            get => category;
            set => Set(ref category, value);
        }

        public decimal TotalAmount => UnitPrice * Quantity;

        public Product() { }

        public Product(string id, string name, decimal price, int qty, string cat)
        {
            ProductId = id;
            ProductName = name;
            UnitPrice = price;
            Quantity = qty;
            Category = cat;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected bool Set<T>(ref T field, T value, [CallerMemberName] string? propName = null)
        {
            if (Equals(field, value)) return false;
            field = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
            if (propName == nameof(UnitPrice) || propName == nameof(Quantity))
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(TotalAmount)));
            }
            return true;
        }
    }
}
