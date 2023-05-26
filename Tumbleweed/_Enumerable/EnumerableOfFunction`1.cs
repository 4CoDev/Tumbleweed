using Tumbleweed.Scalar;
using Tumbleweed.Subroutine.Function.Nullary;

namespace Tumbleweed._Enumerable;

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