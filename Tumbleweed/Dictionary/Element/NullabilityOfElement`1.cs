using Tumbleweed.Nullable;

namespace Tumbleweed.Dictionary.Element;

public sealed class NullabilityOfElement<T> :
	NullableEnvelope<T>
	where T : notnull
{
	public NullabilityOfElement(IDictionaryElement<T> element) : base
	(
		new NullableOfFunction<T>(
			() => element.Nullability)
	)
	{
	}
}