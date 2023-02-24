using Tumbleweed.Scalars;

namespace Tumbleweed.ReadOnlySpans;

public sealed class SpanFromArray<T> : SpanEnvelope<T>
{
	public SpanFromArray(T[] array) : this
	(
		new ScalarOfValue<T[]>(array)
	)
	{
	}
	
	public SpanFromArray(IScalar<T[]> array) : base
	(
		() => new ReadOnlySpan<T>(array.Value)
	)
	{
	}
}