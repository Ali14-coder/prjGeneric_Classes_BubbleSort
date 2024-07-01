using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjGeneric_Classes_BubbleSort
{
    public class Generic_Results<T>
    {
        private static object[] results; //unsorted results
        private static object[] sorted_results; //sorted results
        private static int x = 0; 

        public Generic_Results(int size)
        {
            results = new object[size];
        }

        public void Push (object results1, object results2, object results3, object results4, object results5)
        {
            results[0] = results1;
            results[1] = results2;
            results[2] = results3;
            results[3] = results4;
            results[4] = results5;
        }

        public object[] Display_and_Sort()
        {
            int temp = 0;
            for (int y=0; y<results.Length-1; y++)
            {
                for (int x = 0; x < results.Length - 1; x++)
                {
                    int res1 = Convert.ToInt32(results[x]);
                    int res2 = Convert.ToInt32(results[x + 1]);
                    if (res1 > res2)
                    {
                        //Bubble sort
                        temp = res1;
                        results[x] = res2;
                        results[x + 1] = res1;
                    }
                }
            }
            sorted_results = results;
            return sorted_results;
        }
    }
}
