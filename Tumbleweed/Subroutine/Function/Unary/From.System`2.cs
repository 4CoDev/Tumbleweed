using Tumbleweed.Scalar;

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
		new Scalar.Of.Value<Func<TParameter, TResult>>(function)
	)
	{
	}
	
	public System
	(
		Scalar.Any<Func<TParameter, TResult>> function
	)
	{
		this.function = function;
	}


	public TResult ResultWith(TParameter parameter) =>
		function.Value.Invoke(parameter);

	private readonly Scalar.Any<Func<TParameter, TResult>> function;
}