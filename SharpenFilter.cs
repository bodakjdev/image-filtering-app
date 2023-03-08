using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class SharpenFilter : ConvFilterBase
    {
        private double factor = 1;
        private double bias = 0;
        private double[,] filtermatrix =
            new double[,] { { 0, -1, 0 }, { -1, 5, -1 }, { 0, -1, 0 } };
        public override string FilterName
        {
            get { return "Sharpen"; }
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
            get { return -1; }
        }

        public override int GetanchorY
        {
            get { return -1; }
        }
    }
}
