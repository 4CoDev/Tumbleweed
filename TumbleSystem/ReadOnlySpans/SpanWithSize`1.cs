using Tumbleweed.Scalars;

namespace TumbleSystem.ReadOnlySpans;

public sealed class SpanWithSize<T> : SpanEnvelope<T>
{
	public SpanWithSize(IReadOnlySpan<T> span, int size) : this
	(
		span,
		new ScalarOfValue<int>(size)
	)
	{
	}
	
	public SpanWithSize(IReadOnlySpan<T> span, IScalar<int> size) : base
	(
		() => Result(span, size)
	)
	{
	}

	private static ReadOnlySpan<T> Result
	(
		IReadOnlySpan<T> span,
		IScalar<int> size
	)
	{
		if (span.Value.Length == size.Value()) return span.Value;
		throw new InvalidOperationException("ReadOnlySpan size is wrong.");
	}
}