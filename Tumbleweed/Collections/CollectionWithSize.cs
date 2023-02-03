using Tumbleweed.Scalars;

namespace Tumbleweed.Collections;

public sealed class CollectionWithSize<T> : CollectionEnvelope<T>
{
	public CollectionWithSize(ICollection<T> collection, int size) : this
	(
		collection, new ScalarOfValue<int>(size)
	)
	{
	}
	
	public CollectionWithSize
	(
		ICollection<T> collection,
		IScalar<int> size
	) : base
	(
		new CollectionOfScalar<T>(
			new Scalar.CollectionWithSize<T>(collection, size))
	)
	{
	}
}