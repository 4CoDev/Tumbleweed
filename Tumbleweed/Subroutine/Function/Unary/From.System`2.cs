using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Of;
using Tumbleweed.Scalar.Immutable.With;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Subroutine.Function.Unary.From;

public sealed class System<TParameter, TResult> :
	Any<TParameter, TResult>
{
	public System
	(
		Func<TParameter, TResult> function
	) : this
	(
		new Value<Func<TParameter, TResult>>(function)
	)
	{
	}
	
	public System
	(
		Any<Func<TParameter, TResult>> function
	)
	{
		this.function = function;
	}


	public TResult ResultWith(TParameter parameter) =>
		function.Value.Invoke(parameter);

	private readonly Any<Func<TParameter, TResult>> function;
}