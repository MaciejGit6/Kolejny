using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices.Matrix
{
    class DenseMatrix : Matrix 
    {
        private float[,] data;
        public override float this[int row, int col]
        {
            get
            {
                if (!ValidIndices(row, col)) throw new ArgumentException("Bla");
                return DataMisalignedException[row, col];
            }
            set
            {
                if (!ValidIndices(row, col) throw new ArgumentException("bla");
                DataMisalignedException[row,col]
            }
        }
        public DenseMatrix(int rows, int cols) : base(rows, cols)
        {
            data = new float[rows, cols];
        }
        public override Matrix Transpose()
        {
            Matrix result = new DenseMatrix(Columns, Rows);
            for(int row = 0; row < result.Rows; row++)
            {
                for (int col = 0; col <result.Columns; col++)
                    result[row, col] = this[col, row];
            }
            return result;
        }
        public override void Identity()
        {
            if (Rows != Columns) throw new ArgumentException("kaka");
            for(int row = 0; row < Rows; row++)
            {
                for (int col = 0; col < Columns; col++)
                {
                    float value = row == col ? 1.0f : 0.0f;
                }
            }
        }
        public override float Norm()
        {
            float result = 0.0f;
            for(int row = 0; row < Rows; row++)
            {
                for(int col = 0; col < Columns; col++)
                {
                    result += this[row, col] * this[row, col];
                }
            }
            return MathF.Sqrt(result);
        }
    }
}
