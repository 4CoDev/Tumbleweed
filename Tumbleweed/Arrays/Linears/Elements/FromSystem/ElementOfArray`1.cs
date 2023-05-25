using Tumbleweed.Mutables;
using Tumbleweed.Numbers.Integers.Natural;
using Tumbleweed.Numbers.Integers.Natural.FromEnumerable;
using Tumbleweed.Numbers.Integers.Natural.ToSystem;
using Tumbleweed.Numbers.Integers.Signed.ToSystem.Ints32;
using Tumbleweed.Scalars;

namespace Tumbleweed.Arrays.Linears.Elements.FromSystem;

public sealed class ElementOfArray<T> : IMutable<T>
{
	public ElementOfArray
	(
		IScalar<T[]> array,
		IEnumerable<INatural> indices
	) : this
	(
		array,
		new SingleOfEnumerable(indices)
	)
	{
	}
	
	public ElementOfArray
	(
		IScalar<T[]> array,
		INatural index
	) : this
	(
		array,
		new Int32FromNatural(index)
	)
	{
	}
	
	public ElementOfArray
	(
		IScalar<T[]> array,
		IScalar<Int32> index
	)
	{
		this.array = array;
		this.index = index;
	}

	public T Value
	{
		get => array.Value[index.Value];
		set => array.Value[index.Value] = value;
	}

	private readonly IScalar<T[]> array;
	
	private readonly IScalar<Int32> index;
}