using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using sharpshapes;
using System.Drawing;

namespace TestSharpShapes {

  public class MyShape : Shape { 
    
  }

  [TestClass]
  public class UnitTestShape {
    [TestMethod]
    public void TestSettingBorderColor() {
      Shape shape = new MyShape();
      shape.BorderColor = Color.AliceBlue;
      Assert.AreEqual(Color.AliceBlue, shape.BorderColor);
    }
  }
}
