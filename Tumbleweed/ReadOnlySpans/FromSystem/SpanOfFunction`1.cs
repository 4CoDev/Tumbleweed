using Tumbleweed.ReadOnlySpans.OfSystem;

namespace Tumbleweed.ReadOnlySpans.FromSystem;

public sealed class SpanOfFunction<T> : IReadOnlySpan<T>
{
	public SpanOfFunction(SpanFunction<T> span) =>
		this.span = span;

	public ReadOnlySpan<T> Value => span();

	private readonly SpanFunction<T> span;
}