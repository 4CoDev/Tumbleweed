using Function = Tumbleweed.Subroutine.Function.Nullary;
using Span = Tumbleweed.Memory.Span.ReadOnly;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Memory.Span.ReadOnly.Function;

public sealed class Result<T> : Span::Any<T>
{
	public Result
	(
		Func<Span::Any<T>> function
	) : this
	(
		new Function::From.System
			<Span::Any<T>>
			(function)
	)
	{
	}
	
	public Result
	(
		Function::Any<Span::Any<T>> function
	)
	{ 
		this.function = function;
	}

	public ReadOnlySpan<T> AsSystem =>
		function.Result.AsSystem;

	private readonly Function::Any<Span::Any<T>> function;
}