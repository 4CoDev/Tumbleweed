using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace TumbleSystem.Enumerables;

public sealed class ChunkedBySize<T> : EnumerableEnvelope<IEnumerable<T>>
{
	public ChunkedBySize(IEnumerable<T> enumerable, IScalar<int> size) : base
	(
		new EnumerableOfScalar<IEnumerable<T>>(
			new Scalar.ChunkedBySize<T>(enumerable, size))
	)
	{
	}
}