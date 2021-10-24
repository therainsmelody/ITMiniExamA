using System;

class MainClass {
  
  
   
  
  public static void Main (string[] args)
  
   {
   
   Console.WriteLine("Enter the radius of a cylinder:");
   double r = Convert.ToDouble(Console.ReadLine());

   Console.WriteLine("Enter the height of the cylinder:");
   double height = Convert.ToDouble(Console.ReadLine());

  
   

{
  CylinderVolume();
}
  
  public static void CylinderVolume(ref double height, ref double r)
   {
     double volume=0;
 volume = 3.14 * r * r * height;

  Console.WriteLine("Volume = " + volume);
   
  }
   
  }
}