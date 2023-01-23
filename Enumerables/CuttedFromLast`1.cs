using Tumbleweed.Scalars;
using Tumbleweed.WithSystem.Numerics.Ints32;

namespace Tumbleweed.Enumerables;

public sealed class CuttedFromLast<T> : EnumerableEnvelope<T>
{
	public CuttedFromLast
	(
		IEnumerable<T> enumerable,
		IScalar<int> elements
	) : this
	(
		new List<T>(enumerable),
		elements
	)
	{
	}
	
	public CuttedFromLast
	(
		ICollection<T> list,
		IScalar<int> elements
	) : base
	(
		new TakedEnumerable<T>(
			list,
			new DifferenceOf2Numbers(
				new ScalarOfValue<int>(list.Count),
				elements))
	)
	{
	}
}