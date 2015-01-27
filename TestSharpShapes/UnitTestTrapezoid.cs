using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using sharpshapes;

namespace TestSharpShapes {
    
  [TestClass]
    public class UnitTestTrapezoids {
    [TestMethod]
    public void TestTrapezoidConstructor() {
      Trapezoid trapezoid = new Trapezoid(40, 50, 10);
      Assert.AreEqual(40, trapezoid.Bottom);
      Assert.AreEqual(50, trapezoid.Top);
      Assert.AreEqual(10, trapezoid.Height);
    }

    [TestMethod]
    [ExpectedException (typeof(ArgumentException))]
    
    public void TestTrapezoidConstructorSanityChecBottom() {
      Trapezoid trapezoid = new Trapezoid(0, 50, 10);
    }

    [TestMethod]
    [ExpectedException (typeof(ArgumentException))]
    
    public void TestTrapezoidConstructorSanityCheckTop() {
      Trapezoid trapezoid = new Trapezoid(50,0,10);
    }

    [TestMethod]
    [ExpectedException (typeof(ArgumentException))]
    
    public void TestTrapezoidConstructorSanityCheckHeight() {
      Trapezoid trapezoid = new Trapezoid(50,10,0);
    }

    [TestMethod]
    [ExpectedException (typeof(ArgumentException))]
    
    public void TestTrapezoidConstructorSanityChecksHieghtPositivity() {
      Trapezoid trapezoid = new Trapezoid(50,10,-1);
    }

    [TestMethod]
    [ExpectedException (typeof(ArgumentException))]
    
    public void TestTrapezoidConstructorSanityChecksBottomPositivity() {
      Trapezoid trapezoid = new Trapezoid(0,10,50);
    }

    [TestMethod]
    [ExpectedException (typeof(ArgumentException))]
    
    public void TestTrapezoidConstructorSanityChecksTopPositivity() {
      Trapezoid trapezoid = new Trapezoid(50,0,10);
    }


    [TestMethod]
    public void TestScalTrapezoid200Percent() {
      Trapezoid trapezoid = new Trapezoid(10,20,50);
     trapezoid.Scale(200);
      Assert.AreEqual(20, trapezoid.Bottom);
      Assert.AreEqual(100, trapezoid.Height);
      Assert.AreEqual(40, trapezoid.Top);
    }

    [TestMethod]
    public void TestScaleTrapezoid150Percent() {
     Trapezoid trapezoid = new Trapezoid(10,20,50);
     trapezoid.Scale(150);
      Assert.AreEqual((decimal) 30, trapezoid.Top);
      Assert.AreEqual((decimal) 15, trapezoid.Bottom);
      Assert.AreEqual((decimal) 75, trapezoid.Height);
    }

    [TestMethod]
    public void TestScaleTrapezoid100Percent() {
     Trapezoid trapezoid = new Trapezoid(10,20,50);
     trapezoid.Scale(100);
     Assert.AreEqual(10, trapezoid.Bottom); 
     Assert.AreEqual(20, trapezoid.Top); 
     Assert.AreEqual(50, trapezoid.Height); 
    }

    [TestMethod]
    public void TestScaleTrapezoid37Percent() {
     Trapezoid trapezoid = new Trapezoid(10, 15,15);
     trapezoid.Scale(37);
     Assert.AreEqual((decimal) 5.55, trapezoid.Top);       
     Assert.AreEqual((decimal) 3.7, trapezoid.Bottom);       
     Assert.AreEqual((decimal) 5.55, trapezoid.Height);       
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void TestScaleTrapezoidNegativePercent() {
     Trapezoid trapezoid = new Trapezoid(10, 15, 10);
     trapezoid.Scale(-5);       
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void TestScaleTrapezoidZeroPercent() {
     Trapezoid trapezoid = new Trapezoid(10, 15, 50);
     trapezoid.Scale(0);       
    }

    [TestMethod]
      public void TestTrapezoidSidesCount()
      {
          Trapezoid trapezoid = new Trapezoid(1,5,50);
          Assert.AreEqual(4,trapezoid.SidesCount);
      }

    [TestMethod]
      public void TestTrapezoidArea()
      {
          Trapezoid trapezoid = new Trapezoid(5,4,10);
          Assert.AreEqual(45,trapezoid.Area());
      }

    [TestMethod]
      public void TestBiggerTrapezoidArea()
      {
          Trapezoid trapezoid = new Trapezoid(10,20,100);
          Assert.AreEqual(1500,trapezoid.Area());
      }

    [TestMethod]
      public void TestTrapezoidPerimeter()
      {
          Trapezoid trapezoid = new Trapezoid(4,10,4);
          Assert.AreEqual(24,trapezoid.Perimeter());
      }

    [TestMethod]
      public void TestBiggerTrapezoidPerimeter()
      {
          Trapezoid trapezoid = new Trapezoid(40,100,40);
          Assert.AreEqual(240,trapezoid.Perimeter());
      }

    [TestMethod]
    public void TestTrapezoidSettingFillColor() {
      Trapezoid trapezoid = new Trapezoid(10,30,40);
      trapezoid.FillColor = System.Drawing.Color.AliceBlue;
      Assert.AreEqual(System.Drawing.Color.AliceBlue, trapezoid.FillColor);
    }

    [TestMethod]
    public void TestTrapezoidDefaultFillColor() {
      Trapezoid trapezoid = new Trapezoid(10,20,40);
      Assert.AreEqual(System.Drawing.Color.Bisque, trapezoid.FillColor);
    }

   [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void TestTrapezoidNoEqualSides() {
      Trapezoid trapezoid = new Trapezoid(10,10,40);
    }

   [TestMethod]
    public void TestTrapezoidConstructorCalculatesAngles1() {
      Trapezoid trapezoid = new Trapezoid(8,2,4);
      Assert.AreEqual(60, trapezoid.AcuteAngle);
      Assert.AreEqual(120, trapezoid.ObtuseAngle);
    }

   [TestMethod]
    public void TestTrapezoidConstructorCalculatesAngles2() {
      Trapezoid trapezoid = new Trapezoid(20,15,2);
      Assert.AreEqual((decimal)38.66, trapezoid.AcuteAngle);
      Assert.AreEqual((decimal)141.34, trapezoid.ObtuseAngle);
    } 
  }
}
