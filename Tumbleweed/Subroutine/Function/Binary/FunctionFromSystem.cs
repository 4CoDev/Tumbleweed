using Tumbleweed.Scalar;

namespace Tumbleweed.Subroutine.Function.Binary;

public sealed class FunctionFromSystem<T1, T2, TResult> :
	IFunction<T1, T2, TResult>
{
	public FunctionFromSystem
	(
		Func<T1, T2, TResult> function
	) : this
	(
		new ScalarValue<Func<T1, T2, TResult>>(function)
	)
	{
	}
	
	public FunctionFromSystem
	(
		IScalar<Func<T1, T2, TResult>> function
	)
	{
		this.function = function;
	}


	public TResult ResultWith(T1 parameter1, T2 parameter2) =>
		function.Value.Invoke(parameter1, parameter2);

	private readonly IScalar<Func<T1, T2, TResult>> function;
}