using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Of;
using Tumbleweed.Scalar.Immutable.With;

namespace Tumbleweed.Collection.FromSystem;

public sealed class CollectionWithSize<T> : CollectionEnvelope<T>
{
	public CollectionWithSize
	(
		ICollection<T> collection,
		Int32 size
	) : this
	(
		collection, new Value<Int32>(size)
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