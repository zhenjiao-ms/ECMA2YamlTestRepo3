      Dim numbers() As Long = { Int64.MinValue, -903, 0, 172, Int64.MaxValue}
      Dim result As Single
      
      For Each number As Long In numbers
         result = Convert.ToSingle(number)
         Console.WriteLine("Converted the {0} value '{1}' to the {2} value {3}.", _
                           number.GetType().Name, number, _
                           result.GetType().Name, result)

      Next
      ' The example displays the following output:
      '    Converted the Int64 value '-9223372036854775808' to the Single value -9.223372E+18.
      '    Converted the Int64 value '-903' to the Single value -903.
      '    Converted the Int64 value '0' to the Single value 0.
      '    Converted the Int64 value '172' to the Single value 172.
      '    Converted the Int64 value '9223372036854775807' to the Single value 9.223372E+18.