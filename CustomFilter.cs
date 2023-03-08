using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class CustomFilter : ConvFilterBase
    {
        private double factor;
        private double bias;
        private double[,] filtermatrix;
        private string name;
        private int anchorX;
        private int anchorY;

        public CustomFilter(double fac, double b, double[,] filmat, string n, int anx, int any)
        {
            factor = fac;
            bias = b;
            filtermatrix = filmat;
            name = n;
            anchorX = anx;
            anchorY = any;  
        }

        public override string FilterName
        {
            get { return name; }
        }


        public override double Factor
        {
            get { return factor; }
        }


        public override double Bias
        {
            get { return bias; }
        }


        public override double[,] FilterMatrix
        {
            get { return filtermatrix; }
        }

        public override int GetanchorX
        {
            get
            {
                return anchorX;
            }
        }

        public override int GetanchorY
        {
            get
            {
                return anchorY;
            }
        }
    }
}
