using OOP_Lab_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Insertion <T> where T : IComparable
{
     public void Sort(object source , SortingEventArgs<T> arg)
    {
        
        int n = arg.mylist.Lenght;
       for (int i = 1; i < n; ++i)
        {
            var key = arg.mylist[i];
            int j = i - 1;
      
            while (j >= 0 && key.CompareTo(arg.mylist[j]) < 0)
            {
             
                arg.mylist[j + 1] = arg.mylist[j];
                j = j - 1;
            }
            arg.mylist[j + 1] = key;
        }
      
    }
}
class QuickSort<T> where T: IComparable
{

 
     int Partition(MyList<T> array, int minIndex, int maxIndex)
    {
        var pivot = minIndex - 1;
        T buffer;
        for (var i = minIndex; i < maxIndex; i++)
        {
            if (array[i].CompareTo(array[maxIndex]) <0)
            {
                pivot++;
                buffer = array[pivot];
                array[pivot] = array[i];
                array[i] = buffer; 
            }
        }

        pivot++;
        buffer = array[pivot];
        array[pivot] = array[maxIndex];
        array[maxIndex] = buffer;
        return pivot;
    }

     MyList<T>Sorting(MyList<T> array, int minIndex, int maxIndex)
    {
        if (minIndex >= maxIndex)
        {
            return array;
        }

        var pivotIndex = Partition(array, minIndex, maxIndex);
        Sorting(array, minIndex, pivotIndex - 1);
        Sorting(array, pivotIndex + 1, maxIndex);

        return array;
    }

    public void Sort(object source, SortingEventArgs<T> arg)
    {
         Sorting(arg.mylist, 0, arg.mylist.Lenght - 1);
        
    }
}


class MergeSort<T> where T : IComparable
{
    void Merge(MyList<T> arr, int l, int m, int r)
    {

        int n1 = m - l + 1;
        int n2 = r - m;
        T[] L = new T[n1];
        T[] R = new T[n2];
        int i, j;

        for (i = 0; i < n1; ++i)
            L[i] = arr[l + i];
        for (j = 0; j < n2; ++j)
            R[j] = arr[m + 1 + j];
        i = 0;
        j = 0;
        int k = l;
        while (i < n1 && j < n2)
        {
            if (L[i].CompareTo(R[j]) <= 0)
            {
                arr[k] = L[i];
                i++;
            }
            else
            {
                arr[k] = R[j];
                j++;
            }
            k++;
        }
        while (i < n1)
        {
            arr[k] = L[i];
            i++;
            k++;
        }
        while (j < n2)
        {
            arr[k] = R[j];
            j++;
            k++;
        }
    }

    void sorting(MyList<T> arr, int l, int r)
    {
        if (l < r)
        {

            int m = l + (r - l) / 2;

            sorting(arr, l, m);
            sorting(arr, m + 1, r);
            Merge(arr, l, m, r);
        }
    }
   public void Sort(object source, SortingEventArgs<T> arg)
    {
        sorting(arg.mylist, 0, arg.mylist.Lenght - 1);
    }
}