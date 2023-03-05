using Tumbleweed.Scalars;

namespace Tumbleweed.Enumerables.FromSystem;

public sealed class ElementsFromLeft<T> : EnumerableEnvelope<T>
{
	public ElementsFromLeft
	(
		IEnumerable<T> enumerable,
		IScalar<Int32> number
	) : this
	(
		new List<T>(enumerable),
		number
	)
	{
	}
	
	public ElementsFromLeft
	(
		ICollection<T> list,
		IScalar<Int32> number
	) : base
	(
		new TakedEnumerable<T>(
			list,
			number)
	)
	{
	}
}