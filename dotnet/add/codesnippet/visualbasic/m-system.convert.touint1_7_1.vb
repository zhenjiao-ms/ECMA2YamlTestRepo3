      Dim bytes() As Byte = { Byte.MinValue, 14, 122, Byte.MaxValue}
      Dim result As UShort
      
      For Each number As Byte In bytes
         result = Convert.ToUInt16(number)
         Console.WriteLine("Converted the {0} value '{1}' to the {2} value {3}.", _
                           number.GetType().Name, number, _
                           result.GetType().Name, result)
      Next
      ' The example displays the following output:
      '    Converted the Byte value '0' to the UInt16 value 0.
      '    Converted the Byte value '14' to the UInt16 value 14.
      '    Converted the Byte value '122' to the UInt16 value 122.
      '    Converted the Byte value '255' to the UInt16 value 255.