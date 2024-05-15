using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharpObj
{
    internal class Matrix
    {
        private double[,] data;
        public Matrix (int row, int column)
        {
            data = new double[row, column];
        }

        // Use indexers to access the class like it is an array
        public double this[int row, int column]
        {
            get => data[row, column];
            set => data[row, column] = value;
        }
    }
}
