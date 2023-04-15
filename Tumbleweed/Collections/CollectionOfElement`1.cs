using Tumbleweed.Elements;

namespace Tumbleweed.Collections;

public sealed class CollectionOfElement<T> : CollectionEnvelope<T>
{
	public CollectionOfElement
	(
		IElement<ICollection<T>> element
	) : base
	(
		new CollectionOfScalar<T>(
			new ValueOfElement<ICollection<T>>(element))
	)
	{
	}
}