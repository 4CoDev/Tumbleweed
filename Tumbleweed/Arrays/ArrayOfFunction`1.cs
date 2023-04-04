using Tumbleweed.Delegates.Functions.Nullary;
using Tumbleweed.Scalars;

namespace Tumbleweed.Arrays;

public sealed class ArrayOfFunction<T> : ArrayEnvelope<T>
{
	public ArrayOfFunction(Func<IArray<T>> function) : this
	(
		new FunctionFromSystem<IArray<T>>(function)
	)
	{
	}
	
	public ArrayOfFunction(INullaryFunction<IArray<T>> function) : base
	(
		new ArrayOfScalar<T>(
			new ValueOfFunction<IArray<T>>(function))
	)
	{
	}
}