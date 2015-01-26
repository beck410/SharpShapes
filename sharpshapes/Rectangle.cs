using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sharpshapes {
  public class Rectangle {

    private int width;
    public object Width {
      get { return this.width; } 
    }

    private int height;
    public object Height {
      get { return this.height; } 
    }

    public Rectangle(int width, int height) {

      if(width <= 0 || height <=0)
        throw new ArgumentException();

      this.width = width;
      this.height = height;
    }



  }
}
