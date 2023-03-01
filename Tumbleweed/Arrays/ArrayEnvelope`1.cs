using Tumbleweed.Numerics.Integers;
using Tumbleweed.Numerics.Integers.Signed;

namespace Tumbleweed.Arrays;

public abstract class ArrayEnvelope<T> : IArray<T>
{
	protected ArrayEnvelope(IArray<T> array)
	{
		this.array = array;
	}
	
	public T this[IEnumerable<ISignedInteger> indices]
	{
		get => array[indices];
	}
	
	private readonly IArray<T> array;
}