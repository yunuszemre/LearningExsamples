using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketProductTrack
{
    internal class Product
    {
        private string _id;
        private string _productName;
        private string _description;
        private string _price;
        private string _productType;
        private DateTime _lastUseDate;
        private string _count;

        public string Id
        {
            get => _id;
            set => _id = value;
        }

        public string Name
        {
            get => _productName;
            set => _productName = value;
        }
        public string Description
        {
            get => _description;
            set => _description = value;
        }

        public string Price
        {
            get => _price;
            set => _price = value;
        }

        public string ProductType
        {
            get => _productType;
            set => _productType = value;
        }

        public DateTime LastUseDate
        {
            get => _lastUseDate;
            set => _lastUseDate = value;
        }

        public string Count
        {
            get=> _count;
            set => _count = value;
        }

    }
}
