using Tumbleweed.Mutable;
using Tumbleweed.Number.Integer.Natural;
using Tumbleweed.Number.Integer.Natural.ToSystem;
using Tumbleweed.Scalar;

namespace Tumbleweed.Planar.Array.Element.FromSystem;

public sealed class ElementOfArray<T> : IMutable<T>
{
	public ElementOfArray
	(
		IScalar<T[,]> array,
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

	public T Value
	{
		get => array.Value[indices.ElementAt(0), indices.ElementAt(1)];
		set => array.Value[indices.ElementAt(0), indices.ElementAt(1)] = value;
	}

	private readonly IScalar<T[,]> array;
	
	private readonly ICollection<Int32> indices;
}