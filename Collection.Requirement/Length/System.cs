using Tumbleweed.Collection.Function.Result;
using Tumbleweed.Property.Output;
using Tumbleweed.Property.Output.With.Value;

namespace Tumbleweed.Collection.Requirement.Length;

public sealed class System<T> : Envelope<T>
{
	public System
	(
		ICollection<T> collection,
		Int32 size
	) : this
	(
		collection, new One<Int32>(size)
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