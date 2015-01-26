using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sharpshapes {
  public class Square : Rectangle{

    public Square(int size) : base(size, size)
    {
  
    }
  
  //  private  decimal width;
  //  public decimal Width {
  //    get { return this.width; } 
  //  }

  //  private  decimal height;
  //  public decimal Height {
  //    get { return this.height; } 
  //  }
    
  //  public Square(int size) {
  //    if (size <= 0)
  //      throw new ArgumentException();

  //    this.width = size;
  //    this.height = size;
  //  }

  //  public override void Scale(int percent) {
  //    if (percent <= 0)
  //      throw new ArgumentException();

  //    this.width = width * percent / 100;
  //    this.height = height * percent / 100;
  //  }

  //  public override int SidesCount {
  //    get { return 4; }
  //  }

  //  public override decimal Area() {
  //    return Width * Height;
  //  }

  //  public override decimal Perimeter() {
  //    return (2 * Width) + (2 * Height);
  //  }
 }
}
