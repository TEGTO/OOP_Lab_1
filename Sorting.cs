using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_Lab_1;
public class SortingEventArgs<T> : EventArgs
{
    public MyList<T> mylist;
   

}
public  class Sorting<T>
{
    public MyList<int> mylist;

    public event EventHandler SortMethods;
        public void Sort(MyList <T> list)
        {
            StartSorting(list);
      
        }

        protected virtual void StartSorting(MyList<T> list)
        {
        SortMethods?.Invoke(this, new SortingEventArgs <T>{ mylist = list });
        }
}

class SortingMethods
{

}
