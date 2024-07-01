using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjGeneric_Classes_BubbleSort
{
    sealed class Calculate_Average
    {
        public double determine_avg(object[] results)
        {
            double dbAVG = 0.0;
            foreach (var item in results)
            {
                dbAVG += Convert.ToDouble(item);
            }
            return dbAVG/results.Length;
        }
    }
}
