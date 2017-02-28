      ' Create a hexadecimal value out of range of the SByte type.
      Dim value As String = Convert.ToString(Byte.MaxValue, 16)
      ' Convert it back to a number.
      Try
         Dim number As SByte = Convert.ToSByte(value, 16)
         Console.WriteLine("0x{0} converts to {1}.", value, number)
      Catch e As OverflowException
         Console.WriteLine("Unable to convert '0x{0}' to a signed byte.", value)
      End Try   