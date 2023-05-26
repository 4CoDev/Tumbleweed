using Tumbleweed.Storage.Element;

namespace Tumbleweed._Enumerable.FromStorage;

public sealed class EnumerableOfElement<T> : EnumerableEnvelope<T>
{
	public EnumerableOfElement
	(
		IStorageElement<IEnumerable<T>> element
	) : base
	(
		new EnumerableOfScalar<T>(
			new ValueOfElement<IEnumerable<T>>(element))
	)
	{
	}
}