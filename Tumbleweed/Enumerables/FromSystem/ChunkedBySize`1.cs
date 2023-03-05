using Tumbleweed.Scalars;

namespace Tumbleweed.Enumerables.FromSystem;

public sealed class ChunkedBySize<T> : EnumerableEnvelope<IEnumerable<T>>
{
	public ChunkedBySize(IEnumerable<T> enumerable, IScalar<Int32> size) : base
	(
		new EnumerableOfScalar<IEnumerable<T>>(
			new Scalar.ChunkedBySize<T>(enumerable, size))
	)
	{
	}
}