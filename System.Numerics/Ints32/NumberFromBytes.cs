using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;
using Tumbleweed.System.Arrays;

namespace Tumbleweed.System.Numerics.Ints32;

public sealed class NumberFromBytes : IScalar<int>
{
	public NumberFromBytes(IEnumerable<IScalar<byte>> bytes) : this
	(
		new ArrayFromEnumerable<byte>(
			new ValuesOfScalars<byte>(bytes))
	)
	{
	}
	
	public NumberFromBytes(IScalar<byte[]> bytes)
	{
		this.bytes = bytes;
	}

	public int Value()
	{
		return BitConverter.ToInt32(
			new ReadOnlySpan<byte>(bytes.Value()));
	}

	private readonly IScalar<byte[]> bytes;
}