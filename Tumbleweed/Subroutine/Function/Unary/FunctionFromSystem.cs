using Tumbleweed.Scalar;

namespace Tumbleweed.Subroutine.Function.Unary;

public sealed class FunctionFromSystem<TParameter, TResult> :
	IFunction<TParameter, TResult>
{
	public FunctionFromSystem
	(
		Func<TParameter, TResult> function
	) : this
	(
		new ScalarValue<Func<TParameter, TResult>>(function)
	)
	{
	}
	
	public FunctionFromSystem
	(
		IScalar<Func<TParameter, TResult>> function
	)
	{
		this.function = function;
	}


	public TResult ResultWith(TParameter parameter) =>
		function.Value.Invoke(parameter);

	private readonly IScalar<Func<TParameter, TResult>> function;
}