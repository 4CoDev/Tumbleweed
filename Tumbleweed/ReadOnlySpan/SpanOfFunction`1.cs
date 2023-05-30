using Tumbleweed.Subroutine.Nullary.Function;

namespace Tumbleweed.ReadOnlySpan;

public sealed class SpanOfFunction<T> : IReadOnlySpan<T>
{
	public SpanOfFunction
	(
		Func<IReadOnlySpan<T>> function
	) : this
	(
		new FunctionFromSystem<IReadOnlySpan<T>>(function)
	)
	{
	}
	
	public SpanOfFunction
	(
		IFunction<IReadOnlySpan<T>> function
	)
	{
		this.function = function;
	}

	public ReadOnlySpan<T> Value =>
		function.Result.Value;

	private readonly IFunction<IReadOnlySpan<T>> function;
}