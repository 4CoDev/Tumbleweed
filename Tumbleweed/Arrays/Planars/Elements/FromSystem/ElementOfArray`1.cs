using Tumbleweed.Mutables;
using Tumbleweed.Numerics.Integers.Natural;
using Tumbleweed.Numerics.Integers.Natural.FromEnumerable;
using Tumbleweed.Numerics.Integers.Signed.ToSystem.Ints32;
using Tumbleweed.Scalars;

namespace Tumbleweed.Arrays.Planars.Elements.FromSystem;

public sealed class ElementOfArray<T> : IMutable<T>
{
	public ElementOfArray
	(
		IScalar<T[,]> array,
		IEnumerable<INaturalInteger> indices
	) : this
	(
		array,
		new Ints32FromNaturals(indices)
	)
	{
	}
	
	public ElementOfArray
	(
		IScalar<T[,]> array,
		IEnumerable<Int32> indices
	) : this
	(
		array,
		new List<Int32>(indices)
	)
	{
	}
	
	public ElementOfArray
	(
		IScalar<T[,]> array,
		ICollection<Int32> indices
	)
	{
		this.array = array;
		this.indices = indices;
	}

	public T Variable
	{
		get => array.Value[indices.ElementAt(0), indices.ElementAt(1)];
		set => array.Value[indices.ElementAt(0), indices.ElementAt(1)] = value;
	}

	private readonly IScalar<T[,]> array;
	
	private readonly ICollection<Int32> indices;
}