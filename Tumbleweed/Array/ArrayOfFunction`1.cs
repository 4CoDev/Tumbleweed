using Tumbleweed.Scalar;
using Tumbleweed.Subroutine.Function.Nullary;

namespace Tumbleweed.Array;

public sealed class ArrayOfFunction<T> : ArrayEnvelope<T>
{
	public ArrayOfFunction(Func<IArray<T>> function) : this
	(
		new FunctionFromSystem<IArray<T>>(function)
	)
	{
	}
	
	public ArrayOfFunction(IFunction<IArray<T>> function) : base
	(
		new ArrayOfScalar<T>(
			new ResultOfFunction<IArray<T>>(function))
	)
	{
	}
}