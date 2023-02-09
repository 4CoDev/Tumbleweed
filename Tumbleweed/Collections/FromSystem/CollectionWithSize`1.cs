using Tumbleweed.Scalars;

namespace Tumbleweed.Collections.FromSystem;

public sealed class CollectionWithSize<T> : CollectionEnvelope<T>
{
	public CollectionWithSize
	(
		ICollection<T> collection,
		int size
	) : this
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
		new CollectionOfDelegate<T>(
			() => Result(collection, size))
	)
	{
	}
	
	public CollectionWithSize
	(
	) : base
	(
		new CollectionOfDelegate<T>(
			() => throw new InvalidOperationException("Test."))
	)
	{
	}

	private static ICollection<T> Result
	(
		ICollection<T> collection,
		IScalar<int> size
	)
	{
		if (collection.Count == size.Value()) return collection;
		throw new InvalidOperationException("Collection size is wrong.");
	}
}