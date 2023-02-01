using Tumbleweed.Scalars;

namespace TumbleSystem.Collections.Scalar;

public sealed class CollectionWithSize<T> : IScalar<ICollection<T>>
{
	public CollectionWithSize(ICollection<T> collection, int size) : this
	(
		collection, new ScalarOfValue<int>(size)
	)
	{
	}
	
	public CollectionWithSize(ICollection<T> collection, IScalar<int> size)
	{
		this.collection = collection;
		this.size = size;
	}
	
	public ICollection<T> Value()
	{
		if (collection.Count == size.Value()) return collection;
		throw new InvalidOperationException("Collection size is wrong.");
	}
	
	private readonly ICollection<T> collection;
	
	private readonly IScalar<int> size;
}