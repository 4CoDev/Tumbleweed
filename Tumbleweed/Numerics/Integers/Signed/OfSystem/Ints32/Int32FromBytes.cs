using Tumbleweed.Enumerables;
using Tumbleweed.ReadOnlySpans;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Integers.Signed.OfSystem.Ints32;

public sealed class Int32FromBytes : ScalarEnvelope<Int32>
{
	public Int32FromBytes(IEnumerable<IScalar<Byte>> bytes) : this
	(
		new ValuesOfScalars<Byte>(bytes)
	)
	{
	}
	
	public Int32FromBytes(IEnumerable<Byte> bytes) : this
	(
		new SpanFromEnumerable<Byte>(bytes)
	)
	{
	}
	
	public Int32FromBytes(IReadOnlySpan<Byte> bytes) : base
	(
		new ValueOfDelegate<Int32>(
			() => BitConverter.ToInt32(
				new SpanWithSize<Byte>(bytes, 4).Value))
	)
	{
	}
}