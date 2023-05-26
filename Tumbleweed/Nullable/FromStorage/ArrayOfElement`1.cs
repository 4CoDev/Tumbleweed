using Tumbleweed.Storage.Element;

namespace Tumbleweed.Nullable.FromStorage;

public sealed class NullableOfStorageElement<T> :
	NullableEnvelope<T>
	where T : notnull
{
	public NullableOfStorageElement
	(
		IStorageElement<INullable<T>> element
	) : base
	(
		new NullableOfScalar<T>(
			new ValueOfElement<INullable<T>>(element))
	)
	{
	}
}