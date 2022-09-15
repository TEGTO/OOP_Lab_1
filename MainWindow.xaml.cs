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
    public partial class MainWindow : Window
    {
        MyList<int> listToSort = new MyList<int> { };
        Sorting<int> sortingMethods = new Sorting <int> (); 
        public MainWindow()
        {
            InitializeComponent();
        }
           
        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
            Random random = new Random();
            int randomNumber = random.Next(100);
            listToSort.AddHead(randomNumber);
            Label1.Content += " "+randomNumber.ToString();
            Label1.Content += listToSort.Lenght % 10 == 0 ? "\n" : "";
          
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Label1.Content = " ";
            int iterator = 0;
            foreach (var item in listToSort)
            {
                Label1.Content += " " + item;
                iterator++;
                Label1.Content += iterator % 10 == 0 ? "\n " : "";
            }
        }
    }
}
