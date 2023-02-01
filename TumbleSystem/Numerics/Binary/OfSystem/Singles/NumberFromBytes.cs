using TumbleSystem.ReadOnlySpans;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace TumbleSystem.Numerics.Binary.OfSystem.Singles;

public sealed class NumberFromBytes : ScalarEnvelope<float>
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
		() => BitConverter.ToSingle(
			new SpanWithSize<byte>(bytes, 4).Value)
	)
	{
	}
}