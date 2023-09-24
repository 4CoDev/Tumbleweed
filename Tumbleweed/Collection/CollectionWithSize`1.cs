using Tumbleweed.Mathematics.Number.Integer;
using Tumbleweed.Mathematics.Number.Integer.System.Medium.From.Tumbleweed;
using Tumbleweed.Mathematics.Number.Integer;

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