using Tumbleweed.Nullability;

namespace Tumbleweed.Elements;

public sealed class NullabilityOfElement<T> :
	NullableEnvelope<T>
	where T : notnull
{
	public NullabilityOfElement(IElement<T> element) : base
	(
		new NullableOfFunction<T>(
			() => element.Nullability)
	)
	{
	}
}