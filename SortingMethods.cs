using OOP_Lab_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


static class Insertion <T> where T : IComparable
{
    static public void Sort(MyList <T> arr)
    {
        
        int n = arr.Lenght;
        for (int i = 1; i < n; ++i)
        {
            var key = arr[i];
            int j = i - 1;
            int check = key.CompareTo(arr[i]);
            while (j >= 0 && check<0)
            {
                check = key.CompareTo(arr[i]);
                arr[j + 1] = arr[j];
                j = j - 1;
            }
            arr[j + 1] = key;
        }
    }
}