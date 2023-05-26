using Tumbleweed.Scalar;

namespace Tumbleweed._Collection;

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