using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace Tumbleweed.Bytes.OfSystem;

public sealed class ByteFromBooleans : IScalar<byte>
{
	public ByteFromBooleans(IEnumerable<IScalar<bool>> booleans) : this
	(
		new ValuesOfScalars<bool>(booleans)
	)
	{
	}
	
	public ByteFromBooleans(IEnumerable<bool> booleans) : this
	(
		new List<bool>(booleans)
	)
	{
	}
	
	public ByteFromBooleans(IList<bool> booleans)
	{
		this.booleans = booleans;
	}

	public byte Value
	{
		get
		{
			if (booleans.Count > 8)
			{
				throw new ArgumentException("Byte must have 8 bits");
			}
			byte result = 0;
			for (int i = 0; i < booleans.Count; i++)
			{
				bool boolean = booleans[i];
				if (boolean) result |= (byte) (1 << i);
			}
			return result;
		}
	}

	private readonly IList<bool> booleans;
}