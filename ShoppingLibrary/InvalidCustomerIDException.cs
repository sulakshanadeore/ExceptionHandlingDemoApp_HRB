using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingLibrary
{

	[Serializable]
	public class InvalidCustomerIDException : Exception
	{
		public InvalidCustomerIDException() { }
		public InvalidCustomerIDException(string message) : base(message) { }
		public InvalidCustomerIDException(string message, Exception inner) : base(message, inner) { }
		protected InvalidCustomerIDException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}
