using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public abstract class ConvFilterBase
    {
        public abstract string FilterName
        {
            get;
        }

        public abstract double Factor
        {
            get;
        }

        public abstract double Bias
        {
            get;
        }

        public abstract double[,] FilterMatrix
        {
            get;
        }

        public abstract int GetanchorX
        {
            get;
        }

        public abstract int GetanchorY
        {
            get;
        }
    }
}
