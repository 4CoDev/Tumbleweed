using Tumbleweed.Number.Integer.Signed;
using Tumbleweed.Number.Integer.Signed.ToSystem._Int32;

namespace Tumbleweed._Collection;

public sealed class CollectionWithSize<T> : CollectionEnvelope<T>
{
	public CollectionWithSize
	(
		ICollection<T> collection,
		ISigned size
	) : base
	(
		new FromSystem.CollectionWithSize<T>(
			collection,
			new Int32FromSigned(size))
	)
	{
	}
}