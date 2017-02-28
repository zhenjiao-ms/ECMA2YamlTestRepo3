      Dim numbers() As UShort = { UInt16.MinValue, 121, 340, UInt16.MaxValue }
      Dim result As Byte
      For Each number As UShort In numbers
         Try
            result = Convert.ToByte(number)
            Console.WriteLIne("Converted the {0} value {1} to the {2} value {3}.", _
                              number.GetType().Name, number, _
                              result.GetType().Name, result)
         Catch e As OverflowException
            Console.WriteLine("The {0} value {1} is outside the range of the Byte type.", _
                              number.GetType().Name, number)
         End Try
      Next
      ' The example displays the following output:
      '       Converted the UInt16 value 0 to the Byte value 0.
      '       Converted the UInt16 value 121 to the Byte value 121.
      '       The UInt16 value 340 is outside the range of the Byte type.
      '       The UInt16 value 65535 is outside the range of the Byte type.