using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sharpshapes {
  public abstract class Quadrilateral : Shape {

    public Quadrilateral() {

    } 

    public override int SidesCount {
      get { return 4; }
    }

  }
}
