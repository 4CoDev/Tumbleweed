using Tumbleweed.Scalars;

namespace Tumbleweed.Collections;

public sealed class CollectionOfFunction<T> : CollectionEnvelope<T>
{
	public CollectionOfFunction(Func<ICollection<T>> @delegate) : base
	(
		new CollectionOfScalar<T>(
			new ResultOfFunction<ICollection<T>>(@delegate))
	)
	{
	}
}