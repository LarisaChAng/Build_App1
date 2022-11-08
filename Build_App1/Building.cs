using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Build_App1
{        
    class Building
    {
        string adr;
        int length;
        int width;
        int heigth;

        int Length
        {
            get
            {
                return length;
            }
            set
            {
                if (value <= 0)
                    length = 1;
                else
                    length = value;
            }
        }

        public Building(string adr, int length, int width, int heigth)
        {
            this.adr = adr;
            this.Length = length;
            this.width = width;
            this.heigth = heigth;
        }

        public string Print()
        {
            return $"Расположение ОКС: {adr}. Параметры: длина {length}, ширина {width}, высота {heigth}.";
        }
    }
}
