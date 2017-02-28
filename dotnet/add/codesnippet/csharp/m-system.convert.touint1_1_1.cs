      float[] numbers = { Single.MinValue, -1.38e10f, -1023.299f, -12.98f,
                         0f, 9.113e-16f, 103.919f, 17834.191f, Single.MaxValue };
      ushort result;
      
      foreach (float number in numbers)
      {
         try {
            result = Convert.ToUInt16(number);
            Console.WriteLine("Converted the {0} value '{1}' to the {2} value {3}.", 
                              number.GetType().Name, number, 
                              result.GetType().Name, result);
         }                     
         catch (OverflowException) {
            Console.WriteLine("{0} is outside the range of the UInt16 type.", number);
         }   
      }                                 
      // The example displays the following output:
      //    -3.402823E+38 is outside the range of the UInt16 type.
      //    -1.38E+10 is outside the range of the UInt16 type.
      //    -1023.299 is outside the range of the UInt16 type.
      //    -12.98 is outside the range of the UInt16 type.
      //    Converted the Single value '0' to the UInt16 value 0.
      //    Converted the Single value '9.113E-16' to the UInt16 value 0.
      //    Converted the Single value '103.919' to the UInt16 value 104.
      //    Converted the Single value '17834.19' to the UInt16 value 17834.
      //    3.402823E+38 is outside the range of the UInt16 type.