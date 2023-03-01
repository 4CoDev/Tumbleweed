using Tumbleweed.Enumerables;
using Tumbleweed.ReadOnlySpans;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Integers.Signed.OfSystem.Ints32;

public sealed class Int32FromBytes : ScalarEnvelope<int>
{
	public Int32FromBytes(IEnumerable<IScalar<byte>> bytes) : this
	(
		new ValuesOfScalars<byte>(bytes)
	)
	{
	}
	
	public Int32FromBytes(IEnumerable<byte> bytes) : this
	(
		new SpanFromEnumerable<byte>(bytes)
	)
	{
	}
	
	public Int32FromBytes(IReadOnlySpan<byte> bytes) : base
	(
		new ValueOfDelegate<int>(
			() => BitConverter.ToInt32(
				new SpanWithSize<byte>(bytes, 4).Value))
	)
	{
	}
}