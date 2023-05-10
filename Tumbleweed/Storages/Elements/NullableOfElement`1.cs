using Tumbleweed.Nullables;

namespace Tumbleweed.Storages.Elements;

public sealed class NullableOfElement<T> :
	NullableEnvelope<T>
	where T : notnull
{
	public NullableOfElement(IStorageElement<T> element) : base
	(
		new NullableOfFunction<T>(
			() => element.Nullable)
	)
	{
	}
}