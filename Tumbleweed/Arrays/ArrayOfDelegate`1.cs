using Tumbleweed.Scalars;

namespace Tumbleweed.Arrays;

public sealed class ArrayOfDelegate<T> : ArrayEnvelope<T>
{
	public ArrayOfDelegate(Func<IArray<T>> @delegate) : base
	(
		new ArrayOfScalar<T>(
			new ValueOfDelegate<IArray<T>>(@delegate))
	)
	{
	}
}