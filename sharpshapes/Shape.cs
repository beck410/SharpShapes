using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace sharpshapes
{
    abstract public class Shape
    {
      //Width, Height, Perimeter, Area, BorderColor, FillColor, NumberOfSides
      /// <summary>
      ///  specifies the interior color of the shape when drawn on screen
      /// </summary>
      public Color FillColor { get; set; }
 
      /// <summary>
      /// Specifies border color of shape when drawn on screen
      /// </summary>
      public Color BorderColor { get; set; }

      /// <summary>
      /// The number of sides of this shape
      /// </summary>
      abstract public int SidesCount { get; }  
      
      
      //return area as shape
      /// <summary>
      /// Calculates area of shape
      /// </summary>
      /// <returns>area of shape</returns>
      abstract public decimal Area();

      //return area as perimeter
      /// <summary>
      /// Calculates perimeter of shape
      /// </summary>
      /// <returns>returns perimeter of shape</returns>
      abstract public int Perimeter();

      //resize shape by %
      /// <summary>
      ///Scales size of shape 
      /// </summary>
      /// <param name="percent">the percentage to scale the shape by</param>
      abstract public void scale(int percent);
    } 
}
