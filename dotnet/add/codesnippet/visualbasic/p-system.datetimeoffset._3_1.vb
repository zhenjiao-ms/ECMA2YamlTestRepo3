      Dim dto As DateTimeOffset

      ' Current time
      dto = DateTimeOffset.Now
      Console.WriteLine(dto.LocalDateTime)
      ' UTC time
      dto = DateTimeOffset.UtcNow
      Console.WriteLine(dto.LocalDateTime)

     ' Transition to DST in local time zone occurs on 3/11/2007 at 2:00 AM
      dto = New DateTimeOffset(#03/11/2007 3:30AM#, New Timespan(-7, 0, 0))      
      Console.WriteLine(dto.LocalDateTime)
      dto = New DateTimeOffset(#03/11/2007 2:30AM#, New Timespan(-7, 0, 0))
      Console.WriteLine(dto.LocalDateTime)
      ' Invalid time in local time zone
      dto = New DateTimeOffset(#03/11/2007 2:30AM#, New Timespan(-8, 0, 0))
      Console.WriteLine(TimeZoneInfo.Local.IsInvalidTime(dto.DateTime))
      Console.WriteLine(dto.LocalDateTime)

      ' Transition from DST in local time zone occurs on 11/4/07 at 2:00 AM
      ' This is an ambiguous time
      dto = New DateTimeOffset(#11/4/2007 1:30AM#, New TimeSpan(-7, 0, 0))
      Console.WriteLine(TimeZoneInfo.Local.IsAmbiguousTime(dto))
      Console.WriteLine(dto.LocalDateTime)
      dto = New DateTimeOffset(#11/4/2007 2:30AM#, New TimeSpan(-7, 0, 0))           
      Console.WriteLine(TimeZoneInfo.Local.IsAmbiguousTime(dto))
      Console.WriteLine(dto.LocalDateTime)
      ' This is also an ambiguous time
      dto = New DateTimeOffset(#11/4/2007 1:30AM#, New TimeSpan(-8, 0, 0))           
      Console.WriteLine(TimeZoneInfo.Local.IsAmbiguousTime(dto))
      Console.WriteLine(dto.LocalDateTime)
      ' If run on 3/8/2007 at 4:56 PM, the code produces the following
      ' output:
      '    3/8/2007 4:56:03 PM
      '    3/8/2007 4:56:03 PM
      '    3/11/2007 3:30:00 AM
      '    3/11/2007 1:30:00 AM
      '    True
      '    3/11/2007 3:30:00 AM
      '    True
      '    11/4/2007 1:30:00 AM
      '    11/4/2007 1:30:00 AM
      '    True
      '    11/4/2007 1:30:00 AM      