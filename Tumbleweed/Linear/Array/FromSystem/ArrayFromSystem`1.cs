using Tumbleweed._Enumerable;
using Tumbleweed.Array;
using Tumbleweed.Linear.Array.Element.FromSystem;
using Tumbleweed.Number.Integer.Natural;
using Tumbleweed.Scalar;

namespace Tumbleweed.Linear.Array.FromSystem;

public sealed class ArrayFromSystem<T> : IArray<T>
{
	public ArrayFromSystem(params T[] array) : this
	(
		new ScalarValue<T[]>(array)
	)
	{
	}

	public ArrayFromSystem(IScalar<T[]> array) =>
		this.array = array;
	
	public T this[IEnumerable<INatural> indices]
	{
		get => new ElementOfArray<T>(array, indices).Value;
		set => new ElementOfArray<T>(array, indices).Value = value;
	}

	public IEnumerable<INatural> Size =>
	(
		new EnumerableFromElement<INatural>(
			new SizeOfArray<T>(array))
	);

	private readonly IScalar<T[]> array;
}