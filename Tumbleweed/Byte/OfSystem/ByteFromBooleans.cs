using Tumbleweed.Enumerable;
using Tumbleweed.Enumerable.Item.Every.Scalar;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Immutable;
using System = System;

namespace Tumbleweed.Byte.OfSystem;

public sealed class ByteFromBooleans : Any<global::System.Byte>
{
	public ByteFromBooleans(IEnumerable<Any<System::Boolean>> booleans) : this
	(
		new Value<System::Boolean>(booleans)
	)
	{
	}
	
	public ByteFromBooleans(IEnumerable<System::Boolean> booleans) : this
	(
		new List<System::Boolean>(booleans)
	)
	{
	}
	
	public ByteFromBooleans(IList<System::Boolean> booleans)
	{
		this.booleans = booleans;
	}

	public global::System.Byte Value
	{
		get
		{
			if (booleans.Count > 8)
			{
				throw new ArgumentException("Byte must have 8 bits");
			}
			global::System.Byte result = 0;
			for (Int32 i = 0; i < booleans.Count; i++)
			{
				System::Boolean boolean = booleans[i];
				if (boolean) result |= (global::System.Byte) (1 << i);
			}
			return result;
		}
	}

	private readonly IList<System::Boolean> booleans;
}