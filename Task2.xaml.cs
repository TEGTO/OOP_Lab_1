using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace OOP_Lab_1
{
    /// <summary>
    /// Interaction logic for task2.xaml
    /// </summary>

    enum CheckBoxTypes
    {
        Triangle = 1, Quadrilateral
    }
    public partial class Task2 : Window
    {
       
     
        int checkBoxType = 0;
        public Task2()
        {
            InitializeComponent();    
        }

        private void UncheckMainMethod()
        {
            RectangleCanvas.Visibility = Visibility.Hidden;
            checkBoxType = 0;
            MainFigureCanvas.Visibility = Visibility.Hidden;
            TriangleCanvas.Visibility = Visibility.Hidden;
        }
        private void TriangleCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (RectangleCheckBox.IsChecked == true)RectangleCheckBox_Unchecked(sender, e);
            TriangleCanvas.IsEnabled = true;
            TriangleCanvas.Visibility = Visibility.Visible;
            checkBoxType = (int)CheckBoxTypes.Triangle;
            
          
        }
        private void TriangleCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            TriangleCheckBox.IsChecked = false;
            TriangleCanvas.IsEnabled = false;
            UncheckMainMethod();
        }
        private void RectangleCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (TriangleCheckBox.IsChecked == true) TriangleCheckBox_Unchecked(sender, e);
            RectangleCanvas.IsEnabled = true;
            RectangleCanvas.Visibility = Visibility.Visible;
            checkBoxType = (int)CheckBoxTypes.Quadrilateral;
        }
        private void RectangleCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            RectangleCheckBox.IsChecked = false;
            RectangleCanvas.IsEnabled = false;
            UncheckMainMethod();
        }
        private void FigureTypePrint(int FigureType)
        {
            switch (checkBoxType)
            {
                case (int)CheckBoxTypes.Triangle:
                    switch (FigureType)
                    {
                        case (int)TriangleTypes.Scalene: labelType.Content= "TYPE = Scalene Triangle"; break;
                        case (int)TriangleTypes.Equilateral: labelType.Content = "TYPE = Equilateral Triangle"; break;
                        case (int)TriangleTypes.Isosceles: labelType.Content = "TYPE = Isosceles Triangle"; break;
                        case (int)TriangleTypes.Right: labelType.Content = "TYPE = Right Triangle"; break;
                        default:
                            labelType.Content = "TYPE = Invalid Triangle";
                            break;
                    }
                    break;
                case (int)CheckBoxTypes.Quadrilateral:
                    switch (FigureType)
                    {
                        case (int)QuadrilateralTypes.FreeQuadrilateral: labelType.Content = "TYPE = Free Quadrilateral"; break;
                        case (int)QuadrilateralTypes.Rectangle: labelType.Content = "TYPE = Rectangle"; break;
                        case (int)QuadrilateralTypes.Trapezoid: labelType.Content = "TYPE = Trapezoid"; break;
                        case (int)QuadrilateralTypes.TrapezoidRight:labelType.Content = "TYPE = Right Trapezoid";break;
                        case (int)QuadrilateralTypes.TrapezoidIsosceles: labelType.Content="TYPE = Isosceles Trapezoid"; break;
                        case (int)QuadrilateralTypes.Rhombus: labelType.Content = "TYPE = Rhombus"; break;
                        case (int)QuadrilateralTypes.Square: labelType.Content = "TYPE = Square"; break;
                        case (int)QuadrilateralTypes.Parallelogram: labelType.Content = "TYPE = Parallelogram"; break;
                        default:
                            labelType.Content = "TYPE = Invalid Quadrilateral";
                            break;
                    }
                    break;
                default:
                    break;
            }
          
        }
        

        private void DrawMainFigure(int FigureType)
        {
            switch (checkBoxType)
            {
                case (int)CheckBoxTypes.Triangle:
                    switch (FigureType)
                    {
                        case (int)TriangleTypes.Scalene:
                            MainFigure.Points = new PointCollection() { new Point(0, 200), new Point(200, 200), new Point(50, 50) };
                            break;
                        case (int)TriangleTypes.Equilateral:
                            MainFigure.Points = new PointCollection() { new Point(0, 200), new Point(400, 200), new Point(200, 0) };
                            break;

                        case (int)TriangleTypes.Isosceles:
                            MainFigure.Points = new PointCollection() { new Point(0, 200), new Point(400, 200), new Point(200, 50) };
                            break;
                        case (int)TriangleTypes.Right:
                            MainFigure.Points = new PointCollection() { new Point(0, 200), new Point(0, 0), new Point(200, 200) };
                            break;
                        default:
                            MainFigure.Points = new PointCollection() { new Point(0, 0), new Point(0, 0), new Point(0, 0) };
                            break;
                    }
                    break;
                case (int)CheckBoxTypes.Quadrilateral:
                    switch (FigureType)
                    {
                        case (int)QuadrilateralTypes.FreeQuadrilateral:
                            MainFigure.Points = new PointCollection() { new Point(80, 200), new Point(280, 210), new Point(240, 100), new Point(100, 50) };
                            break;
                        case (int)QuadrilateralTypes.Rectangle:
                            MainFigure.Points = new PointCollection() { new Point(80, 200), new Point(280, 200), new Point(280, 100), new Point(80, 100) };
                            break;
                        case (int)QuadrilateralTypes.Trapezoid:
                            MainFigure.Points = new PointCollection() { new Point(80, 200), new Point(280, 200), new Point(240, 0), new Point(120, 0) };
                            break;
                       case (int)QuadrilateralTypes.TrapezoidRight:
                            MainFigure.Points = new PointCollection() { new Point(80, 200), new Point(280, 200), new Point(150, 0), new Point(80, 0) };
                            break;
                        case (int)QuadrilateralTypes.TrapezoidIsosceles:
                            MainFigure.Points = new PointCollection() { new Point(80, 200), new Point(290, 200), new Point(240, 0), new Point(120, 0) };
                            break;
                        case (int)QuadrilateralTypes.Rhombus:
                            MainFigure.Points = new PointCollection() { new Point(80, 200), new Point(180, 300), new Point(280, 200), new Point(180, 100) };
                            break;
                        case (int)QuadrilateralTypes.Square:
                            MainFigure.Points = new PointCollection() { new Point(80, 200), new Point(280, 200), new Point(280, 0), new Point(80, 0) };
                            break;
                        case (int)QuadrilateralTypes.Parallelogram:
                            MainFigure.Points = new PointCollection() { new Point(80, 200), new Point(280, 200), new Point(340, 0), new Point(140, 0) };
                            break;
                        default:
                            MainFigure.Points = new PointCollection() { new Point(0, 0), new Point(0, 0), new Point(0, 0) };
                            break;
                    }
                    break;
                        default:
                    break;
            }

           
            
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            switch (checkBoxType)
            {
                case (int)CheckBoxTypes.Triangle:

                 
                    try
                    {
                      
                        Triangle.FirstSide = Convert.ToDouble(FirstSide_Triangle.Text);
                        Triangle.SecondSide = Convert.ToDouble(SecondSide_Triangle.Text);
                        Triangle.ThirdSide = Convert.ToDouble(ThirdSide_Triangle.Text);
                        Triangle.FirstAngle = Convert.ToDouble(FirstAngle_Triangle.Text);
                        Triangle.SecondAngle = Convert.ToDouble(SecondAngle_Triangle.Text);
                        Triangle.ThirdAngle = Convert.ToDouble(ThirdAngle_Triangle.Text);
                    }
                    catch (Exception) { }
                    labelPerimeter.Content = $"P = {Triangle.Perimeter()}";
                    labelS.Content = $"S = {Triangle.Area()}";
                    FigureTypePrint(Triangle.DefineType());
                    DrawMainFigure(Triangle.DefineType());
                  
                    break;

                case (int)CheckBoxTypes.Quadrilateral:
                    try
                    {
                        Quadrilateral.A = Convert.ToDouble(ASide_Rectangle.Text);
                        Quadrilateral.B = Convert.ToDouble(BSide_Rectangle.Text);
                        Quadrilateral.C = Convert.ToDouble(CSide_Rectangle.Text);
                        Quadrilateral.D = Convert.ToDouble(DSide_Rectangle.Text);
                        Quadrilateral.AngleBetweenAC = Convert.ToDouble(ACAngle_Rectangle.Text);
                        Quadrilateral.AngleBetweenCB = Convert.ToDouble(CBAngle_Rectangle.Text);
                        Quadrilateral.AngleBetweenDA = Convert.ToDouble(DAAngle_Rectangle.Text);
                        Quadrilateral.AngleBetweenBD = Convert.ToDouble(BDAngle_Rectangle.Text);
                    }
                    catch (Exception) { }
                    labelPerimeter.Content = $"P = {Quadrilateral.Perimeter()}";
                    labelS.Content = $"S = {Quadrilateral.Area()}";
                    FigureTypePrint(Quadrilateral.DefineType());
                    DrawMainFigure(Quadrilateral.DefineType());
                    break;
                default:
                    break;
            }
            MainFigureCanvas.Visibility = Visibility.Visible;
        }
    
        
    }
}
