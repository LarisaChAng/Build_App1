using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Build_App1
{
    sealed class MultiBuilding : Building
    {
        int floor;

        int Floor
        {
            get
            {
                return floor;
            }
            set
            {
                if (value <= 0)
                    floor = 1;
                else
                    floor = value;
            }
        }

        public MultiBuilding(string adr, int length, int width, int heigth, int floor)
                : base(adr, length, width, heigth)
        {
            this.Floor = floor;
        }

        public new string Print()
        {
            string result = base.Print();
            result += $" Этажность: {floor} эт.";
            return result;
        }
    }
}
