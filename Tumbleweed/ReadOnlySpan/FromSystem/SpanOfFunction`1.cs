using Tumbleweed.ReadOnlySpan.OfSystem;

namespace Tumbleweed.ReadOnlySpan.FromSystem;

public sealed class SpanOfFunction<T> : IReadOnlySpan<T>
{
	public SpanOfFunction(SpanFunction<T> span) =>
		this.span = span;

	public ReadOnlySpan<T> Value => span();

	private readonly SpanFunction<T> span;
}