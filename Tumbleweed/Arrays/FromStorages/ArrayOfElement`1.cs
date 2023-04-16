using Tumbleweed.Storages.Elements;

namespace Tumbleweed.Arrays.FromStorages;

public sealed class ArrayOfStorageElement<T> :
	ArrayEnvelope<T>
	where T : notnull
{
	public ArrayOfStorageElement(IStorageElement<IArray<T>> element) : base
	(
		new ArrayOfScalar<T>(
			new ValueOfElement<IArray<T>>(element))
	)
	{
	}
}