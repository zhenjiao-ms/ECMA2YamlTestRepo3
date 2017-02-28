      object[] values = { true, -12, 163, 935, 'x', "104", "103.0", "-1",
                          "1.00e2", "One", 1.00e2};
      sbyte result;
      
      foreach (object value in values)
      {
         try {
            result = Convert.ToSByte(value);
            Console.WriteLine("Converted the {0} value {1} to the {2} value {3}.",
                              value.GetType().Name, value,
                              result.GetType().Name, result);
         }                     
         catch (OverflowException) {
            Console.WriteLine("The {0} value {1} is outside the range of the SByte type.",
                              value.GetType().Name, value);
         }
         catch (FormatException) {
            Console.WriteLine("The {0} value {1} is not in a recognizable format.",
                              value.GetType().Name, value);
         }
         catch (InvalidCastException) {
            Console.WriteLine("No conversion to a Byte exists for the {0} value {1}.",
                              value.GetType().Name, value);
                              
         }
      }                           
      // The example displays the following output:
      //    Converted the Boolean value true to the SByte value 1.
      //    Converted the Int32 value -12 to the SByte value -12.
      //    The Int32 value 163 is outside the range of the SByte type.
      //    The Int32 value 935 is outside the range of the SByte type.
      //    Converted the Char value x to the SByte value 120.
      //    Converted the String value 104 to the SByte value 104.
      //    The String value 103.0 is not in a recognizable format.
      //    Converted the String value -1 to the SByte value -1.
      //    The String value 1.00e2 is not in a recognizable format.
      //    The String value One is not in a recognizable format.
      //    Converted the Double value 100 to the SByte value 100.