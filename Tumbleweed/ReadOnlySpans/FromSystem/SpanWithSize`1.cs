using Tumbleweed.Scalars;

namespace Tumbleweed.ReadOnlySpans.FromSystem;

public sealed class SpanWithSize<T> : SpanEnvelope<T>
{
	public SpanWithSize
	(
		IReadOnlySpan<T> span,
		Int32 size
	) : this
	(
		span,
		new ScalarOfValue<Int32>(size)
	)
	{
	}
	
	public SpanWithSize
	(
		IReadOnlySpan<T> span,
		IScalar<Int32> size
	) : base
	(
		new ReadOnlySpans.SpanOfFunction<T>(
			() => Function(span, size))
	)
	{
	}

	private static IReadOnlySpan<T> Function
	(
		IReadOnlySpan<T> span,
		IScalar<Int32> size
	)
	{
		if (span.Value.Length == size.Value) return span;
		throw new InvalidOperationException("ReadOnlySpan size is wrong.");
	}
}