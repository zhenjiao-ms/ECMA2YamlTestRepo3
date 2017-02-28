      // Create a hexadecimal value out of range of the Integer type.
      long sourceNumber = (long) int.MaxValue + 1;
      bool isNegative = Math.Sign(sourceNumber) == -1;
      string value = Convert.ToString(sourceNumber, 16);
      int targetNumber;
      try
      {
         targetNumber = Convert.ToInt32(value, 16);
         if (!(isNegative) & (targetNumber & 0x80000000) != 0) 
            throw new OverflowException();
         else 
            Console.WriteLine("0x{0} converts to {1}.", value, targetNumber);
      }
      catch (OverflowException)
      {
         Console.WriteLine("Unable to convert '0x{0}' to an integer.", value);
      } 
      // Displays the following to the console:
      //    Unable to convert '0x80000000' to an integer.    