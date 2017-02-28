      Dim value As String
      Dim number As Decimal
      
      ' Parse an integer with thousands separators. 
      value = "16,523,421"
      number = Decimal.Parse(value)
      Console.WriteLine("'{0}' converted to {1}.", value, number)
      ' Displays: 
      '    16,523,421' converted to 16523421.
      
      ' Parse a floating point value with thousands separators
      value = "25,162.1378"
      number = Decimal.Parse(value)
      Console.WriteLine("'{0}' converted to {1}.", value, number)
      ' Displays:
      '    25,162.1378' converted to 25162.1378.
      
      ' Parse a floating point number with US currency symbol.
      value = "$16,321,421.75"
      Try
         number = Decimal.Parse(value)
         Console.WriteLine("'{0}' converted to {1}.", value, number)
      Catch e As FormatException
         Console.WriteLine("Unable to parse '{0}'.", value)
      End Try
      ' Displays:
      '    Unable to parse '$16,321,421.75'.  
      
      ' Parse a number in exponential notation
      value = "1.62345e-02"
      Try
         number = Decimal.Parse(value)
         Console.WriteLine("'{0}' converted to {1}.", value, number)
      Catch e As FormatException
         Console.WriteLine("Unable to parse '{0}'.", value)
      End Try
      ' Displays: 
      '    Unable to parse '1.62345e-02'. 