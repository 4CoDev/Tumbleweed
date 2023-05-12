using Tumbleweed.Scalars;
using Tumbleweed.Subroutines.Functions.Nullary;

namespace Tumbleweed.Arrays;

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