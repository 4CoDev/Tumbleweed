using Tumbleweed.Delegates.Functions.Nullary;
using Tumbleweed.Scalars;

namespace Tumbleweed.Enumerables;

public sealed class EnumerableOfFunction<T> : EnumerableEnvelope<T>
{
	public EnumerableOfFunction
	(
		Func<IEnumerable<T>> function
	) : this
	(
		new FunctionFromSystem<IEnumerable<T>>(function)
	)
	{
	}
	
	public EnumerableOfFunction
	(
		IFunction<IEnumerable<T>> function
	) : base
	(
		new EnumerableOfScalar<T>(
			new ResultOfFunction<IEnumerable<T>>(function))
	)
	{
	}
}