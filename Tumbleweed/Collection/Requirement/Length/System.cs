using Tumbleweed.Collection.Function.Result;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.With;

namespace Tumbleweed.Collection.Requirement.Length;

public sealed class System<T> : Envelope<T>
{
	public System
	(
		ICollection<T> collection,
		Int32 size
	) : this
	(
		collection, new Value<Int32>(size)
	)
	{
	}

	public System
	(
		ICollection<T> collection,
		Any<Int32> size
	) : base
	(
		new Actual<T>(
			() => Result(collection, size))
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
		throw new InvalidOperationException(
			$"The size of the collection is {collection.Count} instead of {size.Value}.");
	}
}