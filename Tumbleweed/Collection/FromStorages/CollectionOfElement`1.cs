using Tumbleweed.Storage.Record;
using Tumbleweed.Storage.Record.Value;

namespace Tumbleweed.Collection.FromStorages;

public sealed class CollectionOfElement<T> : CollectionEnvelope<T>
{
	public CollectionOfElement
	(
		Any<ICollection<T>> element
	) : base
	(
		new CollectionOfScalar<T>(
			new NonNullable<ICollection<T>>(element))
	)
	{
	}
}