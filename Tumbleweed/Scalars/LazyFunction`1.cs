using Tumbleweed.Delegates.Functions.Nullary;

namespace Tumbleweed.Scalars;

public sealed class LazyFunction<T> : ScalarEnvelope<T>
{
	public LazyFunction(Func<T> function) : this
	(
		new FunctionFromSystem<T>(function)
	)
	{
	}
	
	public LazyFunction(INullaryFunction<T> function) : base
	(
		new LazyValue<T>(
			new ValueOfFunction<T>(function))
	)
	{
	}
}