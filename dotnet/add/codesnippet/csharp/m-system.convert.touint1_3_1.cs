      bool falseFlag = false;
      bool trueFlag = true;
      
      Console.WriteLine("{0} converts to {1}.", falseFlag,
                        Convert.ToInt16(falseFlag));
      Console.WriteLine("{0} converts to {1}.", trueFlag,
                        Convert.ToUInt16(trueFlag));
      // The example displays the following output:
      //       False converts to 0.
      //       True converts to 1.