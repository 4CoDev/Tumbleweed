using Tumbleweed.Enumerables;
using Tumbleweed.ReadOnlySpans;
using Tumbleweed.ReadOnlySpans.FromSystem;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numbers.Real.Binaries.OfSystem.Singles;

public sealed class SingleFromBytes : ScalarEnvelope<Single>
{
	public SingleFromBytes(IEnumerable<IScalar<Byte>> bytes) : this
	(
		new ValuesOfScalars<Byte>(bytes)
	)
	{
	}
	
	public SingleFromBytes(IEnumerable<Byte> bytes) : this
	(
		new SpanFromEnumerable<Byte>(bytes)
	)
	{
	}
	
	public SingleFromBytes(IReadOnlySpan<Byte> bytes) : base
	(
		new ValueOfFunction<Single>(
			() => BitConverter.ToSingle(
				new SpanWithSize<Byte>(bytes, 4).Value))
	)
	{
	}
}