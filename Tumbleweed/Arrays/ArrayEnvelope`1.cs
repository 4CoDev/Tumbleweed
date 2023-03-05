using Tumbleweed.Numerics.Integers.Natural;

namespace Tumbleweed.Arrays;

public abstract class ArrayEnvelope<T> : IArray<T>
{
	protected ArrayEnvelope(IArray<T> array) =>
		this.array = array;
	
	public T this[IEnumerable<INaturalInteger> indices] =>
		array[indices];
	
	private readonly IArray<T> array;
}