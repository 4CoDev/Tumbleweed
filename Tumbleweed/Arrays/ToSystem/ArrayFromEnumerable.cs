using Tumbleweed.Scalars;

namespace Tumbleweed.Arrays.ToSystem;

public sealed class ArrayFromEnumerable<T> : IScalar<T[]>
{
	public ArrayFromEnumerable(IEnumerable<T> enumerable)
	{
		this.enumerable = enumerable;
	}
	
	public T[] Value()
	{
		return enumerable.ToArray();
	}
	
	private readonly IEnumerable<T> enumerable;
}