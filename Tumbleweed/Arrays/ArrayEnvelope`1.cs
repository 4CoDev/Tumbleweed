using Tumbleweed.Numerics.Integers;

namespace Tumbleweed.Arrays;

public abstract class ArrayEnvelope<T> : IArray<T>
{
	protected ArrayEnvelope(IArray<T> array)
	{
		this.array = array;
	}
	
	public T this[IEnumerable<IInteger> indices]
	{
		get => array[indices];
	}
	
	private readonly IArray<T> array;
}