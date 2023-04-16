using Tumbleweed.Nullability;

namespace Tumbleweed.Dictionaries.Elements;

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