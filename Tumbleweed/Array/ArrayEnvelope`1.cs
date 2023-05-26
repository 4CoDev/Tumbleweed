using Tumbleweed.Number.Integer.Natural;

namespace Tumbleweed.Array;

public abstract class ArrayEnvelope<T> : IArray<T>
{
	protected ArrayEnvelope(IArray<T> array) =>
		this.array = array;

	public T this[IEnumerable<INatural> indices]
	{
		get => array[indices];
		set => array[indices] = value;
	}

	public IEnumerable<INatural> Size =>
		array.Size;
	
	private readonly IArray<T> array;
}