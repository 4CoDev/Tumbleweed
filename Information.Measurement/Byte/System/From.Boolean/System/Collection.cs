using Tumbleweed.Property.Output;
using System = System;

namespace Tumbleweed.Information.Measurement.Byte.System.From.Boolean.System;

public sealed class Collection : Any<global::System.Byte>
{
	public Collection(IEnumerable<System::Boolean> booleans) : this
	(
		new List<System::Boolean>(booleans)
	)
	{
	}
	
	public Collection(ICollection<System::Boolean> booleans)
	{
		this.booleans = booleans;
	}

	public global::System.Byte Value
	{
		get
		{
			if (booleans.Count > 8)
				throw new ArgumentException("Byte must have 8 bits");
			global::System.Byte result = 0;
			for (Int32 i = 0; i < booleans.Count; i++)
			{
				System::Boolean boolean = booleans.ElementAt(i);
				if (boolean) result |= (global::System.Byte) (1 << i);
			}
			return result;
		}
	}

	private readonly ICollection<System::Boolean> booleans;
}