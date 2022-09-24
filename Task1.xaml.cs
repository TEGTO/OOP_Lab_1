using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OOP_Lab_1
{
    public partial class Task1 : Window 
    {
        MyList<int> listToSort = new MyList<int> { };
        Sorting<int> sortingMethods = new Sorting <int> (); 
        public Task1()
        {
            InitializeComponent();
        }

        //public delegate void DelegateSort(object source, SortingEventArgs<int> arg);
        private void Button_AddElement(object sender, RoutedEventArgs e)
        {
           
            Random random = new Random();
            int randomNumber = random.Next(100);
            listToSort.AddHead(randomNumber);
            Label1.Content += " "+randomNumber.ToString();
            Label1.Content += listToSort.Length % 20 == 0 ? "\n" : "";
          
        }
        private void Button_ShuffleList(object sender, RoutedEventArgs e)
        {

            Random random = new Random();
        
            for (int i = 0; i < listToSort.Length; i++)
            {
                listToSort[i]= random.Next(100);
            }

            PrintList();
        }
        void SubscribeSortMethod(SortMethod<int> foo)
        {
            sortingMethods.SortMethods += foo.Sort;
            sortingMethods.Sort(listToSort);
            sortingMethods.SortMethods -= foo.Sort;
            PrintList();
        }
        void PrintList()
        {
            Label1.Content = " ";
            int iterator = 0;
            foreach (var item in listToSort)
            {
                Label1.Content += " " + item;
                iterator++;
                Label1.Content += iterator % 20 == 0 ? "\n " : "";
            }
        }
        
        private void Button_PrintList(object sender, RoutedEventArgs e)
        {
            PrintList();
        }

        private void Button_InsertionSort(object sender, RoutedEventArgs e)
        {
            var insertion = new Insertion<int>();
            SubscribeSortMethod(insertion);
        }

        private void Button_QuickSort(object sender, RoutedEventArgs e)
        {
            var quickSort = new QuickSort<int>();
            SubscribeSortMethod(quickSort);
        }
        private void Button_MergeSort(object sender, RoutedEventArgs e)
        {
            var mergeSort = new MergeSort<int>();
            SubscribeSortMethod(mergeSort);
        }

        private void Button_BubbleSort(object sender, RoutedEventArgs e)
        {
            var bubbleSort = new BubbleSort<int>();
            SubscribeSortMethod(bubbleSort);
        }

        private void Button_SelectionSort(object sender, RoutedEventArgs e)
        {
            var selectionSort = new SelectionSort<int>();
            SubscribeSortMethod(selectionSort);
        }

        private void Button_CountingSort(object sender, RoutedEventArgs e)
        {
            var countingSort = new CountingSort<int>();
            SubscribeSortMethod(countingSort);
        }

        private void Button_BucketSort(object sender, RoutedEventArgs e)
        {
            var bucketSort = new BucketSort<int>();
            SubscribeSortMethod(bucketSort);
        }

        private void Button_OpenTask2(object sender, RoutedEventArgs e)
        {

            Task2 Task2 = new Task2();
            Task2.Show();
        }

        
    }
}
