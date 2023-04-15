using Tumbleweed.Scalars;

namespace Tumbleweed.Delegates.Functions.Unary;

public sealed class FunctionFromSystem<TParameter, TResult> :
	IUnaryFunction<TParameter, TResult>
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


	public TResult Invoke(TParameter parameter) =>
		function.Value.Invoke(parameter);

	private readonly IScalar<Func<TParameter, TResult>> function;
}