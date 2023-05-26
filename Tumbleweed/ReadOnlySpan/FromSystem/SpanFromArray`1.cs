using Tumbleweed.Scalar;

namespace Tumbleweed.ReadOnlySpan.FromSystem;

public sealed class SpanFromArray<T> : SpanEnvelope<T>
{
	public SpanFromArray(T[] array) : this
	(
		new ScalarValue<T[]>(array)
	)
	{
	}
	
	public SpanFromArray(IScalar<T[]> array) : base
	(
		new SpanOfFunction<T>(
			() => new ReadOnlySpan<T>(array.Value))
	)
	{
	}
}