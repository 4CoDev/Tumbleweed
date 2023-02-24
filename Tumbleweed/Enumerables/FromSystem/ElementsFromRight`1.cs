using Tumbleweed.Scalars;

namespace Tumbleweed.Enumerables.FromSystem;

public sealed class ElementsFromRight<T> : EnumerableEnvelope<T>
{
	public ElementsFromRight
	(
		IEnumerable<T> enumerable,
		IScalar<int> number
	) : base
	(
		new EnumerableOfScalar<T>(
			new ScalarOfDelegate<IEnumerable<T>>(
				() => enumerable.Skip(number.Value)))
	)
	{
	}
}