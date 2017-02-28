      uint[] numbers = { UInt32.MinValue, 40, 160, 255, 1028,
                         2011, 30001, 207154, Int32.MaxValue };
      char result;
      foreach (uint number in numbers)
      {
         try {
            result = Convert.ToChar(number);
            Console.WriteLine("{0} converts to '{1}'.", number, result);
         }   
         catch (OverflowException) {
            Console.WriteLine("{0} is outside the range of the Char data type.",
                              number);
         }
      }   
      // The example displays the following output:
      //       0 converts to ' '.
      //       40 converts to '('.
      //       160 converts to ' '.
      //       255 converts to 'ÿ'.
      //       1028 converts to '?'.
      //       2011 converts to '?'.
      //       30001 converts to '?'.
      //       207154 is outside the range of the Char data type.
      //       2147483647 is outside the range of the Char data type.