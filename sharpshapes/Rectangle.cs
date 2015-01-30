using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Shapes;
using System.Windows.Media;
using System.Windows.Controls;

namespace sharpshapes {
  public class Rectangle : Quadrilateral {

    private decimal width;
    public decimal Width {
      get { return this.width; } 
    }

    private decimal height;
    public decimal Height {
      get { return this.height; } 
    }

    public Rectangle(int width, int height) {

      if(width <= 0 || height <=0)
        throw new ArgumentException();

      this.width = width;
      this.height = height;
    }
  
    public override void Scale(int percent) {

      if (percent <= 0)
        throw new ArgumentException();

      this.width = width * percent / 100;
      this.height = height * percent / 100;
    }
 
    public override decimal Area() {
      return Height * Width;
    }
    
    public override decimal Perimeter() {
      return (2 * Height) + (2 * Width);
    }

    public override void DrawOnToCanvas(System.Windows.Controls.Canvas ShapeCanvas, int x, int y) {
       Polygon rectangle = new Polygon();
      
      //broder color
      System.Drawing.Color drawingBorderColor = this.BorderColor;
      System.Windows.Media.Color strokeColor = System.Windows.Media.Color.FromArgb(drawingBorderColor.A, drawingBorderColor.R, drawingBorderColor.G, drawingBorderColor.B);
      SolidColorBrush strokeBrush = new SolidColorBrush(strokeColor);
      rectangle.Stroke = strokeBrush;
      
      //fill color
      System.Drawing.Color drawingFillColor = this.FillColor;
      System.Windows.Media.Color fillColor = System.Windows.Media.Color.FromArgb(drawingFillColor.A, drawingFillColor.R, drawingFillColor.G, drawingFillColor.B);
      SolidColorBrush fillBrush = new SolidColorBrush(fillColor);
      rectangle.Fill = fillBrush;

      int rectangleWidth = (int)this.Width;
      int rectangleHeight = (int)this.Height;

      System.Windows.Point Point1 = new System.Windows.Point(x, y);
      System.Windows.Point Point2 = new System.Windows.Point(x + rectangleWidth, y);
      System.Windows.Point Point3 = new System.Windows.Point(x + rectangleWidth, y + rectangleHeight);
      System.Windows.Point Point4 = new System.Windows.Point(x, y + rectangleHeight);

      PointCollection myPointCollection = new PointCollection();
      myPointCollection.Add(Point1);
      myPointCollection.Add(Point2);
      myPointCollection.Add(Point3);
      myPointCollection.Add(Point4);
      rectangle.Points = myPointCollection;
      ShapeCanvas.Children.Add(rectangle);
    }
  }
}
