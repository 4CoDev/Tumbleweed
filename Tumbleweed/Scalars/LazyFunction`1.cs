using Tumbleweed.Delegates.Functions.Nullary;

namespace Tumbleweed.Scalars;

public sealed class LazyFunction<T> : ScalarEnvelope<T>
{
	public LazyFunction(Func<T> function) : this
	(
		new NullaryFromSystem<T>(function)
	)
	{
	}
	
	public LazyFunction(INullaryFunction<T> function) : base
	(
		new LazyValue<T>(
			new ValueOfDelegate<T>(function))
	)
	{
	}
}