using Tumbleweed.Delegates.Functions.Nullary;

namespace Tumbleweed.ReadOnlySpans;

public sealed class SpanOfFunction<T> : IReadOnlySpan<T>
{
	public SpanOfFunction
	(
		Func<IReadOnlySpan<T>> function
	) : this
	(
		new NullaryFromSystem<IReadOnlySpan<T>>(function)
	)
	{
	}
	
	public SpanOfFunction
	(
		INullaryFunction<IReadOnlySpan<T>> function
	)
	{
		this.function = function;
	}

	public ReadOnlySpan<T> Value => function.Invoke().Value;

	private readonly INullaryFunction<IReadOnlySpan<T>> function;
}