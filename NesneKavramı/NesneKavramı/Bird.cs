using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneKavramı
{
    internal class Bird
    {
        /*
         * field: Değişken
         * Property: Özellik
         * Method: yapabilirlik
         */
        //Field
        private string _renk = null;

        //Property
        public string Renk
        {
            get { return _renk; } // get etme okuma işlemi
            set { _renk = value; } // setter değer yazma
        }
        //Kuşların max Yaşı 10 olabilir min 0 olabilir
        //Class içerisinde field tanımlarken private
        //Property tanımlarken public
        private int _yas;

        public int Yas
        {
            get { return _yas; }
            set
            {
                if (value < 0 || value > 10)
                {
                    throw new Exception("Kuşların yaşı 10 dan büyü ve 0 dan küçük olamaz");
                }
                else
                {
                    _yas = value;
                }
                
            }
        }

        public void Fly()
        {
            Console.WriteLine($"{Renk} rengindeki kuş uçuyor");
        }


    }
}
