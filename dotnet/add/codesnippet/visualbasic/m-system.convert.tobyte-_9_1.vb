      ' Create a hexadecimal value out of range of the Byte type.
      Dim value As String = SByte.MinValue.ToString("X")
      ' Convert it back to a number.
      Try
         Dim number As Byte = Convert.ToByte(value, 16)
         Console.WriteLine("0x{0} converts to {1}.", value, number)
      Catch e As OverflowException
         Console.WriteLine("Unable to convert '0x{0}' to a byte.", value)
      End Try   