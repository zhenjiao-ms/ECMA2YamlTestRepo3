Imports System.Globalization

Module Example
   Public Sub Main()
      Dim ci As CompareInfo = CultureInfo.CurrentCulture.CompareInfo
      
      Dim softHyphen As Char = ChrW(&h00AD)
      
      Dim s1 As String = "ani" + softHyphen + "mal"
      Dim s2 As String = "animal"
      
      ' Find the index of the soft hyphen.
      Console.WriteLine(ci.IndexOf(s1, softHyphen))
      Console.WriteLine(ci.IndexOf(s2, softHyphen))
   End Sub
End Module
' The example displays the following output:
'       0
'       0