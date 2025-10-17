using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices.Matrix
{
    class Matrix
    {
        public int Rows { get; }
        public int Columns { get; }
        public abstract float this[int row]
    }
}
