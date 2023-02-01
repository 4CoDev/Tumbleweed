using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace TumbleSystem.Enumerables;

public sealed class ElementsFromLeft<T> : EnumerableEnvelope<T>
{
	public ElementsFromLeft
	(
		IEnumerable<T> enumerable,
		IScalar<int> number
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
		IScalar<int> number
	) : base
	(
		new TakedEnumerable<T>(
			list,
			number)
	)
	{
	}
}