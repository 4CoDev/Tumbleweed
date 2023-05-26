using Tumbleweed.Scalar;
using Tumbleweed.Scalar.FromEnumerable.FromSystem;

namespace Tumbleweed._Enumerable.FromSystem;

public sealed class EnumerableAtIndex<T> : EnumerableEnvelope<T>
{
	public EnumerableAtIndex
	(
		IEnumerable<IEnumerable<T>> enumerable,
		IScalar<Int32> index
	) : base
	(
		new EnumerableOfScalar<T>(
			new ElementAtIndex<IEnumerable<T>>(enumerable, index))
	)
	{
	}
}