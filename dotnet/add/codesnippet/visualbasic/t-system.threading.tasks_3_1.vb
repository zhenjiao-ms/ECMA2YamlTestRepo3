Imports System.Threading.Tasks

Module Example
   Public Sub Main()
      Dim t As Task = Task.Run(Sub()
                                  ' Just loop.
                                  Dim ctr As Integer = 0
                                  For ctr = 0 to 1000000
                                  Next
                                  Console.WriteLine("Finished {0} loop iterations",
                                                    ctr)
                               End Sub)
      t.Wait()
   End Sub
End Module
' The example displays the following output:
'       Finished 1000001 loop iterations