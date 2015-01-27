using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
  }
}
