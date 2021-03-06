      ' Define cultures whose formatting conventions are to be used.
      Dim cultures() As CultureInfo = {CultureInfo.CreateSpecificCulture("en-US"), _
                                       CultureInfo.CreateSpecificCulture("fr-FR"), _
                                       CultureInfo.CreateSpecificCulture("es-ES") }
      Dim positiveNumber As Long = 1679
      Dim negativeNumber As Long = -3045
      Dim specifiers() As String = {"G", "C", "D8", "E2", "F", "N", "P", "X8"} 
      
      For Each specifier As String In specifiers
         For Each culture As CultureInfo In Cultures
            ' Display values with "G" format specifier.
            Console.WriteLine("{0} format using {1} culture: {2, 16} {3, 16}", _ 
                              specifier, culture.Name, _
                              positiveNumber.ToString(specifier, culture), _
                              negativeNumber.ToString(specifier, culture))

         Next
         Console.WriteLine()
      Next
      ' The example displays the following output to the console:
      '    G format using en-US culture:             1679            -3045
      '    G format using fr-FR culture:             1679            -3045
      '    G format using es-ES culture:             1679            -3045
      '    
      '    C format using en-US culture:        $1,679.00      ($3,045.00)
      '    C format using fr-FR culture:       1�679,00 ?      -3�045,00 ?
      '    C format using es-ES culture:       1.679,00 ?      -3.045,00 ?
      '    
      '    D8 format using en-US culture:         00001679        -00003045
      '    D8 format using fr-FR culture:         00001679        -00003045
      '    D8 format using es-ES culture:         00001679        -00003045
      '    
      '    E2 format using en-US culture:        1.68E+003       -3.05E+003
      '    E2 format using fr-FR culture:        1,68E+003       -3,05E+003
      '    E2 format using es-ES culture:        1,68E+003       -3,05E+003
      '    
      '    F format using en-US culture:          1679.00         -3045.00
      '    F format using fr-FR culture:          1679,00         -3045,00
      '    F format using es-ES culture:          1679,00         -3045,00
      '    
      '    N format using en-US culture:         1,679.00        -3,045.00
      '    N format using fr-FR culture:         1�679,00        -3�045,00
      '    N format using es-ES culture:         1.679,00        -3.045,00
      '    
      '    P format using en-US culture:     167,900.00 %    -304,500.00 %
      '    P format using fr-FR culture:     167�900,00 %    -304�500,00 %
      '    P format using es-ES culture:     167.900,00 %    -304.500,00 %
      '    
      '    X8 format using en-US culture:         0000068F         FFFFF41B
      '    X8 format using fr-FR culture:         0000068F         FFFFF41B
      '    X8 format using es-ES culture:         0000068F         FFFFF41B