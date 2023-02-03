using Tumbleweed.Scalars;

namespace Tumbleweed.Collections.Scalar;

public sealed class WithoutLastElement<T> : IScalar<ICollection<T>>
{
	public WithoutLastElement(ICollection<T> collection)
	{
		this.collection = collection;
	}

	public ICollection<T> Value()
	{
		return new List<T>(collection.Take(collection.Count - 1));
	}
	
	private readonly ICollection<T> collection;
}