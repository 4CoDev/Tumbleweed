using Tumbleweed._Enumerable;
using Tumbleweed.Scalar;

namespace Tumbleweed._Byte.OfSystem;

public sealed class ByteFromBooleans : IScalar<Byte>
{
	public ByteFromBooleans(IEnumerable<IScalar<Boolean>> booleans) : this
	(
		new ValuesOfScalars<Boolean>(booleans)
	)
	{
	}
	
	public ByteFromBooleans(IEnumerable<Boolean> booleans) : this
	(
		new List<Boolean>(booleans)
	)
	{
	}
	
	public ByteFromBooleans(IList<Boolean> booleans)
	{
		this.booleans = booleans;
	}

	public Byte Value
	{
		get
		{
			if (booleans.Count > 8)
			{
				throw new ArgumentException("Byte must have 8 bits");
			}
			Byte result = 0;
			for (Int32 i = 0; i < booleans.Count; i++)
			{
				Boolean boolean = booleans[i];
				if (boolean) result |= (Byte) (1 << i);
			}
			return result;
		}
	}

	private readonly IList<Boolean> booleans;
}