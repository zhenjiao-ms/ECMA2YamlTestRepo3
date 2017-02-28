using System;

public class Example
{
   public static void Main()
   {
      Double number = 1764.3789;
      
      // Format as a currency value.
      Console.WriteLine(number.ToString("C"));
      
      // Format as a numeric value with 3 decimal places.
      Console.WriteLine(number.ToString("N3"));
   }
}
// The example displays the following output:
//       $1,764.38
//       1,764.379