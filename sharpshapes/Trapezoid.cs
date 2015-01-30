using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace sharpshapes {
  public class Trapezoid : Quadrilateral {
    
    public Trapezoid(int bottom, int top, int height) {
      if (bottom <= 0 || top <= 0 || height <= 0 || bottom <= top)
        throw new ArgumentException();

      this.height = height;
      this.top = top;
      this.bottom = bottom;

      this.AcuteAngle = Decimal.Round((decimal)(Math.Atan((double)(height / WingLength())) * (180.0 / Math.PI)), 2);
      this.ObtuseAngle = 180 - this.AcuteAngle;
    }

    private decimal WingLength() {
      decimal wingLength = (this.bottom - this.top) / 2;
      return wingLength;
    }

    public decimal AcuteAngle { get; set; }

    public decimal ObtuseAngle { get; set; }

    private decimal top;
      public decimal Top {
      get { return this.top; } 
    }

    private decimal bottom;
    public decimal Bottom {
      get { return this.bottom; } 
    }

    private decimal height;
    public decimal Height {
      get { return this.height; }
    }
  
    public override void Scale(int percent) {

      if (percent <= 0)
        throw new ArgumentException();

      this.top = top * percent / 100;
      this.bottom = bottom * percent / 100;
      this.height = height * percent / 100;
    }


 
    public override decimal Area() {
      return (height/2) * (top + bottom);
    }
    
    public override decimal Perimeter() {
      decimal smallSides = Math.Abs(top - bottom) / 2;
      double unknownSide = Math.Sqrt(Math.Pow((double)smallSides, (double)2) + Math.Pow((double)height, (double)2));
      return ((int)unknownSide * 2) + top + bottom; 
    }

    public override void DrawOnToCanvas(System.Windows.Controls.Canvas ShapeCanvas, int x, int y) {
      Polygon trapezoid = new Polygon();
      
      //broder color
      System.Drawing.Color drawingBorderColor = this.BorderColor;
      System.Windows.Media.Color strokeColor = System.Windows.Media.Color.FromArgb(drawingBorderColor.A, drawingBorderColor.R, drawingBorderColor.G, drawingBorderColor.B);
      SolidColorBrush strokeBrush = new SolidColorBrush(strokeColor);
      trapezoid.Stroke = strokeBrush;
      
      //fill color
      System.Drawing.Color drawingFillColor = this.FillColor;
      System.Windows.Media.Color fillColor = System.Windows.Media.Color.FromArgb(drawingFillColor.A, drawingFillColor.R, drawingFillColor.G, drawingFillColor.B);
      SolidColorBrush fillBrush = new SolidColorBrush(fillColor);
      trapezoid.Fill = fillBrush;
      
      int trapezoidHeight = (int)this.Height;
      int trapezoidTop = (int)this.Top;
      int trapezoidBottom = (int)this.Bottom;
      int Wing = (int)this.WingLength();

      System.Windows.Point Point1 = new System.Windows.Point(x,y);
      System.Windows.Point Point2 = new System.Windows.Point(x-trapezoidTop,y);
      System.Windows.Point Point3 = new System.Windows.Point(x - trapezoidTop - Wing,y+trapezoidHeight);
      System.Windows.Point Point4 = new System.Windows.Point(x+Wing,y+trapezoidHeight);

      PointCollection myPointCollection = new PointCollection();
      myPointCollection.Add(Point1);
      myPointCollection.Add(Point2);
      myPointCollection.Add(Point3);
      myPointCollection.Add(Point4);
      trapezoid.Points = myPointCollection;
      ShapeCanvas.Children.Add(trapezoid);
    }
  }
}
