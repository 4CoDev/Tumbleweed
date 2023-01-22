using Tumbleweed.Scalars;

namespace Tumbleweed.Enumerables;

public sealed class CuttedFromFirst<T> : EnumerableEnvelope<T>
{
	public CuttedFromFirst
	(
		IEnumerable<T> enumerable,
		IScalar<int> elements
	) : base
	(
		new EnumerableOfScalar<T>(
			new ScalarOfDelegate<IEnumerable<T>>(
				() => enumerable.Skip(elements.Value())))
	)
	{
	}
}