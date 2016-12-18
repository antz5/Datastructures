using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearch
{
    public class LinearSearch
    {
        public int Search(int[] items, int key)
        {
            int position = -1;
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == key)
                {
                    position = i;
                    return position;
                }
            }
            return position;
        }
    }
}

