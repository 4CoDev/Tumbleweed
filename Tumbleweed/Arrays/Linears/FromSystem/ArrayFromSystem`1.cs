using Tumbleweed.Arrays.Linears.Elements.FromSystem;
using Tumbleweed.Enumerables;
using Tumbleweed.Numbers.Integers.Natural;
using Tumbleweed.Scalars;

namespace Tumbleweed.Arrays.Linears.FromSystem;

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
		get => new ElementOfArray<T>(array, indices).Variable;
		set => new ElementOfArray<T>(array, indices).Variable = value;
	}

	public IEnumerable<INatural> Size =>
	(
		new EnumerableFromElement<INatural>(
			new SizeOfArray<T>(array))
	);

	private readonly IScalar<T[]> array;
}