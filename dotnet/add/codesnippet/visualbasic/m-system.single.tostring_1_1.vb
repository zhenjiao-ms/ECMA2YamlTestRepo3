      Dim value As Single = 16325.62901
      Dim specifier As String
      Dim culture As CultureInfo

      ' Use standard numeric format specifiers.
      specifier = "G"
      culture = CultureInfo.CreateSpecificCulture("eu-ES")
      Console.WriteLine(value.ToString(specifier, culture))
      ' Displays:    16325,62901
      Console.WriteLine(value.ToString(specifier, CultureInfo.InvariantCulture))
      ' Displays:    16325.62901
      
      specifier = "C"
      culture = CultureInfo.CreateSpecificCulture("en-US")
      Console.WriteLine(value.ToString(specifier, culture))
      ' Displays:    $16,325.63
      culture = CultureInfo.CreateSpecificCulture("en-GB")
      Console.WriteLine(value.ToString(specifier, culture))
      ' Displays:    �16,325.63
      
      specifier = "E04"
      culture = CultureInfo.CreateSpecificCulture("sv-SE")
      Console.WriteLine(value.ToString(specifier, culture))
      ' Displays: 1,6326E+004   
       culture = CultureInfo.CreateSpecificCulture("en-NZ")
       Console.WriteLine(value.ToString(specifier, culture))
      ' Displays:    1.6326E+004   
      
      specifier = "F"
      culture = CultureInfo.CreateSpecificCulture("fr-FR")
      Console.WriteLine(value.ToString(specifier, culture))
      ' Displays:    16325,63
      culture = CultureInfo.CreateSpecificCulture("en-CA")
      Console.WriteLine(value.ToString(specifier, culture))
      ' Displays:    16325.63
      
      specifier = "N"
      culture = CultureInfo.CreateSpecificCulture("es-ES")
      Console.WriteLine(value.ToString(specifier, culture))
      ' Displays:    16.325,63
      culture = CultureInfo.CreateSpecificCulture("fr-CA")
      Console.WriteLine(value.ToString(specifier, culture))
      ' Displays:    16 325,63
      
      specifier = "P"
      culture = CultureInfo.InvariantCulture
      Console.WriteLine((value/10000).ToString(specifier, culture))
      ' Displays:    163.26 %
      culture = CultureInfo.CreateSpecificCulture("ar-EG")
      Console.WriteLine((value/10000).ToString(specifier, culture))
      ' Displays:    163.256 %