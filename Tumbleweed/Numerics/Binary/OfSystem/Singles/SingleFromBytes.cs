using Tumbleweed.Enumerables;
using Tumbleweed.ReadOnlySpans;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Binary.OfSystem.Singles;

public sealed class SingleFromBytes : ScalarEnvelope<float>
{
	public SingleFromBytes(IEnumerable<IScalar<byte>> bytes) : this
	(
		new ValuesOfScalars<byte>(bytes)
	)
	{
	}
	
	public SingleFromBytes(IEnumerable<byte> bytes) : this
	(
		new SpanFromEnumerable<byte>(bytes)
	)
	{
	}
	
	public SingleFromBytes(IReadOnlySpan<byte> bytes) : base
	(
		() => BitConverter.ToSingle(
			new SpanWithSize<byte>(bytes, 4).Value)
	)
	{
	}
}