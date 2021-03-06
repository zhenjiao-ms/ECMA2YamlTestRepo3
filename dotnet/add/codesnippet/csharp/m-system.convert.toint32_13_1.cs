      string[] values = { "One", "1.34e28", "-26.87", "-18", "-6.00",
                          " 0", "137", "1601.9", Int32.MaxValue.ToString() };
      int result;
      
      foreach (string value in values)
      {
         try {
            result = Convert.ToInt32(value);
            Console.WriteLine("Converted the {0} value '{1}' to the {2} value {3}.",
                              value.GetType().Name, value, result.GetType().Name, result);
         }
         catch (OverflowException) {
            Console.WriteLine("{0} is outside the range of the Int32 type.", value);
         }   
         catch (FormatException) {
            Console.WriteLine("The {0} value '{1}' is not in a recognizable format.",
                              value.GetType().Name, value);
         }   
      }                                 
      // The example displays the following output:
      //    The String value 'One' is not in a recognizable format.
      //    The String value '1.34e28' is not in a recognizable format.
      //    The String value '-26.87' is not in a recognizable format.
      //    Converted the String value '-18' to the Int32 value -18.
      //    The String value '-6.00' is not in a recognizable format.
      //    Converted the String value ' 0' to the Int32 value 0.
      //    Converted the String value '137' to the Int32 value 137.
      //    The String value '1601.9' is not in a recognizable format.
      //    Converted the String value '2147483647' to the Int32 value 2147483647.