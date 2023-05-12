using Tumbleweed.Scalars;
using Tumbleweed.Subroutines.Functions.Nullary;

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