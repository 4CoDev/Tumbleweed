using Tumbleweed.Number.Integer;
using Tumbleweed.Number.Integer.System.Medium.From.Tumbleweed;

namespace Tumbleweed.Collection;

public sealed class CollectionWithSize<T> : CollectionEnvelope<T>
{
	public CollectionWithSize
	(
		ICollection<T> collection,
		Any size
	) : base
	(
		new FromSystem.CollectionWithSize<T>(
			collection,
			new One(size))
	)
	{
	}
}