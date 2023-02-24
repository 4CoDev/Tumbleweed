using Tumbleweed.Enumerables;
using Tumbleweed.ReadOnlySpans;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Integers.OfSystem.Ints32;

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
		new SpanFromEnumerable<byte>(bytes)
	)
	{
	}
	
	public NumberFromBytes(IReadOnlySpan<byte> bytes) : base
	(
		new ScalarOfDelegate<int>(
			() => BitConverter.ToInt32(
				new SpanWithSize<byte>(bytes, 4).Value))
	)
	{
	}
}