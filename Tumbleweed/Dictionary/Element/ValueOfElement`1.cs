using Tumbleweed.Property.Nullable;

namespace Tumbleweed.Dictionary.Element;

public sealed class ValueOfElement<T> : Tumbleweed.Property.Output.Envelope<T>
	where T : notnull
{
	public ValueOfElement(IDictionaryElement<T> element) : base
	(
		new NullabilityOfElement<T>(element)
	)
	{
	}
}