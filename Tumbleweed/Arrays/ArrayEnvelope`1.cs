using Tumbleweed.Numerics.Integers.Natural;

namespace Tumbleweed.Arrays;

public abstract class ArrayEnvelope<T> : IArray<T>
{
	protected ArrayEnvelope(IArray<T> array) =>
		this.array = array;

	public T this[IEnumerable<INaturalInteger> indices]
	{
		get => array[indices];
		set => array[indices] = value;
	}

	public IEnumerable<INaturalInteger> Size =>
		array.Size;
	
	private readonly IArray<T> array;
}