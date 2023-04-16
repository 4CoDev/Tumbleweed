using Tumbleweed.Storages.Elements;

namespace Tumbleweed.Enumerables.FromStorages;

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