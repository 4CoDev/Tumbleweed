using Tumbleweed.Arrays.Linears.Elements.FromSystem;
using Tumbleweed.Enumerables;
using Tumbleweed.Numerics.Integers.Natural;
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
	
	public T this[IEnumerable<INaturalInteger> indices]
	{
		get => new ElementOfArray<T>(array, indices).Variable;
		set => new ElementOfArray<T>(array, indices).Variable = value;
	}

	public IEnumerable<INaturalInteger> Size =>
	(
		new EnumerableFromElement<INaturalInteger>(
			new SizeOfArray<T>(array))
	);

	private readonly IScalar<T[]> array;
}