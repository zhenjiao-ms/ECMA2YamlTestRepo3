      Dim value As String
      Dim number As Decimal
      Dim style As NumberStyles
      Dim provider As CultureInfo
      
      ' Parse string using "." as the thousands separator 
      ' and " " as the decimal separator. 
      value = "892 694,12"
      style = NumberStyles.AllowDecimalPoint Or NumberStyles.AllowThousands
      provider = New CultureInfo("fr-FR")

      number = Decimal.Parse(value, style, provider)  
      Console.WriteLine("'{0}' converted to {1}.", value, number)
      ' Displays: 
      '    892 694,12' converted to 892694.12.

      Try
         number = Decimal.Parse(value, style, CultureInfo.InvariantCulture)  
         Console.WriteLine("'{0}' converted to {1}.", value, number)
      Catch e As FormatException
         Console.WriteLine("Unable to parse '{0}'.", value)
      End Try
      ' Displays: 
      '    Unable to parse '892 694,12'.  
      
      ' Parse string using "$" as the currency symbol for en-GB and
      ' en-us cultures.
      value = "$6,032.51"
      style = NumberStyles.Number Or NumberStyles.AllowCurrencySymbol
      provider = New CultureInfo("en-GB")

      Try
         number = Decimal.Parse(value, style, provider)  
         Console.WriteLine("'{0}' converted to {1}.", value, number)
      Catch e As FormatException
         Console.WriteLine("Unable to parse '{0}'.", value)
      End Try
      ' Displays: 
      '    Unable to parse '$6,032.51'.

      provider = New CultureInfo("en-US")
      number = Decimal.Parse(value, style, provider)  
      Console.WriteLine("'{0}' converted to {1}.", value, number)
      ' Displays: 
      '    '$6,032.51' converted to 6032.51.