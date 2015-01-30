using System;
using sharpshapes;
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
using System.Reflection;
//using System.Windows.Shapes;
using System.Drawing;

namespace GrapeShapes {
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window {
    public MainWindow() {
      InitializeComponent();
      PopulateClassList();
      //DrawRectangle();
      //Square square = new Square(20);
      //square.FillColor = System.Drawing.Color.Navy;
      //square.BorderColor = System.Drawing.Color.Fuchsia;
    }

    //private void DrawRectangle() {

    //  //Add the Polygon Element
    //  Polygon myPolygon = new Polygon();
    //  myPolygon.Stroke = System.Windows.Media.Brushes.Tomato;
    //  myPolygon.Fill = System.Windows.Media.Brushes.Bisque;
    //  myPolygon.StrokeThickness = 2;
    //  myPolygon.HorizontalAlignment = HorizontalAlignment.Left;
    //  myPolygon.VerticalAlignment = VerticalAlignment.Center;
    //  System.Windows.Point Point1 = new System.Windows.Point(1, 50);
    //  System.Windows.Point Point2 = new System.Windows.Point(1, 80);
    //  System.Windows.Point Point3 = new System.Windows.Point(50, 80);
    //  System.Windows.Point Point4 = new System.Windows.Point(50, 50);
    //  PointCollection myPointCollection = new PointCollection();
    //  myPointCollection.Add(Point1);
    //  myPointCollection.Add(Point2);
    //  myPointCollection.Add(Point3);
    //  myPointCollection.Add(Point4);
    //  myPolygon.Points = myPointCollection;
    //  ShapeCanvas.Children.Add(myPolygon);
    //}

    //private void DrawSquare(int x, int y, Square square) {

    //  Polygon myPolygon = new Polygon();

    //  var squareBorderColor = square.BorderColor;
    //  var strokeColor = System.Windows.Media.Color.FromArgb(squareBorderColor.A, squareBorderColor.R, squareBorderColor.G, squareBorderColor.B);
    //  var strokeBrush = new SolidColorBrush(strokeColor);
    //  myPolygon.Stroke = strokeBrush;
    //  myPolygon.StrokeThickness = 2;

    //  var squareFillColor = square.FillColor;
    //  var fillColor = System.Windows.Media.Color.FromArgb(squareFillColor.A, squareFillColor.R, squareFillColor.G, squareFillColor.B); 
    //  var fillBrush = new SolidColorBrush(fillColor);
    //  myPolygon.Fill = fillBrush;

    //  int width = (int)square.Width;
    //  int height = (int)square.Height;

    //  System.Windows.Point Point1 = new System.Windows.Point(x, y);
    //  System.Windows.Point Point2 = new System.Windows.Point(x+width, y);
    //  System.Windows.Point Point3 = new System.Windows.Point(x+width, y+height);
    //  System.Windows.Point Point4 = new System.Windows.Point(x, y+height);

    //  PointCollection myPointCollection = new PointCollection();
    //  myPointCollection.Add(Point1);
    //  myPointCollection.Add(Point2);
    //  myPointCollection.Add(Point3);
    //  myPointCollection.Add(Point4);
    //  myPolygon.Points = myPointCollection;
    //  ShapeCanvas.Children.Add(myPolygon);
    //}


    private void PopulateClassList() {
      List<string> shapeClassList = new List<string>();
      Type shapeType = typeof(sharpshapes.Shape);

      foreach (Type type in Assembly.GetAssembly(shapeType).GetTypes()) {
        if (type.IsSubclassOf(shapeType) && !type.IsAbstract) {
          shapeClassList.Add(type.Name);
        }
      }
      ShapeTypeComboBox.ItemsSource = shapeClassList;
    }

    public static int ArgumentCountFor(string className) {
      Type classType = Assembly.GetAssembly(typeof(Shape)).GetTypes().Where(shapeType => shapeType.Name == className).First();
      ConstructorInfo classConstructor = classType.GetConstructors().First();
      return classConstructor.GetParameters().Length;
    }

    public static Shape InstantiateWithArguments(string className, object[] args) {
      Type classType = Type.GetType(className);
      ConstructorInfo classConstructor = classType.GetConstructors().First();
      return (Shape)classConstructor.Invoke(args);
    }

    private void ShapeType_SelectionChanged(object sender, SelectionChangedEventArgs e) {
      // TODO: Enable/Disable Inputs based on the number of required arguments.
      arg1.Text = "";
      arg2.Text = "";
      arg3.Text = "";
      string className = (String)ShapeTypeComboBox.SelectedValue;
      //arg1.Text = ArgumentCountFor(className).ToString();

      if(className == "Square"){
        arg1.Visibility = Visibility.Visible;
        arg2.Visibility = Visibility.Hidden;
        arg3.Visibility = Visibility.Hidden;
      }
      else if (className == "Rectangle") {
        arg1.Visibility = Visibility.Visible;
        arg2.Visibility = Visibility.Visible;
        arg3.Visibility = Visibility.Hidden;
      } else if(className == "Trapezoid"){
        arg1.Visibility = Visibility.Visible;
        arg2.Visibility = Visibility.Visible;
        arg3.Visibility = Visibility.Visible;
      }
    }
  }
}
