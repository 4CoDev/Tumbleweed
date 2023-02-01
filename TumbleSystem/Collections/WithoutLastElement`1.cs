using Tumbleweed.Collections;
using Tumbleweed.Enumerables;

namespace TumbleSystem.Collections;

public sealed class WithoutLastElement<T> : EnumerableEnvelope<T>
{
	public WithoutLastElement(ICollection<T> collection) : base
	(
		new CollectionOfScalar<T>(
			new Scalar.WithoutLastElement<T>(collection))
	)
	{
	}
}