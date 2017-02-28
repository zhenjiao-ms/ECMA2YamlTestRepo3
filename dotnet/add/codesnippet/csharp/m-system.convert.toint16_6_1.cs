      uint[] numbers = { UInt32.MinValue, 121, 340, UInt32.MaxValue };
      short result;
      
      foreach (uint number in numbers)
      {
         try {
            result = Convert.ToInt16(number);
            Console.WriteLine("Converted the {0} value {1} to a {2} value {3}.",
                              number.GetType().Name, number,
                              result.GetType().Name, result);
         }
         catch (OverflowException) {
            Console.WriteLine("The {0} value {1} is outside the range of the Int16 type.",
                              number.GetType().Name, number);
         }
      }
      // The example displays the following output:
      //    Converted the UInt32 value 0 to a Int16 value 0.
      //    Converted the UInt32 value 121 to a Int16 value 121.
      //    Converted the UInt32 value 340 to a Int16 value 340.
      //    The UInt32 value 4294967295 is outside the range of the Int16 type.