        Dim tuple4 = New Tuple(Of String, Double, Double, Double) _
                              ("New York", 32.68, 51.87, 76.3)
        Console.WriteLine("{0}: Hi {1}, Lo {2}, Ave {3}",
                          tuple4.Item1, tuple4.Item4, tuple4.Item2,
                          tuple4.Item3)
        ' Displays New York: Hi 76.3, Lo 32.68, Ave 51.87