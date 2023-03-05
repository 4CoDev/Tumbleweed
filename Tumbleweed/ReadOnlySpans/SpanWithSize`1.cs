using Tumbleweed.Scalars;

namespace Tumbleweed.ReadOnlySpans;

public sealed class SpanWithSize<T> : SpanEnvelope<T>
{
	public SpanWithSize(IReadOnlySpan<T> span, Int32 size) : this
	(
		span,
		new ScalarOfValue<Int32>(size)
	)
	{
	}
	
	public SpanWithSize(IReadOnlySpan<T> span, IScalar<Int32> size) : base
	(
		() => Result(span, size)
	)
	{
	}

	private static ReadOnlySpan<T> Result
	(
		IReadOnlySpan<T> span,
		IScalar<Int32> size
	)
	{
		if (span.Value.Length == size.Value) return span.Value;
		throw new InvalidOperationException("ReadOnlySpan size is wrong.");
	}
}