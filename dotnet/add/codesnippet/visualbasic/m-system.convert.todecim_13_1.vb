      Dim numbers() As Integer = { Int32.MinValue, -1000, 0, 1000, Int32.MaxValue }
      Dim result As Decimal
      
      For Each number As Integer In numbers
         result = Convert.ToDecimal(number)
         Console.WriteLine("Converted the Int32 value {0} to the Decimal value {1}.", _
                           number, result)
      Next
      ' The example displays the following output:
      '    Converted the Int32 value -2147483648 to the Decimal value -2147483648.
      '    Converted the Int32 value -1000 to the Decimal value -1000.
      '    Converted the Int32 value 0 to the Decimal value 0.
      '    Converted the Int32 value 1000 to the Decimal value 1000.
      '    Converted the Int32 value 2147483647 to the Decimal value 2147483647.      