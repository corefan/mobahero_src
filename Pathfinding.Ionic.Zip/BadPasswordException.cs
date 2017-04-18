using System;
using System.Runtime.InteropServices;

namespace Pathfinding.Ionic.Zip
{
	[Guid("ebc25cf6-9120-4283-b972-0e5520d0000B")]
	public class BadPasswordException : ZipException
	{
		public BadPasswordException()
		{
		}

		public BadPasswordException(string message) : base(message)
		{
		}

		public BadPasswordException(string message, Exception innerException) : base(message, innerException)
		{
		}
	}
}
