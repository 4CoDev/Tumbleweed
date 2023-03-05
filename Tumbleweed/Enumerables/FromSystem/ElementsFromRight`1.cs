using Tumbleweed.Scalars;

namespace Tumbleweed.Enumerables.FromSystem;

public sealed class ElementsFromRight<T> : EnumerableEnvelope<T>
{
	public ElementsFromRight
	(
		IEnumerable<T> enumerable,
		IScalar<Int32> number
	) : base
	(
		new EnumerableOfScalar<T>(
			new ValueOfDelegate<IEnumerable<T>>(
				() => enumerable.Skip(number.Value)))
	)
	{
	}
}