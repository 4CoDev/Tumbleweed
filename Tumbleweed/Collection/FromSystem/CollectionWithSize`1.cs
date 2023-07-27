using Tumbleweed.Scalar;

namespace Tumbleweed.Collection.FromSystem;

public sealed class CollectionWithSize<T> : CollectionEnvelope<T>
{
	public CollectionWithSize
	(
		ICollection<T> collection,
		Int32 size
	) : this
	(
		collection, new Tumbleweed.Scalar.Of.Value<Int32>(size)
	)
	{
	}

	public CollectionWithSize
	(
		ICollection<T> collection,
		Any<Int32> size
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
		Any<Int32> size
	)
	{
		if (collection.Count == size.Value) return collection;
		throw new InvalidOperationException("Collection size is wrong.");
	}
}