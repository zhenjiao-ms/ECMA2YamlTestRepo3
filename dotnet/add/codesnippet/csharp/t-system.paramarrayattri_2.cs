public class Class1
{
   public static void Main()
   {
      Temperature temp1 = new Temperature(100);
      string[] formats = { "C", "G", "F", "K" }; 

      // Call Display method with a string array.
      Console.WriteLine("Calling Display with a string array:");
      temp1.Display(formats);
      Console.WriteLine();
      
      // Call Display method with individual string arguments.
      Console.WriteLine("Calling Display with individual arguments:");
      temp1.Display("C", "F", "K", "G");
      Console.WriteLine();
      
      // Call parameterless Display method.
      Console.WriteLine("Calling Display with an implicit parameter array:");
      temp1.Display();
   }
}
// The example displays the following output:
//       Calling Display with a string array:
//       100.00  °C
//       100.00  °C
//       212.00  °F
//       373.15  °K
//       
//       Calling Display with individual arguments:
//       100.00  °C
//       212.00  °F
//       373.15  °K
//       100.00  °C
//       
//       Calling Display with an implicit parameter array:
//       100.00  °C