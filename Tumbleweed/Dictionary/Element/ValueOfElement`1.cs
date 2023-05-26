using Tumbleweed.Nullable;
using Tumbleweed.Scalar;

namespace Tumbleweed.Dictionary.Element;

public sealed class ValueOfElement<T> :
	ScalarEnvelope<T>
	where T : notnull
{
	public ValueOfElement(IDictionaryElement<T> element) : base
	(
		new ValueOfNullable<T>(
			new NullabilityOfElement<T>(element))
	)
	{
	}
}