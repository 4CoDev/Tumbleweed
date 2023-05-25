using Tumbleweed.Mutables;
using Tumbleweed.Numbers.Integers.Natural;
using Tumbleweed.Numbers.Integers.Natural.ToSystem;
using Tumbleweed.Numbers.Integers.Signed.ToSystem.Ints32;
using Tumbleweed.Scalars;

namespace Tumbleweed.Arrays.Spatials.Elements.FromSystem;

public sealed class ElementOfArray<T> : IMutable<T>
{
	public ElementOfArray
	(
		IScalar<T[,,]> array,
		IEnumerable<INatural> indices
	) : this
	(
		array,
		new Ints32FromNaturals(indices)
	)
	{
	}
	
	public ElementOfArray
	(
		IScalar<T[,,]> array,
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
		IScalar<T[,,]> array,
		ICollection<Int32> indices
	)
	{
		this.array = array;
		this.indices = indices;
	}

	public T Value
	{
		get => array.Value[
			indices.ElementAt(0),
			indices.ElementAt(1),
			indices.ElementAt(2)];

		set => array.Value[
			indices.ElementAt(0),
			indices.ElementAt(1),
			indices.ElementAt(2)] = value;
	}

	private readonly IScalar<T[,,]> array;
	
	private readonly ICollection<Int32> indices;
}