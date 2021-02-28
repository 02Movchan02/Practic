using System;
using System.Collections.Generic;
using System.Text;

namespace z2
{
    public class usl
    {
        private double x;
        public usl(double x)
        {
            this.x = x;
        }
        public string NonR
        {
            get { return "Нет решения"; }
        }
        public double res1
        {
            get { return Math.Sqrt(x - 8); }
        }
        public double res2
        {
            get { return 1 / (7 + x) + 5; }
        }
        public double res3
        {
            get { return 1 / (x - 3); }
        } 
    }
}
