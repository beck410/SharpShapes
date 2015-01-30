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
      throw new NotImplementedException();
    }
  }
}
