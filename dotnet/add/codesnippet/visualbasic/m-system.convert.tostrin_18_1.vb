      Dim bases() As Integer = { 2, 8, 10, 16}
      Dim numbers() As Long = { Int64.MinValue, -193275430, -13621, -18, 12, _
                                   1914206117, Int64.MaxValue }

      For Each base As Integer In bases
         Console.WriteLine("Base {0} conversion:", base)
         For Each number As Long In numbers
            Console.WriteLine("   {0,-23}  -->  0x{1}", _
                              number, Convert.ToString(number, base))
         Next
      Next
      ' The example displays the following output:
      '    Base 2 conversion:
      '       -9223372036854775808     -->  0x1000000000000000000000000000000000000000000000000000000000000000
      '       -193275430               -->  0x1111111111111111111111111111111111110100011110101101100111011010
      '       -13621                   -->  0x1111111111111111111111111111111111111111111111111100101011001011
      '       -18                      -->  0x1111111111111111111111111111111111111111111111111111111111101110
      '       12                       -->  0x1100
      '       1914206117               -->  0x1110010000110000111011110100101
      '       9223372036854775807      -->  0x111111111111111111111111111111111111111111111111111111111111111
      '    Base 8 conversion:
      '       -9223372036854775808     -->  0x1000000000000000000000
      '       -193275430               -->  0x1777777777776436554732
      '       -13621                   -->  0x1777777777777777745313
      '       -18                      -->  0x1777777777777777777756
      '       12                       -->  0x14
      '       1914206117               -->  0x16206073645
      '       9223372036854775807      -->  0x777777777777777777777
      '    Base 10 conversion:
      '       -9223372036854775808     -->  0x-9223372036854775808
      '       -193275430               -->  0x-193275430
      '       -13621                   -->  0x-13621
      '       -18                      -->  0x-18
      '       12                       -->  0x12
      '       1914206117               -->  0x1914206117
      '       9223372036854775807      -->  0x9223372036854775807
      '    Base 16 conversion:
      '       -9223372036854775808     -->  0x8000000000000000
      '       -193275430               -->  0xfffffffff47ad9da
      '       -13621                   -->  0xffffffffffffcacb
      '       -18                      -->  0xffffffffffffffee
      '       12                       -->  0xc
      '       1914206117               -->  0x721877a5
      '       9223372036854775807      -->  0x7fffffffffffffff