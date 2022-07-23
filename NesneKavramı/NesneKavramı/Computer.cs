using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneKavramı
{
    internal class Computer
    {
        //Fields
        private string _manufacturer, _model, _type, _operatingSystem, _processor, _processorProducter, _graphicsUnit, _graphicsUnitProducter, _storageTechnology;
        private int _ramCapacity, _storageCapacity, _processorCoreCount, _graphicsUnitMemory, _coolingSystemType, _coolerFanCount;
        private bool _integratedKeyboard, _integratedKeyboardBackLight;
        private double _screenSize, _weight, _batteryCapacity;
        private decimal _price;

        //Properties
        public string Manufacturer
        {
            get { return _manufacturer; }
            set { _manufacturer = value; }
        }
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public bool IntegratedKeyboard
        {
            get { return _integratedKeyboard; }
            set { _integratedKeyboard = value; }
        }
        public bool IntegratedKeyboardBacklight
        {
            get { return _integratedKeyboardBackLight; }
            set
            {
                _integratedKeyboardBackLight = value;
            }
        }
        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }

        //Methods
        public void PriceCalculate(decimal price, int ramCapacity, string processor, int storageCapacity)
        {
            Random rnd = new Random();
            if (ramCapacity<5 && processor == "Celeron" && storageCapacity<256)
            {
                price = rnd.Next(4500);
            }else if(ramCapacity<9 && processor.Contains("i3") || processor.Contains("i5") && storageCapacity < 512)
            {
                _price = rnd.Next(8000, 15000);
            }
        } 
    }
}
