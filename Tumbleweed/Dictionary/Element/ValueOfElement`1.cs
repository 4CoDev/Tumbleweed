using Tumbleweed.Nullable;

namespace Tumbleweed.Dictionary.Element;

public sealed class ValueOfElement<T> : Tumbleweed.Scalar.Envelope<T>
	where T : notnull
{
	public ValueOfElement(IDictionaryElement<T> element) : base
	(
		new Value<T>(
			new NullabilityOfElement<T>(element))
	)
	{
	}
}