		public void ConvertDoubleString(double doubleVal) {
			
			string	stringVal;     

			// A conversion from Double to string cannot overflow.       
			stringVal = System.Convert.ToString(doubleVal);
			System.Console.WriteLine("{0} as a string is: {1}",
				doubleVal, stringVal);

			try {
				doubleVal = System.Convert.ToDouble(stringVal);
				System.Console.WriteLine("{0} as a double is: {1}",
					stringVal, doubleVal);
			} 
			catch (System.OverflowException) {
				System.Console.WriteLine(
					"Conversion from string-to-double overflowed.");
			}
			catch (System.FormatException) {
				System.Console.WriteLine(
					"The string was not formatted as a double.");
			}
			catch (System.ArgumentException) {
				System.Console.WriteLine(
					"The string pointed to null.");
			}
		}