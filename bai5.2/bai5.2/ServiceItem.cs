using System;

namespace bai5._2
{
    public class ServiceItem
    {
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }

        public ServiceItem() { }

        public ServiceItem(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name} - {Price:N0} đ";
        }
    }
}
