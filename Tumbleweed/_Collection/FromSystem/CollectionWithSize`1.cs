using Tumbleweed.Scalar;

namespace Tumbleweed._Collection.FromSystem;

public sealed class CollectionWithSize<T> : CollectionEnvelope<T>
{
	public CollectionWithSize
	(
		ICollection<T> collection,
		Int32 size
	) : this
	(
		collection, new ScalarValue<Int32>(size)
	)
	{
	}

	public CollectionWithSize
	(
		ICollection<T> collection,
		IScalar<Int32> size
	) : base
	(
		new CollectionOfFunction<T>(
			() => Result(collection, size))
	)
	{
	}
	
	public CollectionWithSize
	(
	) : base
	(
		new CollectionOfFunction<T>(
			() => throw new InvalidOperationException("Test."))
	)
	{
	}

	private static ICollection<T> Result
	(
		ICollection<T> collection,
		IScalar<Int32> size
	)
	{
		if (collection.Count == size.Value) return collection;
		throw new InvalidOperationException("Collection size is wrong.");
	}
}