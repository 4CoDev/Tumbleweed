using Tumbleweed.Subroutine.Function.Nullary;

namespace Tumbleweed.Scalar;

public sealed class LazyResultOfFunction<T> : ScalarEnvelope<T>
{
	public LazyResultOfFunction(Func<T> function) : this
	(
		new FunctionFromSystem<T>(function)
	)
	{
	}
	
	public LazyResultOfFunction(IFunction<T> function) : base
	(
		new LazyValue<T>(
			new ResultOfFunction<T>(function))
	)
	{
	}
}