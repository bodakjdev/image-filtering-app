using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class EmbossFilter : ConvFilterBase
    {

        private double factor = 1;
        private double bias = 0;
        private double[,] filtermatrix =
            new double[,] { { -1, -1, 0 }, 
                { -1, 1, 1 }, 
                { 0, 1, 1 } };
        public override string FilterName
        {
            get { return "Emboss"; }
        }


        public override double Factor
        {
            get { return  factor; }
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
