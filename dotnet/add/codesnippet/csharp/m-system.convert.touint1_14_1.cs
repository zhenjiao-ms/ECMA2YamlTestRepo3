      ulong[] numbers = { UInt64.MinValue, 121, 340, UInt64.MaxValue };
      ushort result;
      
      foreach (ulong number in numbers)
      {
         try {
            result = Convert.ToUInt16(number);
            Console.WriteLine("Converted the {0} value '{1}' to the {2} value {3}.", 
                              number.GetType().Name, number, 
                              result.GetType().Name, result);
         }
         catch (OverflowException) {
            Console.WriteLine("The {0} value {1} is outside the range of the UInt16 type.",
                              number.GetType().Name, number);
         }
      }
      // The example displays the following output:
      //    Converted the UInt64 value '0' to the UInt16 value 0.
      //    Converted the UInt64 value '121' to the UInt16 value 121.
      //    Converted the UInt64 value '340' to the UInt16 value 340.
      //    The UInt64 value 18446744073709551615 is outside the range of the UInt16 type.