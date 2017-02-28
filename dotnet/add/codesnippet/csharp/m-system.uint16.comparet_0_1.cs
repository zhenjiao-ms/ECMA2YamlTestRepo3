	public class Temperature : IComparable {
		/// <summary>
		/// IComparable.CompareTo implementation.
		/// </summary>
		public int CompareTo(object obj) {
			if(obj is Temperature) {
				Temperature temp = (Temperature) obj;

				return m_value.CompareTo(temp.m_value);
			}
			
			throw new ArgumentException("object is not a Temperature");	
		}

		// The value holder
		protected ushort m_value;

		public ushort Value {
			get {
				return m_value;
			}
			set {
				m_value = value;
			}
		}
	}