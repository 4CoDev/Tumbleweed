using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;
using Tumbleweed.WithSystem.Arrays;

namespace Tumbleweed.WithSystem.Numerics.Ints32;

public sealed class NumberFromBytes : ScalarEnvelope<int>
{
	public NumberFromBytes(IEnumerable<IScalar<byte>> bytes) : this
	(
		new ValuesOfScalars<byte>(bytes)
	)
	{
	}
	
	public NumberFromBytes(IEnumerable<byte> bytes) : this
	(
		new ArrayFromEnumerable<byte>(bytes)
	)
	{
	}
	
	public NumberFromBytes(IScalar<byte[]> bytes) : base
	(
		new ScalarOfDelegate<int>(
			() => BitConverter.ToInt32(
				new ReadOnlySpan<byte>(bytes.Value())))
	)
	{
	}
}