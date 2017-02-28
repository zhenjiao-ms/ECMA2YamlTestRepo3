      Dim chars() As Char = { "a"c, "z"c, ChrW(7), ChrW(1023), _
                              ChrW(Short.MaxValue), ChrW(&hFFFE) }
      Dim result As UInteger
                              
      For Each ch As Char in chars
         result = Convert.ToUInt32(ch)
         Console.WriteLine("Converted the {0} value '{1}' to the {2} value {3}.", _
                           ch.GetType().Name, ch, _
                           result.GetType().Name, result)
      Next   
      ' The example displays the following output:
      '    Converted the Char value 'a' to the UInt32 value 97.
      '    Converted the Char value 'z' to the UInt32 value 122.
      '    Converted the Char value '' to the UInt32 value 7.
      '    Converted the Char value '?' to the UInt32 value 1023.
      '    Converted the Char value '?' to the UInt32 value 32767.
      '    Converted the Char value '?' to the UInt32 value 65534.