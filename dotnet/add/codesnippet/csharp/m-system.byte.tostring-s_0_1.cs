      string[] formats = {"C3", "D4", "e1", "E2", "F1", "G", "N1", 
                          "P0", "X4", "0000.0000"};
      byte number = 240;
      foreach (string format in formats)
         Console.WriteLine("'{0}' format specifier: {1}", 
                           format, number.ToString(format));

      // The example displays the following output to the console if the
      // current culture is en-us:
      //       'C3' format specifier: $240.000
      //       'D4' format specifier: 0240
      //       'e1' format specifier: 2.4e+002
      //       'E2' format specifier: 2.40E+002
      //       'F1' format specifier: 240.0
      //       'G' format specifier: 240
      //       'N1' format specifier: 240.0
      //       'P0' format specifier: 24,000 %
      //       'X4' format specifier: 00F0
      //       '0000.0000' format specifier: 0240.0000           