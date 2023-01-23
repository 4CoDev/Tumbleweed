using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace Tumbleweed.Bytes.WithSystem;

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
	
	public byte Value()
	{
		byte result = 0;
		for (int i = 0; i < 8; i++)
		{
			bool boolean = booleans[i];
			if (boolean) result |= (byte)(1 << i);
		}
		return result;
	}
	
	private readonly IList<bool> booleans;
}