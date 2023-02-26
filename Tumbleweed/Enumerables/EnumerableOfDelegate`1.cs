using Tumbleweed.Scalars;

namespace Tumbleweed.Enumerables;

public sealed class EnumerableOfDelegate<T> : EnumerableEnvelope<T>
{
	public EnumerableOfDelegate(Func<IEnumerable<T>> @delegate) : base
	(
		new EnumerableOfScalar<T>(
			new ValueOfDelegate<IEnumerable<T>>(@delegate))
	)
	{
	}
}