using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using sharpshapes;

namespace TestSharpShapes {
  [TestClass]
  public class UnitTestRectangles {
    [TestMethod]
    public void TestRectangleConstructor() {
      Rectangle rectangle = new Rectangle(40, 50);
      Assert.AreEqual(40, rectangle.Width);
      Assert.AreEqual(50, rectangle.Height);
    }

    [TestMethod]
    [ExpectedException (typeof(ArgumentException))]
    
    public void TestRectangleConstructorSanityCheckWidth() {
      Rectangle rectangle = new Rectangle(0, 50);
    }

    [TestMethod]
    [ExpectedException (typeof(ArgumentException))]
    
    public void TestRectangleConstructorSanityCheckHeight() {
      Rectangle rectangle = new Rectangle(50,0);
    }

    [TestMethod]
    [ExpectedException (typeof(ArgumentException))]
    
    public void TestRectangleConstructorSanityChecksHieghtPositivity() {
      Rectangle rectangle = new Rectangle(50, -1);
    }

    //[TestMethod]
    //[ExpectedException(typeof (ArgumentException))]
    
    //public void MyTestMethod() {  
    //  Rectangle rectangle = new Rectangle();
    //

    [TestMethod]
    public void TestScalRectangle200Percent() {
      Rectangle rectangle = new Rectangle(10, 10);
     rectangle.Scale(200);
      Assert.AreEqual(20, rectangle.Width);
    }

    [TestMethod]
    public void TestScaleRectangle150Percent() {
     Rectangle rectangle = new Rectangle(10, 10);
     rectangle.Scale(150);
      Assert.AreEqual((decimal) 15, rectangle.Width);
    }

    [TestMethod]
    public void TestScaleRectangle100Percent() {
     Rectangle rectangle = new Rectangle(10, 10);
     rectangle.Scale(100);
     Assert.AreEqual(10, rectangle.Width); 
    }

    [TestMethod]
    public void TestScaleRectangle37Percent() {
     Rectangle rectangle = new Rectangle(10, 15);
     rectangle.Scale(37);
     Assert.AreEqual((decimal) 3.7, rectangle.Width);       
     Assert.AreEqual((decimal) 5.55, rectangle.Height);       
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void TestScaleRectangleNegativePercent() {
     Rectangle rectangle = new Rectangle(10, 15);
     rectangle.Scale(-5);       
     //Assert.AreEqual() ; 
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void TestScaleRectangleZeroPercent() {
     Rectangle rectangle = new Rectangle(10, 15);
     rectangle.Scale(0);       
     //Assert.AreEqual() ; 
    }

    [TestMethod]
      public void TestRectangleSidesCount()
      {
          Rectangle rectangle = new Rectangle(1,5);
          Assert.AreEqual(4,rectangle.SidesCount);
      }

    [TestMethod]
      public void TestRectangleArea()
      {
          Rectangle rectangle = new Rectangle(1,5);
          Assert.AreEqual(5,rectangle.Area());
      }

    [TestMethod]
      public void TestBiggerRectangleArea()
      {
          Rectangle rectangle = new Rectangle(10,100);
          Assert.AreEqual(1000,rectangle.Area());
      }

    [TestMethod]
      public void TestRectanglePerimeter()
      {
          Rectangle rectangle = new Rectangle(1,5);
          Assert.AreEqual(12,rectangle.Perimeter());
      }

    [TestMethod]
      public void TestBiggerRectanglePerimeter()
      {
          Rectangle rectangle = new Rectangle(10,100);
          Assert.AreEqual(220,rectangle.Perimeter());
      }

    [TestMethod]
    public void TestRectangleSettingFillColor() {
      Rectangle rectangle = new Rectangle(10,10);
      rectangle.FillColor = System.Drawing.Color.AliceBlue;
      Assert.AreEqual(System.Drawing.Color.AliceBlue, rectangle.FillColor);
    }

    [TestMethod]
    public void TestRectangleDefaultFillColor() {
      Rectangle rectangle = new Rectangle(10,10);
      Assert.AreEqual(System.Drawing.Color.Bisque, rectangle.FillColor);
    }
  }
}
