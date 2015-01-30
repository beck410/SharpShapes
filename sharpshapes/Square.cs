using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Shapes;
using System.Windows.Media;
using System.Windows.Controls;

namespace sharpshapes {
  public class Square : Rectangle {

    public Square(int edgeLength) : base(edgeLength, edgeLength){}

    public override void DrawOnToCanvas(Canvas ShapeCanvas, int x, int y) {

      Polygon square = new Polygon();
      
      //broder color
      System.Drawing.Color drawingBorderColor = this.BorderColor;
      System.Windows.Media.Color strokeColor = System.Windows.Media.Color.FromArgb(drawingBorderColor.A, drawingBorderColor.R, drawingBorderColor.G, drawingBorderColor.B);
      SolidColorBrush strokeBrush = new SolidColorBrush(strokeColor);
      square.Stroke = strokeBrush;

      //fill color
      System.Drawing.Color drawingFillColor = this.FillColor;
      System.Windows.Media.Color fillColor = System.Windows.Media.Color.FromArgb(drawingFillColor.A, drawingFillColor.R, drawingFillColor.G, drawingFillColor.B);
      SolidColorBrush fillBrush = new SolidColorBrush(fillColor);
      square.Fill = fillBrush;

      int squareWidth = (int)this.Width;
      int squareHeight = (int)this.Height;

      System.Windows.Point Point1 = new System.Windows.Point(x, y);
      System.Windows.Point Point2 = new System.Windows.Point(x + squareWidth, y);
      System.Windows.Point Point3 = new System.Windows.Point(x + squareWidth, y + squareHeight);
      System.Windows.Point Point4 = new System.Windows.Point(x, y + squareHeight);

      PointCollection myPointCollection = new PointCollection();
      myPointCollection.Add(Point1);
      myPointCollection.Add(Point2);
      myPointCollection.Add(Point3);
      myPointCollection.Add(Point4);
      square.Points = myPointCollection;
      ShapeCanvas.Children.Add(square);
    }
 }
}
