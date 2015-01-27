using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using sharpshapes;

namespace TestSharpShapes {
  
  [TestClass]
  public class UnitTestSquare {
    [TestMethod]
    public void TestSquareConstructor() {
      Square square = new Square(40);
      Assert.AreEqual(40, square.Width);
      Assert.AreEqual(40, square.Height);
    }

    [TestMethod]
    [ExpectedException (typeof(ArgumentException))]
    
    public void TestSquareConstructorSanity() {
      Square square = new Square(0);
    }

    [TestMethod]
    [ExpectedException (typeof(ArgumentException))]
    
    public void TestSquareConstructorSanityChecksHieghtPositivity() {
      Square square = new Square(-1);
    }

    [TestMethod]
    public void TestScaleSquare200Percent() {
      Square square = new Square(10);
     square.Scale(200);
      Assert.AreEqual(20, square.Width);
      Assert.AreEqual(20, square.Height);
    }

    [TestMethod]
    public void TestScaleSquare150Percent() {
     Square square = new Square(10);
     square.Scale(150);
      Assert.AreEqual((decimal) 15, square.Width);
      Assert.AreEqual((decimal) 15, square.Height);
    }

    [TestMethod]
    public void TestScaleSquare100Percent() {
     Square square = new Square(10);
     square.Scale(100);
     Assert.AreEqual(10, square.Width); 
     Assert.AreEqual(10, square.Height); 
    }

    [TestMethod]
    public void TestScaleSquare37Percent() {
     Square square = new Square(10);
     square.Scale(37);
     Assert.AreEqual((decimal) 3.7, square.Width);       
     Assert.AreEqual((decimal) 3.7, square.Height);       
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void TestScaleSquareNegativePercent() {
     Square square = new Square(10);
     square.Scale(-5);       
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void TestScaleSquareZeroPercent() {
     Square square = new Square(10);
     square.Scale(0);       
    }

    [TestMethod]
      public void TestSquareSidesCount()
      {
          Square square = new Square(2);
          Assert.AreEqual(4,square.SidesCount);
      }

    [TestMethod]
      public void TestSquareArea()
      {
          Square square = new Square(5);
          Assert.AreEqual(25,square.Area());
      }

    [TestMethod]
      public void TestBiggerSquareArea()
      {
          Square square = new Square(50);
          Assert.AreEqual(2500,square.Area());
      }

    [TestMethod]
      public void TestSquarePerimeter()
      {
          Square square = new Square(5);
          Assert.AreEqual(20,square.Perimeter());
      }

    [TestMethod]
      public void TestBiggerSquarePerimeter()
      {
          Square square = new Square(100);
          Assert.AreEqual(400,square.Perimeter());
      }

    [TestMethod]
    public void TestSquareSettingFillColor() {
      Square square = new Square(10);
      square.FillColor = System.Drawing.Color.AliceBlue;
      Assert.AreEqual(System.Drawing.Color.AliceBlue, square.FillColor);
    }

    [TestMethod]
    public void TestSquareDefaultFillColor() {
      Square square = new Square(10);
      Assert.AreEqual(System.Drawing.Color.Bisque, square.FillColor);
    }
  }
}
