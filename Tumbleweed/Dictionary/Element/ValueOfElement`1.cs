using Tumbleweed.Scalar.Nullable;

namespace Tumbleweed.Dictionary.Element;

public sealed class ValueOfElement<T> : Tumbleweed.Scalar.Immutable.Envelope<T>
	where T : notnull
{
	public ValueOfElement(IDictionaryElement<T> element) : base
	(
		new NullabilityOfElement<T>(element)
	)
	{
	}
}