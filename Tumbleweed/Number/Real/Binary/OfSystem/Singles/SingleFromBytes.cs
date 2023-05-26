using Tumbleweed._Enumerable;
using Tumbleweed.ReadOnlySpan;
using Tumbleweed.ReadOnlySpan.FromSystem;
using Tumbleweed.Scalar;

namespace Tumbleweed.Number.Real.Binary.OfSystem.Singles;

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
		new ResultOfFunction<Single>(
			() => BitConverter.ToSingle(
				new SpanWithSize<Byte>(bytes, 4).Value))
	)
	{
	}
}