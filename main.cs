using System;
using System.Linq;

class MainClass {
  public static void Main (string[] args) {
    
    double[] celsius = new double[7];
    double[] farhrenheit = new double [7];
    for(int pos=0; pos < celsius.Length; pos++)
    {
      Console.WriteLine ("Enter temperature in Celsius");
      celsius[pos]=Convert.ToDouble(Console.ReadLine());
    }

    Console.WriteLine ("Temperatures in Fahrenheit");
    for(int pos=0; pos < celsius.Length; pos++)
    {
      farhrenheit[pos] = celsius[pos]*9/5 +32;
    }

    Array.Reverse(farhrenheit);
    foreach (double item in farhrenheit)
    {
      Console.WriteLine(item);
    }

    Console.WriteLine ("Average weekly temperature is " + farhrenheit.Sum()/7+ " degrees fahrenheit");
  }
}