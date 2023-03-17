using Tumbleweed.Scalars;

namespace Tumbleweed.Enumerables;

public sealed class EnumerableOfFunction<T> : EnumerableEnvelope<T>
{
	public EnumerableOfFunction(Func<IEnumerable<T>> @delegate) : base
	(
		new EnumerableOfScalar<T>(
			new ValueOfFunction<IEnumerable<T>>(@delegate))
	)
	{
	}
}