using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneKavramı
{
    internal class Car
    {
        private string _color, _producer, _model, _segment, _bodyType, _productYear, _fuel, _transmissionType, _traction;
        private double _engineLiter, _horsePower, _weight, _torque;
        private int _cylinderCount, _speedCount;
        private DateTime _year;

        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public string Producer
        {
            get { return _producer; }
            set { _producer = value; }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public string Segment
        {
            get { return _segment; }
            set { _segment = value; }
        }

        public string BodyType
        {
            get { return _bodyType; }
            set { _bodyType = value; }
        }

        public string ProductYear
        {
            get { return _productYear; }
            set
            {
                bool isYear = true;

                _productYear = value;
                if (isYear = false)
                {
                    throw new Exception("Lütfen bir yıl ifadesi girin");
                }
                else
                {
                    isYear = DateTime.TryParse(value, out _year);
                }
            }
        }

        public string Fuel
        {
            get { return _fuel; }
            set { _fuel = value; }
        }

        public string TransmissionType
        {
            get { return _transmissionType; }
            set { _transmissionType = value; }
        }

        public string Traction
        {
            get { return _traction; }
            set
            {
                _traction = value;
            }
        }

        public double EngineLiter
        {
            get { return _engineLiter; }
            set
            {
                _engineLiter = value;
            }
        }

        public double HorsePower
        {
            get { return _horsePower; }
            set
            {
                _horsePower = value;
            }
        }

        public double Weight
        {
            get { return _weight; }
            set
            {
                _weight = value;
            }
        }

        public double Torque
        {
            get { return _torque; }
            set { _torque = value; }
        }

        public int SpeedCount
        {
            get { return _speedCount; }
            set
            {
                _speedCount = value;
            }
        }

        public int CylinderCount
        {
            get { return _cylinderCount; }
            set { _cylinderCount = value; }
        }

        public void Acceleration(double mass,double torque)
        {
            double acceleration = mass/torque;
            Console.WriteLine($"{_producer} marka {_model} model araç saniyede {acceleration} metre ivmelenebilir.");
        }
        public void Acceleration(double mass, double horsePower, double torque)
        {
            double acceleration = mass / torque*horsePower*0.768;
            Console.WriteLine($"{_producer} marka {_model} model araç saniyede {acceleration} metre ivmelenebilir.");

        }

    }
}
