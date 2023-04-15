using Tumbleweed.Mutables;
using Tumbleweed.Numerics.Integers.Natural;
using Tumbleweed.Numerics.Integers.Natural.FromEnumerable;
using Tumbleweed.Numerics.Integers.Signed.ToSystem.Ints32;
using Tumbleweed.Scalars;

namespace Tumbleweed.Arrays.Linears.Elements.FromSystem;

public sealed class ElementOfArray<T> : IMutable<T>
{
	public ElementOfArray
	(
		IScalar<T[]> array,
		IEnumerable<INaturalInteger> indices
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
		INaturalInteger index
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

	public T Variable
	{
		get => array.Value[index.Value];
		set => array.Value[index.Value] = value;
	}

	private readonly IScalar<T[]> array;
	
	private readonly IScalar<Int32> index;
}