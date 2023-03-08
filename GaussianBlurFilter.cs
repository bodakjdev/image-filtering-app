using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class GaussianBlurFilter : ConvFilterBase
    {
        private double factor = 16;
        private double bias = 0;
        private double[,] filtermatrix =
            new double[,] { { 1, 2, 1 }, { 2, 4, 2 }, { 1, 2, 1 } };
        public override string FilterName
        {
            get { return "Gaussian Blur"; }
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
