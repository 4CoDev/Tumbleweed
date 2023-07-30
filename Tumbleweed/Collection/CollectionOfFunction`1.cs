using Tumbleweed.Scalar.Immutable.Function.Result;

namespace Tumbleweed.Collection;

public sealed class CollectionOfFunction<T> : CollectionEnvelope<T>
{
	public CollectionOfFunction(Func<ICollection<T>> @delegate) : base
	(
		new CollectionOfScalar<T>(
			new Actual<ICollection<T>>(@delegate))
	)
	{
	}
}