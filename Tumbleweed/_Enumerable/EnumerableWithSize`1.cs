using Tumbleweed._Collection;
using Tumbleweed.Number.Integer.Signed;

namespace Tumbleweed._Enumerable;

public sealed class EnumerableWithSize<T> : EnumerableEnvelope<T>
{
	public EnumerableWithSize
	(
		IEnumerable<T> enumerable,
		ISigned size
	) : base
	(
		new CollectionWithSize<T>(new List<T>(enumerable), size)
	)
	{
	}
}