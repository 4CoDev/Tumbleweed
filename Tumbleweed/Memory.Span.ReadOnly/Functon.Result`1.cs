using NullaryFunction = Tumbleweed.Subroutine.Function.Nullary;
using ReadOnlySpan = Tumbleweed.Memory.Span.ReadOnly;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Memory.Span.ReadOnly.Function;

public sealed class Result<T> : ReadOnlySpan.Any<T>
{
	public Result
	(
		Func<ReadOnlySpan.Any<T>> function
	) : this
	(
		new NullaryFunction.From.System<ReadOnlySpan.Any<T>>(function)
	)
	{
	}
	
	public Result
	(
		NullaryFunction.Any<ReadOnlySpan.Any<T>> function
	)
	{ 
		this.function = function;
	}

	public ReadOnlySpan<T> Value =>
		function.Result.Value;

	private readonly NullaryFunction.Any<ReadOnlySpan.Any<T>> function;
}