namespace CubeCheck {
  using System;
  public class CubeChecker
  {
    public bool IsCube(double volume, double side)
    {
      return side > 0? Math.Pow(side, 3) == volume: false; 
    }
  }
}