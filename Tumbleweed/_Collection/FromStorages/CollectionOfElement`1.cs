using Tumbleweed.Storage.Element;

namespace Tumbleweed._Collection.FromStorages;

public sealed class CollectionOfElement<T> : CollectionEnvelope<T>
{
	public CollectionOfElement
	(
		IStorageElement<ICollection<T>> element
	) : base
	(
		new CollectionOfScalar<T>(
			new ValueOfElement<ICollection<T>>(element))
	)
	{
	}
}