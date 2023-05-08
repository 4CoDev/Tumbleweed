using Tumbleweed.Delegates.Functions.Nullary;

namespace Tumbleweed.Scalars;

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