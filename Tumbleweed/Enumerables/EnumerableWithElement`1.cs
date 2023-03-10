using Tumbleweed.Scalars;

namespace Tumbleweed.Enumerables;

public sealed class EnumerableWithElement<T> : EnumerableEnvelope<T>
{
	public EnumerableWithElement
	(
		IEnumerable<T> enumerable,
		T element
	) : base
	(
		new EnumerableOfScalar<T>(
			new ValueOfDelegate<IEnumerable<T>>(
				() => enumerable.Append(element)))
	)
	{
	}
}