using System;
using System.Collections.Generic;
using System.Text;

namespace ClassPTBac1a
{
    internal class PTB1
    {
        public double soA { get; set; }
        public double soB { get; set; }

        public PTB1(double soA, double soB)
        {
            this.soA = soA;
            this.soB = soB;
        }

        public PTB1()
        {
        }

        public double nghiem { get; set; }

        internal double Giai()
        {
            if (soA == 0)
            {
                if (soB == 0)
                {
                    throw new Exception("phuong trinh vo so nghiem");
                }
                else
                {
                    throw new Exception("phuong trinh vo nghiem");
                }
            }
            return -soB / soA;
        }
    }
}
